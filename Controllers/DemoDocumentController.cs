using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using SIHSALUS_DocumentGenerator.Services;
using System.Runtime.Loader;

namespace SIHSALUS_DocumentGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class DemoDocumentController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public DemoDocumentController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        // GET api/demodocument?fileName=FUA_1.0
        // When debug=false (default), dynamically compiles and renders a document schema (and, if
        // provided, a mapping) from .cs files stored in Utils/SchemaExamples/ and Utils/MappingExamples/,
        // so schema/mapping changes are reflected immediately without hard-coding file/class combinations.
        // When debug=true, the schema/mapping are instead resolved by class name (fileName/mappingFile)
        // from the assemblies already compiled into the running application, skipping Roslyn compilation.
        [HttpGet]
        public async Task<ActionResult> GetByFileName(
            string fileName,
            bool debug = false,
            string? visitFile = null,
            string? mappingFile = null,
            Boolean? printLayout = true)
        {
            // Case where either a mappingFile or visitFile are sent without each other
            if ((mappingFile is null) != (visitFile is null))
            {
                return BadRequest("visitFile and mappingFile must both be provided together.");
            }

            // Tracks every collectible AssemblyLoadContext created for this request so they
            // can be unloaded once the HTML has been rendered, avoiding memory accumulation.
            // Only populated when debug=false, since debug=true reuses already-loaded assemblies.
            var loadContexts = new List<AssemblyLoadContext>();

            try
            {
                var schemaResult = debug
                    ? GetContractFromCompiledAssemblies<IDocumentSchemaContract>(fileName, "Schema")
                    : await CompileFromFileAsync<IDocumentSchemaContract>(
                        fileName,
                        "SchemaExamples",
                        "Schema",
                        loadContexts);

                if (schemaResult.ErrorResult is not null)
                {
                    return schemaResult.ErrorResult;
                }

                var documentSchema = schemaResult.Instance!.Create();

                Models.DocumentEntities.DocumentRenderizationAbstractions.DocumentMapping documentMapping = null;

                if (mappingFile is not null)
                {
                    var mappingResult = debug
                        ? GetContractFromCompiledAssemblies<IDocumentMappingContract>(mappingFile, "Mapping")
                        : await CompileFromFileAsync<IDocumentMappingContract>(
                            mappingFile,
                            "MappingExamples",
                            "Mapping",
                            loadContexts);

                    if (mappingResult.ErrorResult is not null)
                    {
                        return mappingResult.ErrorResult;
                    }

                    var visitJson = await LoadVisitJson(visitFile);
                    if (visitJson is null)
                    {
                        return NotFound($"Visit file not found: {visitFile}");
                    }

                    documentMapping = mappingResult.Instance!.Create();
                    MappingService.importPayloadToMapping(visitJson, documentMapping, documentSchema);
                }

                string htmlResponse = documentSchema.Render(
                    printLayout:    printLayout ?? true, 
                    docMapping:     documentMapping
                );

                return Content(htmlResponse, "text/html");
            }
            finally
            {
                // Once the HTML has been produced, the dynamically compiled assemblies are no
                // longer needed. Unload them so the runtime can reclaim the memory they used.
                foreach (var context in loadContexts)
                {
                    context.Unload();
                }
            }
        }

        // Compiles a .cs file on disk with Roslyn, loads it into a dedicated collectible
        // AssemblyLoadContext, locates the first concrete type implementing TContract and
        // instantiates it. The load context is added to loadContexts so the caller can
        // unload it once it is no longer needed, freeing the associated memory.
        private async Task<(TContract? Instance, ActionResult? ErrorResult)> CompileFromFileAsync<TContract>(
            string fileName,
            string folderName,
            string kindLabel,
            List<AssemblyLoadContext> loadContexts)
            where TContract : class
        {
            if (!fileName.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".cs";
            }

            // Sanitize the file name to prevent path traversal attacks,
            // then resolve the full path inside the target examples directory.
            var safeFileName = Path.GetFileName(fileName);
            var filePath = Path.Combine(
                _environment.ContentRootPath,
                "Utils",
                folderName,
                safeFileName);

            if (!System.IO.File.Exists(filePath))
            {
                return (null, NotFound($"{kindLabel} file not found: {safeFileName}"));
            }

            // Read the raw C# source code from the file on disk
            var sourceCode = await System.IO.File.ReadAllTextAsync(filePath);

            // Parse the source code into a Roslyn syntax tree
            var syntaxTree = CSharpSyntaxTree.ParseText(sourceCode, path: filePath);

            // Collect metadata references from all currently loaded assemblies so the
            // dynamic compilation has access to the same types as the host application
            var references = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(assembly => !assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
                .Select(assembly => MetadataReference.CreateFromFile(assembly.Location));

            // Create a Roslyn in-memory compilation targeting a DLL output.
            // A unique assembly name is used to avoid conflicts if the same file
            // is loaded more than once during the application's lifetime.
            var compilation = CSharpCompilation.Create(
                assemblyName: $"Dynamic{kindLabel}_{Guid.NewGuid():N}",
                syntaxTrees: [syntaxTree],
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            // Emit the compiled IL into an in-memory stream instead of writing to disk
            await using var assemblyStream = new MemoryStream();
            var emitResult = compilation.Emit(assemblyStream);

            // If compilation produced errors, return them to the caller so the file
            // author can diagnose and fix the source file
            if (!emitResult.Success)
            {
                var diagnostics = emitResult.Diagnostics
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(diagnostic => diagnostic.GetMessage());

                return (null, BadRequest(new { error = $"{kindLabel} compilation failed.", diagnostics }));
            }

            // Reset the stream position and load the compiled assembly into a new
            // collectible AssemblyLoadContext so it can be unloaded (and its memory
            // reclaimed) once the caller is done using it.
            assemblyStream.Position = 0;
            var assemblyLoadContext = new AssemblyLoadContext($"Dynamic{kindLabel}_{Guid.NewGuid():N}", isCollectible: true);
            loadContexts.Add(assemblyLoadContext);
            var loadedAssembly = assemblyLoadContext.LoadFromStream(assemblyStream);

            // Locate the first concrete type that implements TContract.
            // Each file is expected to define exactly one such implementation.
            var contractType = loadedAssembly.GetTypes()
                .FirstOrDefault(type => !type.IsAbstract && typeof(TContract).IsAssignableFrom(type));

            if (contractType is null)
            {
                return (null, BadRequest(new { error = $"No implementation of {typeof(TContract).Name} was found." }));
            }

            // Instantiate the contract using the default (parameterless) constructor
            if (Activator.CreateInstance(contractType) is not TContract instance)
            {
                return (null, BadRequest(new { error = $"The {kindLabel.ToLowerInvariant()} implementation could not be created." }));
            }

            return (instance, null);
        }

        // Resolves a concrete implementation of TContract by matching its class name against
        // types already loaded in the application's compiled (non-dynamic) assemblies. Used when
        // debug=true to avoid recompiling a .cs file and instead reuse a type that already exists
        // in the built application.
        private (TContract? Instance, ActionResult? ErrorResult) GetContractFromCompiledAssemblies<TContract>(
            string className,
            string kindLabel)
            where TContract : class
        {
            var contractType = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(assembly => !assembly.IsDynamic)
                .SelectMany(assembly => assembly.GetTypes())
                .FirstOrDefault(type =>
                    !type.IsAbstract
                    && typeof(TContract).IsAssignableFrom(type)
                    && string.Equals(type.Name, className, StringComparison.OrdinalIgnoreCase));

            if (contractType is null)
            {
                return (null, new NotFoundObjectResult(new { error = $"No compiled {kindLabel.ToLowerInvariant()} implementation named '{className}' was found." }));
            }

            if (Activator.CreateInstance(contractType) is not TContract instance)
            {
                return (null, new BadRequestObjectResult(new { error = $"The {kindLabel.ToLowerInvariant()} implementation could not be created." }));
            }

            return (instance, null);
        }

        private async Task<string?> LoadVisitJson(string? visitFile)
        {
            if (string.IsNullOrWhiteSpace(visitFile))
            {
                return null;
            }

            var safeVisitFile = Path.GetFileName(visitFile);
            if (!safeVisitFile.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                safeVisitFile += ".json";
            }

            var visitPath = Path.Combine(
                _environment.ContentRootPath,
                "Utils",
                "VisitExamples",
                safeVisitFile);

            if (!System.IO.File.Exists(visitPath))
            {
                return null;
            }

            return await System.IO.File.ReadAllTextAsync(visitPath);
        }
    }
}

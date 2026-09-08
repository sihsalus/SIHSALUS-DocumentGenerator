using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
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
        // Dynamically compiles and renders a document schema from a .cs file stored in Utils/SchemaExamples/.
        [HttpGet]
        public async Task<ActionResult> GetByFileName(string fileName = "FUA_1.0")
        {
            // Ensure the file name has the .cs extension
            if (!fileName.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".cs";
            }

            // Sanitize the file name to prevent path traversal attacks,
            // then resolve the full path inside the SchemaExamples directory.
            var safeFileName = Path.GetFileName(fileName);
            var filePath = Path.Combine(
                _environment.ContentRootPath,
                "Utils",
                "SchemaExamples",
                safeFileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound($"File not found: {safeFileName}");
            }

            // Read the raw C# source code from the schema file on disk
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
            // A unique assembly name is used to avoid conflicts if the same schema
            // is loaded more than once during the application's lifetime.
            var compilation = CSharpCompilation.Create(
                assemblyName: $"DynamicSchema_{Guid.NewGuid():N}",
                syntaxTrees: [syntaxTree],
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            // Emit the compiled IL into an in-memory stream instead of writing to disk
            await using var assemblyStream = new MemoryStream();
            var emitResult = compilation.Emit(assemblyStream);

            // If compilation produced errors, return them to the caller so the schema
            // author can diagnose and fix the source file
            if (!emitResult.Success)
            {
                var diagnostics = emitResult.Diagnostics
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(diagnostic => diagnostic.GetMessage());

                return BadRequest(new { error = "Schema compilation failed.", diagnostics });
            }

            // Reset the stream position and load the compiled assembly into the
            // default AssemblyLoadContext so its types become available at runtime
            assemblyStream.Position = 0;
            var schemaAssembly = AssemblyLoadContext.Default.LoadFromStream(assemblyStream);

            // Locate the first concrete type that implements IDocumentSchemaContract.
            // Each schema file is expected to define exactly one such implementation.
            var schemaType = schemaAssembly.GetTypes()
                .FirstOrDefault(type => !type.IsAbstract && typeof(IDocumentSchemaContract).IsAssignableFrom(type));

            if (schemaType is null)
            {
                return BadRequest(new { error = "No implementation of IDocumentSchemaContract was found." });
            }

            // Instantiate the schema contract using the default (parameterless) constructor
            if (Activator.CreateInstance(schemaType) is not IDocumentSchemaContract schemaImplementation)
            {
                return BadRequest(new { error = "The schema implementation could not be created." });
            }

            // Build the document model through the contract and render it to HTML.
            // printLayout: false omits print-specific styles for browser preview.
            var documentSchema = schemaImplementation.Create();
            string htmlResponse = documentSchema.Render(printLayout: false);

            return Content(htmlResponse, "text/html");
        }
    }
}

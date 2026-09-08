using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using System.Reflection;
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

        [HttpGet]
        public async Task<ActionResult> GetByFileName(string fileName = "FUA_1.0", bool debug = false)
        {
            if (!fileName.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".cs";
            }

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

            if (debug)
            {
                if (!_environment.IsDevelopment())
                {
                    return Forbid();
                }

                var compiledSchemaType = typeof(DemoDocumentController).Assembly
                    .GetTypes()
                    .FirstOrDefault(type =>
                        !type.IsAbstract &&
                        typeof(IDocumentSchemaContract).IsAssignableFrom(type) &&
                        string.Equals(
                            type.GetCustomAttribute<SchemaFileAttribute>()?.FileName,
                            safeFileName,
                            StringComparison.OrdinalIgnoreCase));

                if (compiledSchemaType is null)
                {
                    return NotFound($"No compiled schema is registered for: {safeFileName}");
                }

                var compiledSchema = (IDocumentSchemaContract)Activator.CreateInstance(compiledSchemaType)!;
                return Content(compiledSchema.Create().Render(printLayout: false), "text/html");
            }

            var sourceCode = await System.IO.File.ReadAllTextAsync(filePath);
            var syntaxTree = CSharpSyntaxTree.ParseText(sourceCode, path: filePath);
            var references = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(assembly => !assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
                .Select(assembly => MetadataReference.CreateFromFile(assembly.Location));

            var compilation = CSharpCompilation.Create(
                assemblyName: $"DynamicSchema_{Guid.NewGuid():N}",
                syntaxTrees: [syntaxTree],
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            await using var assemblyStream = new MemoryStream();
            var emitResult = compilation.Emit(assemblyStream);
            if (!emitResult.Success)
            {
                var diagnostics = emitResult.Diagnostics
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(diagnostic => diagnostic.GetMessage());

                return BadRequest(new { error = "Schema compilation failed.", diagnostics });
            }

            assemblyStream.Position = 0;
            var schemaAssembly = AssemblyLoadContext.Default.LoadFromStream(assemblyStream);
            var schemaType = schemaAssembly.GetTypes()
                .FirstOrDefault(type => !type.IsAbstract && typeof(IDocumentSchemaContract).IsAssignableFrom(type));

            if (schemaType is null)
            {
                return BadRequest(new { error = "No implementation of IDocumentSchemaContract was found." });
            }

            if (Activator.CreateInstance(schemaType) is not IDocumentSchemaContract schemaImplementation)
            {
                return BadRequest(new { error = "The schema implementation could not be created." });
            }

            var documentSchema = schemaImplementation.Create();

            string htmlResponse = documentSchema.Render(printLayout: false);


            return Content(htmlResponse, "text/html");
        }
    }
}

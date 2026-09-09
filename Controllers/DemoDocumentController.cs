using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using SIHSALUS_DocumentGenerator.Services;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.Json;

namespace SIHSALUS_DocumentGenerator.Controllers;

[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class DemoDocumentController : ControllerBase
{
    // Dynamic source files are compiled outside the project, so they do not inherit
    // the SDK's implicit usings. Prefix the commonly required namespaces before parsing.
    private const string DynamicSourceUsings = """
        using System;
        using System.Collections.Generic;
        using System.Linq;

        """;

    private readonly IWebHostEnvironment _environment;

    public DemoDocumentController(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    /// <summary>
    /// Renders a schema example. Supply both <paramref name="visitFile"/> and
    /// <paramref name="mappingFile"/> to populate the schema from a visit payload.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult> GetByFileName(
        string fileName = "FUA_1.0",
        string? visitFile = null,
        string? mappingFile = null,
        bool debug = false )
    {
        // Normalize the schema extension, then require visit and mapper files as a pair:
        // a mapper has no purpose without a payload, and a payload has no schema mapping.
        if (!fileName.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
        {
            fileName += ".cs";
        }

        bool hasVisitFile = !string.IsNullOrWhiteSpace(visitFile);
        bool hasMappingFile = !string.IsNullOrWhiteSpace(mappingFile);

        if (hasVisitFile != hasMappingFile)
        {
            return BadRequest(new { error = "visitFile and mappingFile must be supplied together." });
        }

        if (hasVisitFile && !visitFile!.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest(new { error = "visitFile must be a .json file." });
        }

        if (hasMappingFile && !mappingFile!.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest(new { error = "mappingFile must be a .cs file." });
        }

        // Keep all file reads inside the examples folder, even when a caller sends a path.
        string safeFileName = Path.GetFileName(fileName);
        string schemaPath = Path.Combine(_environment.ContentRootPath, "Utils", "SchemaExamples", safeFileName);
        if (!System.IO.File.Exists(schemaPath))
        {
            return NotFound($"Schema file not found: {safeFileName}");
        }

        DocumentSchema documentSchema;
        if (debug)
        {
            // Development debugging uses the schema already compiled into the application.
            // SchemaFileAttribute links that compiled type back to its source-file name.
            if (!_environment.IsDevelopment())
            {
                return Forbid();
            }

            Type? compiledSchemaType = typeof(DemoDocumentController).Assembly
                .GetTypes()
                .FirstOrDefault(type =>
                    !type.IsAbstract &&
                    typeof(IDocumentSchemaContract).IsAssignableFrom(type) &&
                    string.Equals(
                        type.GetCustomAttribute<SchemaFileAttribute>()?.FileName,
                        safeFileName,
                        StringComparison.OrdinalIgnoreCase));

            if (compiledSchemaType is null ||
                Activator.CreateInstance(compiledSchemaType) is not IDocumentSchemaContract compiledSchema)
            {
                return NotFound($"No compiled schema is registered for: {safeFileName}");
            }

            documentSchema = compiledSchema.Create();
        }
        else
        {
            // Normal mode reads the selected schema source, compiles it with Roslyn in memory,
            // and creates the first class that implements the schema contract.
            string sourceCode = await System.IO.File.ReadAllTextAsync(schemaPath);
            SyntaxTree syntaxTree = ParseDynamicSource(sourceCode, schemaPath);
            CSharpCompilation compilation = CreateCompilation($"DynamicSchema_{Guid.NewGuid():N}", syntaxTree);

            await using var assemblyStream = new MemoryStream();
            EmitResult emitResult = compilation.Emit(assemblyStream);
            if (!emitResult.Success)
            {
                IEnumerable<string> diagnostics = emitResult.Diagnostics
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(diagnostic => diagnostic.GetMessage());

                return BadRequest(new { error = "Schema compilation failed.", diagnostics });
            }

            assemblyStream.Position = 0;
            // Loading from the memory stream avoids writing a temporary schema assembly to disk.
            var schemaAssembly = AssemblyLoadContext.Default.LoadFromStream(assemblyStream);
            Type? schemaType = schemaAssembly.GetTypes()
                .FirstOrDefault(type => !type.IsAbstract && typeof(IDocumentSchemaContract).IsAssignableFrom(type));

            if (schemaType is null ||
                Activator.CreateInstance(schemaType) is not IDocumentSchemaContract schemaImplementation)
            {
                return BadRequest(new { error = "No schema implementation could be created." });
            }

            documentSchema = schemaImplementation.Create();
        }

        if (hasVisitFile)
        {
            // Resolve the optional payload and mapper from their dedicated example folders.
            // Path.GetFileName prevents directory traversal outside ContentRootPath.
            string safeVisitFile = Path.GetFileName(visitFile!);
            string safeMappingFile = Path.GetFileName(mappingFile!);
            string visitPath = Path.Combine(_environment.ContentRootPath, "Utils", "VisitExamples", safeVisitFile);
            string mapperPath = Path.Combine(_environment.ContentRootPath, "Utils", "MappingExamples", safeMappingFile);

            if (!System.IO.File.Exists(visitPath))
            {
                return NotFound($"Visit file not found: {safeVisitFile}");
            }

            if (!System.IO.File.Exists(mapperPath))
            {
                return NotFound($"Mapping file not found: {safeMappingFile}");
            }

            // Mappers are compiled exactly like schemas, but must implement the mapping contract.
            string mapperSource = await System.IO.File.ReadAllTextAsync(mapperPath);
            SyntaxTree mapperSyntaxTree = ParseDynamicSource(mapperSource, mapperPath);
            CSharpCompilation mapperCompilation = CreateCompilation($"DynamicMapping_{Guid.NewGuid():N}", mapperSyntaxTree);

            await using var mapperAssemblyStream = new MemoryStream();
            EmitResult mapperEmitResult = mapperCompilation.Emit(mapperAssemblyStream);
            if (!mapperEmitResult.Success)
            {
                IEnumerable<string> diagnostics = mapperEmitResult.Diagnostics
                    .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Select(diagnostic => diagnostic.GetMessage());

                return BadRequest(new { error = "Mapping compilation failed.", diagnostics });
            }

            mapperAssemblyStream.Position = 0;
            var mapperAssembly = AssemblyLoadContext.Default.LoadFromStream(mapperAssemblyStream);
            Type? mapperType = mapperAssembly.GetTypes()
                .FirstOrDefault(type => !type.IsAbstract && typeof(IDocumentMappingContract).IsAssignableFrom(type));

            if (mapperType is null ||
                Activator.CreateInstance(mapperType) is not IDocumentMappingContract mapperImplementation)
            {
                return BadRequest(new { error = "No mapping implementation could be created." });
            }

            try
            {
                // The mapping service resolves JSON paths and writes the resulting values into
                // matching schema boxes and table cells before the schema is rendered to HTML.
                using JsonDocument visitDocument = JsonDocument.Parse(await System.IO.File.ReadAllTextAsync(visitPath));
                MappingService.ApplyMappings(visitDocument.RootElement, mapperImplementation.Create(), documentSchema);
            }
            catch (JsonException)
            {
                return BadRequest(new { error = $"Visit file is not valid JSON: {safeVisitFile}" });
            }
        }

        // Render either the original schema or the populated schema as the demo response.
        return Content(documentSchema.Render(printLayout: false), "text/html");
    }

    private static CSharpCompilation CreateCompilation(string assemblyName, SyntaxTree syntaxTree)
    {
        // Reuse loaded application/framework assemblies so dynamic scripts can reference
        // DocumentSchema, DocumentMapping, and the rest of the application's public types.
        IEnumerable<MetadataReference> references = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(assembly => !assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
            .Select(assembly => MetadataReference.CreateFromFile(assembly.Location));

        return CSharpCompilation.Create(
            assemblyName: assemblyName,
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
    }

    private static SyntaxTree ParseDynamicSource(string sourceCode, string sourcePath)
    {
        // Preserve the original source path so compiler diagnostics point to the example file.
        return CSharpSyntaxTree.ParseText(DynamicSourceUsings + sourceCode, path: sourcePath);
    }
}

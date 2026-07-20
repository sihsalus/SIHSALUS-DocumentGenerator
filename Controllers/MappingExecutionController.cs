using System.Reflection;
using System.Runtime.Loader;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SIHSALUS_DocumentGenerator.Controllers;

[ApiController]
[Route("api/mapping")]
public class MappingExecutionController : ControllerBase
{
    private readonly IWebHostEnvironment _environment;

    public MappingExecutionController(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    [HttpPost("execute")]
    public async Task<IActionResult> Execute([FromBody] JsonElement payload, [FromQuery] string mapperFile = "example1.cs")
    {
        if (string.IsNullOrWhiteSpace(mapperFile) || !mapperFile.EndsWith(".cs", StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest(new { error = "mapperFile must be a .cs file." });
        }

        var safeMapperFile = Path.GetFileName(mapperFile);
        var mapperPath = Path.Combine(_environment.ContentRootPath, "mappingExamples", safeMapperFile);
        if (!System.IO.File.Exists(mapperPath))
        {
            return NotFound(new { error = $"Mapper file not found: {safeMapperFile}" });
        }

        var sourceCode = await System.IO.File.ReadAllTextAsync(mapperPath);
        var syntaxTree = CSharpSyntaxTree.ParseText(sourceCode, CSharpParseOptions.Default, mapperPath);

        var references = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
            .Select(a => MetadataReference.CreateFromFile(a.Location))
            .Cast<MetadataReference>()
            .ToList();

        var compilation = CSharpCompilation.Create(
            assemblyName: $"DynamicMapper_{Guid.NewGuid():N}",
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        await using var assemblyStream = new MemoryStream();
        var emitResult = compilation.Emit(assemblyStream);

        if (!emitResult.Success)
        {
            var errors = emitResult.Diagnostics
                .Where(d => d.Severity == DiagnosticSeverity.Error)
                .Select(d => new
                {
                    code = d.Id,
                    message = d.GetMessage(),
                    location = d.Location.GetLineSpan().ToString()
                });

            return BadRequest(new { error = "Mapper compilation failed.", diagnostics = errors });
        }

        var mapperTypeName = GetMapperTypeName(safeMapperFile);

        assemblyStream.Position = 0;
        var assembly = AssemblyLoadContext.Default.LoadFromStream(assemblyStream);
        var mapperType = assembly.GetType($"MappingExamples.{mapperTypeName}");
        if (mapperType is null)
        {
            return BadRequest(new { error = $"Mapper type 'MappingExamples.{mapperTypeName}' was not found." });
        }

        var method = mapperType.GetMethod("Execute", BindingFlags.Public | BindingFlags.Static);
        if (method is null)
        {
            return BadRequest(new { error = "Mapper method 'Execute' was not found." });
        }

        try
        {
            var result = method.Invoke(null, [payload]);
            if (result is not string html)
            {
                return BadRequest(new { error = "Mapper returned an invalid result. Expected string HTML." });
            }

            return Content(html, "text/html");
        }
        catch (TargetInvocationException ex)
        {
            return BadRequest(new
            {
                error = "Mapper execution failed.",
                message = ex.InnerException?.Message ?? ex.Message,
                stackTrace = ex.InnerException?.StackTrace ?? ex.StackTrace
            });
        }
    }

    internal static string GetMapperTypeName(string mapperFile)
    {
        var nameWithoutExtension = Path.GetFileNameWithoutExtension(mapperFile);
        if (string.IsNullOrWhiteSpace(nameWithoutExtension))
        {
            return "Example1Mapper";
        }

        var parts = nameWithoutExtension
            .Split(['-', '_', ' '], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(p => char.ToUpperInvariant(p[0]) + p[1..]);

        return string.Concat(parts) + "Mapper";
    }
}

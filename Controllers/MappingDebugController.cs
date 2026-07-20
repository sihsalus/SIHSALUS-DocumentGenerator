using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace SIHSALUS_DocumentGenerator.Controllers;

[ApiController]
[Route("api/mapping-debug")]
public class MappingDebugController : ControllerBase
{
    [HttpPost("execute-by-route")]
    public IActionResult ExecuteByRoute([FromBody] JsonElement payload, [FromQuery] string targetRoute)
    {
        if (string.IsNullOrWhiteSpace(targetRoute))
        {
            return BadRequest(new { error = "targetRoute is required." });
        }

        if (!TryGetMapperFile(targetRoute, out var mapperFile, out var routeError))
        {
            return BadRequest(new { error = routeError });
        }

        var mapperTypeName = MappingExecutionController.GetMapperTypeName(mapperFile);
        var mapperType = typeof(MappingDebugController).Assembly.GetType($"MappingExamples.{mapperTypeName}");
        if (mapperType is null)
        {
            return NotFound(new
            {
                error = $"Compiled mapper type 'MappingExamples.{mapperTypeName}' was not found.",
                hint = "Ensure mappingExamples/<file>.cs follows the class naming convention <FileName>Mapper and is part of the project build."
            });
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

            return Ok(new
            {
                route = targetRoute,
                mapperFile,
                mapperType = $"MappingExamples.{mapperTypeName}",
                html
            });
        }
        catch (TargetInvocationException ex)
        {
            return BadRequest(new
            {
                error = "Mapper debug execution failed.",
                mapperFile,
                mapperType = $"MappingExamples.{mapperTypeName}",
                message = ex.InnerException?.Message ?? ex.Message,
                stackTrace = ex.InnerException?.StackTrace ?? ex.StackTrace
            });
        }
    }

    private static bool TryGetMapperFile(string targetRoute, out string mapperFile, out string? error)
    {
        mapperFile = "example1.cs";
        error = null;

        Uri parsed;
        if (!Uri.TryCreate(targetRoute, UriKind.Absolute, out parsed))
        {
            var normalized = targetRoute.StartsWith("/", StringComparison.Ordinal) ? targetRoute : $"/{targetRoute}";
            if (!Uri.TryCreate($"http://localhost{normalized}", UriKind.Absolute, out parsed))
            {
                error = "targetRoute is not a valid route or URL.";
                return false;
            }
        }

        if (!parsed.AbsolutePath.Equals("/api/mapping/execute", StringComparison.OrdinalIgnoreCase))
        {
            error = "targetRoute must point to /api/mapping/execute.";
            return false;
        }

        var query = QueryHelpers.ParseQuery(parsed.Query);
        if (query.TryGetValue("mapperFile", out var mapperFileValue) && !string.IsNullOrWhiteSpace(mapperFileValue))
        {
            mapperFile = Path.GetFileName(mapperFileValue.ToString());
        }

        return true;
    }
}

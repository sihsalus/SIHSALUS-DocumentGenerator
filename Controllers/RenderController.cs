using Microsoft.AspNetCore.Mvc;
using SIHSALUS_DocumentGenerator.Services;

namespace SIHSALUS_DocumentGenerator.Controllers;

[ApiController]
[Route("api/render")]
public sealed class RenderController : ControllerBase
{
    private readonly IRenderService _renderService;

    public RenderController(IRenderService renderService)
    {
        _renderService = renderService;
    }

    /// <summary>
    /// Converts an HTML document to a sanitized PDF.
    /// </summary>
    [HttpPost("pdf")]
    [Produces("application/pdf")]
    [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RenderPdf([FromBody] RenderPdfRequest request, CancellationToken cancellationToken)
    {
        try
        {
            byte[] pdf = await _renderService.RenderHtmlToPdfAsync(request.Html, cancellationToken);
            return File(pdf, "application/pdf", "document.pdf");
        }
        catch (ArgumentException exception)
        {
            return BadRequest(new { error = exception.Message });
        }
        catch (TimeoutException)
        {
            return StatusCode(StatusCodes.Status504GatewayTimeout, new { error = "PDF rendering timed out." });
        }
    }
}

public sealed record RenderPdfRequest(string Html);

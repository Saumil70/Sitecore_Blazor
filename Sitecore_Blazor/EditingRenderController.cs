using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Threading.Tasks;

[ApiController]
[Route("api/editing")]
public class EditingRenderController : ControllerBase
{
    private readonly ILogger<EditingRenderController> _logger;

    public EditingRenderController(ILogger<EditingRenderController> logger)
    {
        _logger = logger;
    }

    [HttpPost("render")]
    public async Task<IActionResult> Render()
    {
        try
        {
            // Read request body
            var requestBody = await new StreamReader(Request.Body).ReadToEndAsync();
            _logger.LogInformation($"Request Body: {requestBody}");

            // Parse JSON
            var editingData = JsonSerializer.Deserialize<JsonElement>(requestBody);

            // Extract 'args'
            if (!editingData.TryGetProperty("args", out var argsElement) || argsElement.ValueKind != JsonValueKind.Array)
            {
                return BadRequest("Missing 'args' in request.");
            }

            // Extract Experience Editor URL
            var editorUrl = argsElement[0].GetString(); // First argument
            if (string.IsNullOrEmpty(editorUrl))
            {
                return BadRequest("Invalid Experience Editor URL.");
            }

            // Return JSON with the editor URL
            return Ok(new { url = editorUrl });
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error rendering Experience Editor: {ex.Message}");
            return StatusCode(500, $"Error rendering Experience Editor: {ex.Message}");
        }
    }


}

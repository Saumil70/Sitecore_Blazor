using Microsoft.AspNetCore.Http;
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

            // Parse the incoming JSON request
            var editingData = JsonSerializer.Deserialize<JsonElement>(requestBody);

            // Extract query parameters
            var query = Request.Query.ToDictionary(q => q.Key, q => q.Value.ToString());
            _logger.LogInformation($"Query Params: {JsonSerializer.Serialize(query)}");

            // Extract cookies
            var cookies = Request.Cookies.ToDictionary(c => c.Key, c => c.Value);
            _logger.LogInformation($"Cookies: {JsonSerializer.Serialize(cookies)}");

            // Extract preview data (similar to Next.js 'previewData')
            if (editingData.TryGetProperty("previewData", out var previewDataElement))
            {
                var previewData = previewDataElement.GetRawText();
                _logger.LogInformation($"Preview Data: {previewData}");
            }

            // Extract the URL argument (similar to args[0] in Next.js)
            if (!editingData.TryGetProperty("args", out var argsElement) || argsElement.ValueKind != JsonValueKind.Array)
            {
                return BadRequest("Missing 'args' in request.");
            }

            var editorUrl = argsElement[0].GetString();
            if (string.IsNullOrEmpty(editorUrl))
            {
                return BadRequest("Invalid Experience Editor URL.");
            }

            // Simulate setting preview mode cookie
            Response.Cookies.Append("PreviewMode", "true");

            // Simulate redirect with preview data
            return Ok(new   
            {
                url = editorUrl,
                message = "Preview mode enabled",
                cookies,
                query
            });
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error processing editing request: {ex.Message}");
            return StatusCode(500, $"Error processing editing request: {ex.Message}");
        }
    }
}

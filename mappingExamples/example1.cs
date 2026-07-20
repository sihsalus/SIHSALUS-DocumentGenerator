using System.Net;
using System.Text;
using System.Text.Json;

namespace MappingExamples;

public static class Example1Mapper
{
    public static string Execute(JsonElement payload)
    {
        var html = new StringBuilder();
        html.Append("<html><head><meta charset=\"utf-8\"></head><body>");
        html.Append("<h1>Generated HTML</h1>");

        if (payload.ValueKind != JsonValueKind.Object)
        {
            html.Append("<p>Payload is not a JSON object.</p>");
            html.Append("</body></html>");
            return html.ToString();
        }

        html.Append("<ul>");
        foreach (var property in payload.EnumerateObject())
        {
            var propertyName = WebUtility.HtmlEncode(property.Name);
            var propertyValue = WebUtility.HtmlEncode(property.Value.ToString());
            html.Append($"<li><strong>{propertyName}:</strong> {propertyValue}</li>");
        }

        html.Append("</ul>");
        html.Append("</body></html>");
        return html.ToString();
    }
}

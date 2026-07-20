using SIHSALUS_DocumentGenerator.Models.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities;

/// <summary>
/// Base class for entities that store a versioned JSON/JSONC form schema declaration.
/// </summary>
public class DocumentFromSchema : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = null!;

    // Large JSONC text content — the form layout declaration
    [Required]
    public string Content { get; set; } = null!;

    [Required]
    public int Version { get; set; } = 1;

    [Required]
    [MaxLength(50)]
    public string VersionName { get; set; } = null!;

    public DocumentFromSchema()
    {
    }

    public DocumentFromSchema(JsonElement payload)
    {
        Name = GetRequiredString(payload, "name");
        Content = GetRequiredString(payload, "content");
        VersionName = GetRequiredString(payload, "versionName");
        CreatedBy = GetRequiredString(payload, "createdBy");
        Version = GetOptionalInt(payload, "version") ?? 1;
    }

    private static string GetRequiredString(JsonElement payload, string propertyName)
    {
        if (!TryGetPropertyCaseInsensitive(payload, propertyName, out var propertyValue) ||
            propertyValue.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            throw new ArgumentException($"Missing required property '{propertyName}'.", nameof(payload));
        }

        var value = propertyValue.GetString();
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"Property '{propertyName}' cannot be empty.", nameof(payload));
        }

        return value;
    }

    private static int? GetOptionalInt(JsonElement payload, string propertyName)
    {
        if (!TryGetPropertyCaseInsensitive(payload, propertyName, out var propertyValue) ||
            propertyValue.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            return null;
        }

        return propertyValue.ValueKind == JsonValueKind.Number
            ? propertyValue.GetInt32()
            : int.Parse(propertyValue.GetString() ?? "1");
    }

    private static bool TryGetPropertyCaseInsensitive(JsonElement payload, string propertyName, out JsonElement value)
    {
        foreach (var property in payload.EnumerateObject())
        {
            if (string.Equals(property.Name, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                value = property.Value;
                return true;
            }
        }

        value = default;
        return false;
    }

    public string RenderDocument()
    {
        JsonDocument jsonDocument = JsonDocument.Parse(Content);
        JsonElement contentJson = jsonDocument.RootElement;

        return "";
    }
}


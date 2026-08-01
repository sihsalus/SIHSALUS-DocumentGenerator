using System.Globalization;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

namespace SIHSALUS_DocumentGenerator.Services;

/// <summary>
/// Resolves scalar values from JSON payloads using a sequence of property names.
/// </summary>
public class MappingService
{
    /// <summary>
    /// Gets the JSON value addressed by a dot-separated path, such as
    /// <c>payload.visitType</c>. Returns <see langword="null"/> when the JSON is
    /// invalid or a path segment does not exist. A JSON null is returned as an
    /// element whose <see cref="JsonElement.ValueKind"/> is <see cref="JsonValueKind.Null"/>.
    /// </summary>
    public static JsonElement? getValueByPath(string JSONpayload, string path)
    {
        if (string.IsNullOrWhiteSpace(JSONpayload) || string.IsNullOrWhiteSpace(path))
        {
            return null;
        }

        try
        {
            using var document = JsonDocument.Parse(JSONpayload);
            var current = document.RootElement;

            foreach (var segment in path.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                if (current.ValueKind == JsonValueKind.Object && current.TryGetProperty(segment, out var property))
                {
                    current = property;
                    continue;
                }

                if (current.ValueKind == JsonValueKind.Array &&
                    int.TryParse(segment, NumberStyles.None, CultureInfo.InvariantCulture, out var index) &&
                    index >= 0 &&
                    index < current.GetArrayLength())
                {
                    current = current[index];
                    continue;
                }

                return null;
            }

            // JsonDocument is disposed when this method returns, so detach the value first.
            return current.Clone();
        }
        catch (JsonException)
        {
            return null;
        }
    }

    public static void processFieldMapping(string JSONpayload, FieldBaseMapping field)
    {
        // Check type of the field
        if (field is TableMapping table)
        {
            // use table.mappings
            TableMapping tableField = field as TableMapping;
            // Iterate over mappings
            foreach (TableFieldMapping auxMapping in tableField.mappings)
            {
                auxMapping.valueToPut = getValueByPath(
                    JSONpayload: JSONpayload,
                    path: auxMapping.target ?? ""
                ).ToString();
            }
            
        }
        else if (field is BoxMapping box)
        {
            // use box.mappings
        }
        else if (field is FieldMapping group)
        {
            // use group.fields
        }
    }
    
    
    /// <summary>
    /// Reads a JSON upload and returns the value at <paramref name="propertyPath"/>.
    /// A JSON null becomes <see langword="null"/>; numbers are returned as long,
    /// decimal, or double; and JSON strings are returned as string.
    /// </summary>
    public static void importPayloadToMapping(string JSONpayload, DocumentMapping mapping, DocumentSchema docSchema)
    {
        // Parse the json payload
        using JsonDocument doc = JsonDocument.Parse(JSONpayload);
        JsonElement root = doc.RootElement;

        // Iterate over the document
        foreach (PageMapping page in mapping.pages)
        {
            foreach(SectionMapping section in page.sections)
            {
                foreach(FieldBaseMapping field in section.fields)
                {
                    processFieldMapping(JSONpayload, field);
                }
            }
        }
    } 
}

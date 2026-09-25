using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using System.Globalization;
using System.Text.Json;

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

    public static void processFieldMapping(string JSONpayload, BaseFieldSchema field, FieldBaseMapping fieldMapping)
    {
        // Check type of the field
        if (fieldMapping is TableMapping table)
        {
            // use table.mappings
            TableMapping tableField = table;
            // Iterate over mappings
            foreach (TableFieldMapping auxMapping in tableField.mappings)
            {
                auxMapping.valueToPut = ResolveMappingValue(JSONpayload, auxMapping);
            }
            
        }
        else if (fieldMapping is BoxMapping box)
        {
            BoxFieldMapping auxMapping = box.boxMapping;
            
            auxMapping.valueToPut = ResolveMappingValue(JSONpayload, auxMapping);
            
        }
        else if (fieldMapping is FieldMapping group)
        {
            foreach (FieldBaseMapping nestedField in group.fields)
            {
                processFieldMapping(JSONpayload, field, nestedField);
            }
        }
    }

    private static string ResolveMappingValue(string JSONpayload, BaseMapping mapping)
    {

        // Select if the value is to be used or use the target with extraProcessing (if exist)
        if (mapping.value is not null)
        {
            return mapping.value;
        }
        else if (mapping.target is not null)
        {
            JsonElement? targetResult = getValueByPath(
                JSONpayload: JSONpayload,
                path: mapping.target
            );

            if(mapping.extraProcessing is not null)
            {
                return mapping.extraProcessing(targetResult?.ToString() ?? "");
            }
            else
            {
                return targetResult?.ToString() ?? "";
            }        

        }        
        
        return "ERROR";

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

        // Iterate over the document schema
        if (docSchema.pages is null) return;
        if (mapping.pages.Count == 0) return;
        foreach (PageSchema page in docSchema.pages)
        {
            // Get PageMapping that shares the same codename as the current page schema, if any
            PageMapping? pageMapping = mapping.pages.FirstOrDefault(p => p.pageNumber == page.pageNumber);

            if (pageMapping is null) continue;
            if (page.sections.Count == 0) continue;

            foreach (SectionSchema section in page.sections)
            {
                // Get SectionMapping that shares the same codename as the current page schema, if any
                SectionMapping? sectionMapping = pageMapping.sections.FirstOrDefault(p => p.codeName == section.codeName);

                if (sectionMapping is null) continue;
                if (section.fields.Count == 0) continue;

                foreach (BaseFieldSchema field in section.fields)
                {
                    // Get FieldMapping that shares the same codename as the current page schema, if any
                    FieldBaseMapping? fieldMapping = sectionMapping.fields.FirstOrDefault((item) => item.codeName == field.codeName);

                    if (fieldMapping is null) continue;

                    processFieldMapping(JSONpayload, field, fieldMapping);
                                      
                }
            }
        }
    } 
}

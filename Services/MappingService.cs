using System.Globalization;
using System.Text.Json;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using SIHSALUS_DocumentGenerator.Utils;

namespace SIHSALUS_DocumentGenerator.Services;

/// <summary>
/// Resolves a document mapping against a JSON payload and writes the resulting
/// values into a document schema.
/// </summary>
public static class MappingService
{
    /// <summary>
    /// Gets the JSON value addressed by a dot-separated path. A JSON null or an
    /// unresolved path returns <see langword="null"/>.
    /// </summary>
    public static JsonElement? getValueByPath(string JSONpayload, string path)
    {
        if (string.IsNullOrWhiteSpace(JSONpayload))
        {
            return null;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(JSONpayload);
            object? value = MappingUtils.GetValueByPath(document.RootElement, path);

            return value switch
            {
                JsonElement element => element,
                null => null,
                _ => JsonSerializer.SerializeToElement(value)
            };
        }
        catch (JsonException)
        {
            return null;
        }
    }

    /// <summary>
    /// Applies every mapping that has a matching page, section, and field in the
    /// supplied document schema. Table rows and columns are one-based, matching
    /// the coordinates used by <see cref="TableFieldMapping"/>.
    /// </summary>
    public static void ApplyMappings(JsonElement payload, DocumentMapping mapping, DocumentSchema documentSchema)
    {
        foreach (PageMapping mappingPage in mapping.pages)
        {
            PageSchema? schemaPage = documentSchema.pages?
                .FirstOrDefault(page => page.pageNumber == mappingPage.pageNumber);

            if (schemaPage?.sections is null)
            {
                continue;
            }

            var sectionOccurrences = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (SectionMapping mappingSection in mappingPage.sections)
            {
                int occurrence = GetOccurrence(sectionOccurrences, mappingSection.codeName);
                SectionSchema? schemaSection = schemaPage.sections
                    .Where(section => string.Equals(section.codeName, mappingSection.codeName, StringComparison.Ordinal))
                    .Skip(occurrence)
                    .FirstOrDefault();

                if (schemaSection is not null)
                {
                    ApplySectionMappings(payload, mappingSection, schemaSection);
                }
            }
        }
    }

    /// <summary>
    /// Backward-compatible entry point for callers that still provide the payload
    /// as JSON text.
    /// </summary>
    public static void importPayloadToMapping(string JSONpayload, DocumentMapping mapping, DocumentSchema docSchema)
    {
        using JsonDocument document = JsonDocument.Parse(JSONpayload);
        ApplyMappings(document.RootElement, mapping, docSchema);
    }

    private static void ApplySectionMappings(JsonElement payload, SectionMapping mappingSection, SectionSchema schemaSection)
    {
        var fieldOccurrences = new Dictionary<string, int>(StringComparer.Ordinal);
        foreach (FieldBaseMapping mappingField in mappingSection.fields)
        {
            int occurrence = GetOccurrence(fieldOccurrences, mappingField.codeName);
            BaseFieldSchema? schemaField = schemaSection.fields
                .Where(field => string.Equals(field.codeName, mappingField.codeName, StringComparison.Ordinal))
                .Skip(occurrence)
                .FirstOrDefault();

            if (schemaField is not null)
            {
                ApplyFieldMapping(payload, mappingField, schemaField);
            }
        }
    }

    private static void ApplyFieldMapping(JsonElement payload, FieldBaseMapping mappingField, BaseFieldSchema schemaField)
    {
        if (mappingField is TableMapping tableMapping && schemaField is TableSchema tableSchema)
        {
            foreach (TableFieldMapping cellMapping in tableMapping.mappings)
            {
                if (cellMapping.row < 1 || cellMapping.column < 1)
                {
                    continue;
                }

                Table_RowSchema? row = tableSchema.rows.FirstOrDefault(item => item.index == cellMapping.row);
                if (row is null)
                {
                    continue;
                }

                row.cells ??= [];
                while (row.cells.Count < cellMapping.column)
                {
                    row.cells.Add(new Table_CellSchema { text = string.Empty });
                }

                row.cells[cellMapping.column - 1].text = ResolveValue(payload, cellMapping);
            }

            return;
        }

        if (mappingField is BoxMapping boxMapping && schemaField is BoxSchema boxSchema)
        {
            foreach (BoxFieldMapping valueMapping in boxMapping.mappings)
            {
                boxSchema.value = ResolveValue(payload, valueMapping);
            }

            return;
        }

        if (mappingField is FieldMapping groupMapping && schemaField is FieldSchema groupSchema)
        {
            var fieldOccurrences = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (FieldBaseMapping nestedMapping in groupMapping.fields)
            {
                int occurrence = GetOccurrence(fieldOccurrences, nestedMapping.codeName);
                BaseFieldSchema? nestedSchema = groupSchema.fields
                    .Where(field => string.Equals(field.codeName, nestedMapping.codeName, StringComparison.Ordinal))
                    .Skip(occurrence)
                    .FirstOrDefault();

                if (nestedSchema is not null)
                {
                    ApplyFieldMapping(payload, nestedMapping, nestedSchema);
                }
            }
        }
    }

    private static string ResolveValue(JsonElement payload, BaseMapping mapping)
    {
        string value;
        if (mapping.value is not null)
        {
            value = mapping.value;
        }
        else if (!string.IsNullOrWhiteSpace(mapping.target))
        {
            value = ToMappingString(MappingUtils.GetValueByPath(payload, mapping.target));
        }
        else
        {
            value = string.Empty;
        }

        return mapping.extraProcessing?.Invoke(value) ?? value;
    }

    private static string ToMappingString(object? value)
    {
        return value switch
        {
            null => string.Empty,
            JsonElement element => element.GetRawText(),
            IFormattable formatted => formatted.ToString(null, CultureInfo.InvariantCulture) ?? string.Empty,
            _ => value.ToString() ?? string.Empty
        };
    }

    private static int GetOccurrence(Dictionary<string, int> occurrences, string codeName)
    {
        occurrences.TryGetValue(codeName, out int occurrence);
        occurrences[codeName] = occurrence + 1;
        return occurrence;
    }
}

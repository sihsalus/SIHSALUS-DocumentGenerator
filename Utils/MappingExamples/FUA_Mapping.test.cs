using System;
using System.Globalization;
using System.Text.Json;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

#nullable enable

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// C# translation of FUA_Mapping_1.0.js.
// Contract: the Roslyn loader creates this class and calls Create().
public class Fua_Mapping_Test : IDocumentMappingContract
{
    private const string DniPrefix = "DNI =";
    private const string ClinicalHistoryPrefix = "N° Historia Clínica = ";
    private const string WeightConceptUuid = "5089AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

    private static string SliceOrEmpty(string? value, int start, int end)
    {
        if (string.IsNullOrEmpty(value) || start < 0 || end < start || value.Length < end)
        {
            return string.Empty;
        }

        return value.Substring(start, end - start);
    }

    private static string GetObjectName(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        try
        {
            using var document = JsonDocument.Parse(value);
            return document.RootElement.ValueKind == JsonValueKind.Object &&
                   document.RootElement.TryGetProperty("name", out var name)
                ? name.GetString() ?? string.Empty
                : string.Empty;
        }
        catch (JsonException)
        {
            return string.Empty;
        }
    }

    private static string VisitTypeMarker(string? value, string visitTypePrefix)
    {
        return GetObjectName(value).StartsWith(visitTypePrefix, StringComparison.Ordinal) ? "X" : string.Empty;
    }

    private static string? FindIdentifierDisplay(string? value, string prefix)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        try
        {
            using var document = JsonDocument.Parse(value);
            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                return null;
            }

            foreach (var identifier in document.RootElement.EnumerateArray())
            {
                if (identifier.ValueKind == JsonValueKind.Object &&
                    identifier.TryGetProperty("display", out var display) &&
                    display.GetString() is { } displayValue &&
                    displayValue.StartsWith(prefix, StringComparison.Ordinal))
                {
                    return displayValue;
                }
            }
        }
        catch (JsonException)
        {
            // A malformed target value is treated like a missing identifier, as in the JS mapper.
            return "ERROR";
        }

        return null;
    }

    private static string DocumentType(string value)
    {
        return FindIdentifierDisplay(value, DniPrefix) is null ? "???" : "DNI";
    }

    private static string IdentifierValue(string value, string prefix, string resultPrefix = "")
    {
        var display = FindIdentifierDisplay(value, prefix);
        return display is null ? "???" : resultPrefix + display[prefix.Length..].Trim();
    }

    private static string BasicTriageWeight(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        try
        {
            using var document = JsonDocument.Parse(value);
            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                return string.Empty;
            }

            foreach (var encounter in document.RootElement.EnumerateArray())
            {
                if (!encounter.TryGetProperty("encounterType", out var encounterType) ||
                    !encounterType.TryGetProperty("name", out var encounterTypeName) ||
                    !string.Equals(encounterTypeName.GetString(), "Triaje", StringComparison.Ordinal) ||
                    !encounter.TryGetProperty("obs", out var observations) ||
                    observations.ValueKind != JsonValueKind.Array)
                {
                    continue;
                }

                foreach (var observation in observations.EnumerateArray())
                {
                    if (!observation.TryGetProperty("concept", out var concept) ||
                        !concept.TryGetProperty("uuid", out var uuid) ||
                        !string.Equals(uuid.GetString(), WeightConceptUuid, StringComparison.Ordinal) ||
                        !observation.TryGetProperty("value", out var weight))
                    {
                        continue;
                    }

                    if (weight.ValueKind == JsonValueKind.Number && weight.TryGetDecimal(out var number))
                    {
                        return number.ToString("F1", CultureInfo.InvariantCulture);
                    }

                    if (weight.ValueKind == JsonValueKind.String &&
                        decimal.TryParse(weight.GetString(), NumberStyles.Number, CultureInfo.InvariantCulture, out number))
                    {
                        return number.ToString("F1", CultureInfo.InvariantCulture);
                    }

                    return string.Empty;
                }
            }
        }
        catch (JsonException)
        {
            // A malformed encounters value has no printable weight.
        }

        return string.Empty;
    }

    public DocumentMapping Create()
    {
        return new DocumentMapping
        {
            name = "Ficha Única de Atención",
            pages =
            [
                new PageMapping
                {
                    pageNumber = 1,
                    sections =
                    [
                        new SectionMapping
                        {
                            codeName = "IPRESS Data",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "Visit Date",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.startDatetime", column = 1, row = 2, extraProcessing = value => SliceOrEmpty(value, 8, 10) },
                                        new TableFieldMapping { target = "payload.startDatetime", column = 2, row = 2, extraProcessing = value => SliceOrEmpty(value, 5, 7) },
                                        new TableFieldMapping { target = "payload.startDatetime", column = 3, row = 2, extraProcessing = value => SliceOrEmpty(value, 0, 4) }
                                    ]
                                },
                                new BoxMapping
                                {
                                    codeName = "Visit Time",
                                    mappings = [new BoxFieldMapping { target = "payload.startDatetime", extraProcessing = value => SliceOrEmpty(value, 11, 16) }]
                                },
                                new TableMapping
                                {
                                    codeName = "IPRESS provider",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "00000066", column = 1, row = 2 },
                                        new TableFieldMapping { value = "HOSPITAL II-1 SANTA CLOTILDE", column = 2, row = 2 }
                                    ]
                                },
                                new FieldMapping
                                {
                                    codeName = "Provider Type",
                                    fields =
                                    [
                                        new TableMapping
                                        {
                                            codeName = "Provider Type",
                                            mappings = [new TableFieldMapping { value = "X", column = 2, row = 1 }]
                                        },
                                        new BoxMapping
                                        {
                                            codeName = "Oferta Flexible Code",
                                            mappings = [new BoxFieldMapping { value = "###" }]
                                        }
                                    ]
                                },
                                new TableMapping
                                {
                                    codeName = "Visit Location Type",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "X", column = 2, row = 1 },
                                        new TableFieldMapping { value = "", column = 2, row = 2 }
                                    ]
                                },
                                new TableMapping
                                {
                                    codeName = "Visit Type",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 1, extraProcessing = value => VisitTypeMarker(value, "Consulta Ambulatoria") },
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 1, extraProcessing = value => VisitTypeMarker(value, "Consulta Por Referencia") },
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 1, extraProcessing = value => VisitTypeMarker(value, "Emergencia") }
                                    ]
                                }
                            ]
                        },
                        new SectionMapping
                        {
                            codeName = "Patient Data",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "Patient Identifiers",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.patient.identifiers", column = 1, row = 2, extraProcessing = DocumentType },
                                        new TableFieldMapping { target = "payload.patient.identifiers", column = 2, row = 2, extraProcessing = value => IdentifierValue(value, DniPrefix) }
                                    ]
                                },
                                new TableMapping
                                {
                                    codeName = "Healthcare Coverage",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "166", column = 1, row = 2 },
                                        new TableFieldMapping { target = "payload.patient.identifiers", column = 2, row = 2, extraProcessing = value => IdentifierValue(value, DniPrefix, "7-") }
                                    ]
                                },
                                new BoxMapping { codeName = "Paternal Lastname", mappings = [new BoxFieldMapping { value = "???" }] },
                                new BoxMapping { codeName = "Maternal Lastname", mappings = [new BoxFieldMapping { value = "???" }] },
                                new BoxMapping { codeName = "Firstname", mappings = [new BoxFieldMapping { value = "???" }] },
                                new BoxMapping { codeName = "Other names", mappings = [new BoxFieldMapping { value = "???" }] },
                                new TableMapping
                                {
                                    codeName = "Patient Gender",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.patient.person.gender", column = 2, row = 1, extraProcessing = value => value == "M" ? "X" : "" },
                                        new TableFieldMapping { target = "payload.patient.person.gender", column = 2, row = 2, extraProcessing = value => value == "F" ? "X" : "" }
                                    ]
                                },
                                new BoxMapping
                                {
                                    codeName = "CLINIC HISTORY NUMBER",
                                    mappings = [new BoxFieldMapping { target = "payload.patient.identifiers", extraProcessing = value => IdentifierValue(value, ClinicalHistoryPrefix) }]
                                }
                            ]
                        },
                        new SectionMapping
                        {
                            codeName = "Triages Data",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "Basic Triage",
                                    mappings = [new TableFieldMapping { target = "payload.encounters", column = 2, row = 1, extraProcessing = BasicTriageWeight }]
                                }
                            ]
                        }
                    ]
                }
            ]
        };
    }
}

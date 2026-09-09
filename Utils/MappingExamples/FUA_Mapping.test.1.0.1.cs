using System;
using System.Globalization;
using System.Text.Json;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

#nullable enable

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

/// <summary>
/// Maps the OpenMRS visit payload in Visit2.json to FUA_test2.cs.
/// Values that are not exposed by the visit payload are marked with an explicit,
/// documented default rather than inferred from unrelated clinical data.
/// </summary>
public class FuaMappingTest101 : IDocumentMappingContract
{
    private const string DniPrefix = "DNI =";
    private const string ClinicalHistoryPrefix = "N° Historia Clínica = ";
    private const string WeightConceptUuid = "5089AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

    private static string SliceOrEmpty(string? value, int start, int end)
    {
        return string.IsNullOrEmpty(value) || start < 0 || end < start || value.Length < end
            ? string.Empty
            : value.Substring(start, end - start);
    }

    private static string GetObjectName(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(value);
            return document.RootElement.ValueKind == JsonValueKind.Object &&
                   document.RootElement.TryGetProperty("name", out JsonElement name)
                ? name.GetString() ?? string.Empty
                : string.Empty;
        }
        catch (JsonException)
        {
            return string.Empty;
        }
    }

    private static string VisitTypeMarker(string? value, string visitTypeName)
    {
        return string.Equals(GetObjectName(value), visitTypeName, StringComparison.OrdinalIgnoreCase)
            ? "X"
            : string.Empty;
    }

    private static string? FindIdentifierDisplay(string? value, string prefix)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(value);
            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                return null;
            }

            foreach (JsonElement identifier in document.RootElement.EnumerateArray())
            {
                if (identifier.ValueKind == JsonValueKind.Object &&
                    identifier.TryGetProperty("display", out JsonElement display) &&
                    display.GetString() is { } displayValue &&
                    displayValue.StartsWith(prefix, StringComparison.Ordinal))
                {
                    return displayValue;
                }
            }
        }
        catch (JsonException)
        {
            // A malformed identifier collection behaves like an unavailable identifier.
        }

        return null;
    }

    private static string DocumentType(string value)
    {
        return FindIdentifierDisplay(value, DniPrefix) is null ? string.Empty : "DNI";
    }

    private static string IdentifierValue(string value, string prefix, string resultPrefix = "")
    {
        string? display = FindIdentifierDisplay(value, prefix);
        return display is null ? string.Empty : resultPrefix + display[prefix.Length..].Trim();
    }

    private static string NamePart(string? displayName, int part)
    {
        string[] parts = (displayName ?? string.Empty).Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        return part switch
        {
            0 when parts.Length > 0 => parts[0],
            1 when parts.Length > 2 => parts[^2], // Peruvian display-name assumption: final two parts are surnames.
            2 when parts.Length > 1 => parts[^1],
            _ => string.Empty
        };
    }

    private static string OtherGivenNames(string? displayName)
    {
        string[] parts = (displayName ?? string.Empty).Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        return parts.Length > 3 ? string.Join(" ", parts, 1, parts.Length - 3) : string.Empty;
    }

    private static string BasicTriageWeight(string? encountersJson)
    {
        if (string.IsNullOrWhiteSpace(encountersJson))
        {
            return string.Empty;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(encountersJson);
            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                return string.Empty;
            }

            foreach (JsonElement encounter in document.RootElement.EnumerateArray())
            {
                if (!encounter.TryGetProperty("encounterType", out JsonElement encounterType) ||
                    !encounterType.TryGetProperty("name", out JsonElement encounterTypeName) ||
                    !string.Equals(encounterTypeName.GetString(), "Triaje", StringComparison.OrdinalIgnoreCase) ||
                    !encounter.TryGetProperty("obs", out JsonElement observations) ||
                    observations.ValueKind != JsonValueKind.Array)
                {
                    continue;
                }

                foreach (JsonElement observation in observations.EnumerateArray())
                {
                    if (!observation.TryGetProperty("concept", out JsonElement concept) ||
                        !concept.TryGetProperty("uuid", out JsonElement uuid) ||
                        !string.Equals(uuid.GetString(), WeightConceptUuid, StringComparison.Ordinal) ||
                        !observation.TryGetProperty("value", out JsonElement weight))
                    {
                        continue;
                    }

                    if (weight.ValueKind == JsonValueKind.Number && weight.TryGetDecimal(out decimal number))
                    {
                        return number.ToString("F1", CultureInfo.InvariantCulture);
                    }

                    if (weight.ValueKind == JsonValueKind.String &&
                        decimal.TryParse(weight.GetString(), NumberStyles.Number, CultureInfo.InvariantCulture, out number))
                    {
                        return number.ToString("F1", CultureInfo.InvariantCulture);
                    }
                }
            }
        }
        catch (JsonException)
        {
            // A malformed encounter collection has no printable weight.
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
                                        new TableFieldMapping { target = "payload.startDatetime", column = 3, row = 2, extraProcessing = value => SliceOrEmpty(value, 0, 4) },
                                    ],
                                },
                                new BoxMapping
                                {
                                    codeName = "Visit Time",
                                    mappings = [new BoxFieldMapping { target = "payload.startDatetime", extraProcessing = value => SliceOrEmpty(value, 11, 16) }],
                                },
                                new TableMapping
                                {
                                    codeName = "IPRESS provider",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "00000066", column = 1, row = 2 }, // Assumed RENAES code for the demonstration IPRESS.
                                        new TableFieldMapping { target = "payload.location.parentLocation.display", column = 2, row = 2 },
                                    ],
                                },
                                new FieldMapping
                                {
                                    codeName = "Provider Type",
                                    fields =
                                    [
                                        new TableMapping
                                        {
                                            codeName = "Provider Type",
                                            mappings = [new TableFieldMapping { value = "X", column = 2, row = 1 }], // The visit location is an in-facility UPSS.
                                        },
                                        new BoxMapping
                                        {
                                            codeName = "Oferta Flexible Code",
                                            mappings = [new BoxFieldMapping { value = "N/A" }],
                                        },
                                    ],
                                },
                                new TableMapping
                                {
                                    codeName = "Visit Location Type",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "X", column = 2, row = 1 },
                                        new TableFieldMapping { value = string.Empty, column = 2, row = 2 },
                                    ],
                                },
                                new TableMapping
                                {
                                    codeName = "Visit Type",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 1, extraProcessing = value => VisitTypeMarker(value, "Consulta Ambulatoria") },
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 2, extraProcessing = value => VisitTypeMarker(value, "Consulta Por Referencia") },
                                        new TableFieldMapping { target = "payload.visitType", column = 2, row = 3, extraProcessing = value => VisitTypeMarker(value, "Emergencia") },
                                    ],
                                },
                            ],
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
                                        new TableFieldMapping { target = "payload.patient.identifiers", column = 2, row = 2, extraProcessing = value => IdentifierValue(value, DniPrefix) },
                                    ],
                                },
                                new TableMapping
                                {
                                    codeName = "Healthcare Coverage",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "166", column = 1, row = 2 }, // Assumed DIRESA code for this SIS sample.
                                        new TableFieldMapping { target = "payload.patient.identifiers", column = 2, row = 2, extraProcessing = value => IdentifierValue(value, DniPrefix, "7-") },
                                    ],
                                },
                                new BoxMapping { codeName = "Paternal Lastname", mappings = [new BoxFieldMapping { target = "payload.patient.person.display", extraProcessing = value => NamePart(value, 1) }] },
                                new BoxMapping { codeName = "Maternal Lastname", mappings = [new BoxFieldMapping { target = "payload.patient.person.display", extraProcessing = value => NamePart(value, 2) }] },
                                new BoxMapping { codeName = "Firstname", mappings = [new BoxFieldMapping { target = "payload.patient.person.display", extraProcessing = value => NamePart(value, 0) }] },
                                new BoxMapping { codeName = "Other names", mappings = [new BoxFieldMapping { target = "payload.patient.person.display", extraProcessing = OtherGivenNames }] },
                                new TableMapping
                                {
                                    codeName = "Patient Gender",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.patient.person.gender", column = 2, row = 1, extraProcessing = value => value == "M" ? "X" : string.Empty },
                                        new TableFieldMapping { target = "payload.patient.person.gender", column = 2, row = 2, extraProcessing = value => value == "F" ? "X" : string.Empty },
                                    ],
                                },
                                new BoxMapping { codeName = "CLINIC HISTORY NUMBER", mappings = [new BoxFieldMapping { target = "payload.patient.identifiers", extraProcessing = value => IdentifierValue(value, ClinicalHistoryPrefix) }] },
                                new BoxMapping { codeName = "ETHNICITY", mappings = [new BoxFieldMapping { value = "NO REGISTRADA" }] },
                                new TableMapping
                                {
                                    codeName = "BIRTHDATE",
                                    mappings =
                                    [
                                        new TableFieldMapping { target = "payload.patient.person.birthdate", column = 2, row = 1, extraProcessing = value => SliceOrEmpty(value, 8, 10) },
                                        new TableFieldMapping { target = "payload.patient.person.birthdate", column = 3, row = 1, extraProcessing = value => SliceOrEmpty(value, 5, 7) },
                                        new TableFieldMapping { target = "payload.patient.person.birthdate", column = 4, row = 1, extraProcessing = value => SliceOrEmpty(value, 0, 4) },
                                    ],
                                },
                            ],
                        },
                        new SectionMapping
                        {
                            codeName = "Visit Data",
                            fields =
                            [
                                new BoxMapping { codeName = "UPS", mappings = [new BoxFieldMapping { target = "payload.location.name" }] },
                                new BoxMapping { codeName = "ATTENTION CODE", mappings = [new BoxFieldMapping { value = "CONS-EXT" }] }, // Assumed outpatient consultation code.
                                new BoxMapping { codeName = "ADDITIONAL ATTENTION CODE", mappings = [new BoxFieldMapping { value = "N/A" }] },
                                new FieldMapping
                                {
                                    codeName = "Attention concept",
                                    fields =
                                    [
                                        new TableMapping { codeName = "Direction Attention", mappings = [new TableFieldMapping { value = "X", column = 2, row = 1 }] },
                                    ],
                                },
                            ],
                        },
                        new SectionMapping
                        {
                            codeName = "Triages Data",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "Basic Triage",
                                    mappings = [new TableFieldMapping { target = "payload.encounters", column = 2, row = 1, extraProcessing = BasicTriageWeight }],
                                },
                            ],
                        },
                        new SectionMapping
                        {
                            codeName = "Provider data",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "Provider data / DNI / COLEGIATURA",
                                    mappings =
                                    [
                                        new TableFieldMapping { value = "NO REGISTRADO", column = 1, row = 2 },
                                        new TableFieldMapping { target = "payload.encounters.0.encounterProviders.0.provider.person.display", column = 2, row = 2 },
                                        new TableFieldMapping { value = "NO REGISTRADO", column = 3, row = 2 },
                                    ],
                                },
                            ],
                        },
                    ],
                },
                new PageMapping
                {
                    pageNumber = 2,
                    sections =
                    [
                        new SectionMapping
                        {
                            codeName = "Medications",
                            fields =
                            [
                                new TableMapping
                                {
                                    codeName = "attention format",
                                    mappings = [new TableFieldMapping { target = "payload.uuid", column = 1, row = 1 }],
                                },
                            ],
                        },
                    ],
                },
            ],
        };
    }
}

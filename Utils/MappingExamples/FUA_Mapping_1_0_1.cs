using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using System.Text.RegularExpressions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// Readable, breakpoint-friendly version of FUA_Mapping_1.0.cs.
// Contract: Roslyn loader should create an instance and call Create().
public class Fua_Mapping_1_0_1 : IDocumentMappingContract
{
    public static string OpenMRS_DateChecker(string value, int ini, int end)
    {
        // Example: 2026-06-09T21:36:38.000+0000
        if (value == string.Empty)
        {
            throw new Exception("OpenMRS_DateChecker - Empty string.");
        }

        string pattern = @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d{3}[+-]\d{4}$";
        Boolean isValid = Regex.IsMatch(value, pattern);
        if (!isValid)
        {
            throw new Exception("OpenMRS_DateChecker - Invalid Datetime format.");
        }

        return value.Substring(8, end - 8);
    }

    // Document/page construction
    public DocumentMapping Create()
    {
        return new DocumentMapping
        {
            name = "Ficha Única de Atención",
            pages =
            [
                CreatePage1()
            ]
        };
    }

    private PageMapping CreatePage1()
    {
        return new PageMapping
        {
            pageNumber = 1,
            sections =
            [
                CreateMinsaSymbolsSection(),
                CreateIpressDataSection()
            ]
        };
    }

    // Section construction
    private SectionMapping CreateMinsaSymbolsSection()
    {
        return new SectionMapping
        {
            codeName = "MINSA Symbols",
            fields = []
        };
    }

    private SectionMapping CreateIpressDataSection()
    {
        return new SectionMapping
        {
            codeName = "IPRESS Data",
            fields =
            [
                CreateVisitDateMapping(),
                CreateVisitTimeMapping(),
                CreateIpressProviderMapping(),
                CreateProviderTypeMapping()
            ]
        };
    }

    // Individual field mappings
    private TableMapping CreateVisitDateMapping()
    {
        return new TableMapping
        {
            codeName = "Visit Date",
            mappings =
            [
                CreateVisitDayMapping(),
                CreateVisitMonthMapping(),
                CreateVisitYearMapping()
            ]
        };
    }

    private TableFieldMapping CreateVisitDayMapping()
    {
        return new TableFieldMapping
        {
            target = "payload.startDatetime",
            column = 1,
            row = 2,
            extraProcessing = ExtractVisitDay
        };
    }

    private TableFieldMapping CreateVisitMonthMapping()
    {
        return new TableFieldMapping
        {
            target = "payload.startDatetime",
            column = 2,
            row = 2,
            extraProcessing = ExtractVisitMonth
        };
    }

    private TableFieldMapping CreateVisitYearMapping()
    {
        return new TableFieldMapping
        {
            target = "payload.startDatetime",
            column = 2,
            row = 2,
            extraProcessing = ExtractVisitYear
        };
    }

    private BoxMapping CreateVisitTimeMapping()
    {
        return new BoxMapping
        {
            codeName = "Visit Time",
            boxMapping =
            
                CreateVisitTimeFieldMapping()
            
        };
    }

    private BoxFieldMapping CreateVisitTimeFieldMapping()
    {
        return new BoxFieldMapping
        {
            target = "payload.startDatetime",
            extraProcessing = ExtractVisitTime
        };
    }

    private TableMapping CreateIpressProviderMapping()
    {
        return new TableMapping
        {
            codeName = "IPRESS provider",
            mappings =
            [
                CreateIpressRenaesCodeMapping(),
                CreateIpressNameMapping()
            ]
        };
    }

    private TableFieldMapping CreateIpressRenaesCodeMapping()
    {
        return new TableFieldMapping
        {
            value = "00000066",
            column = 1,
            row = 2
        };
    }

    private TableFieldMapping CreateIpressNameMapping()
    {
        return new TableFieldMapping
        {
            value = "HOSPITAL II-1 SANTA CLOTILDE",
            column = 2,
            row = 2
        };
    }

    private FieldMapping CreateProviderTypeMapping()
    {
        return new FieldMapping
        {
            codeName = "Provider Type",
            fields =
            [
                CreateProviderTypeTableMapping(),
                CreateOfertaFlexibleCodeMapping()
            ]
        };
    }

    private TableMapping CreateProviderTypeTableMapping()
    {
        return new TableMapping
        {
            codeName = "Provider Type",
            mappings =
            [
                CreateProviderTypeMarkerMapping()
            ]
        };
    }

    private TableFieldMapping CreateProviderTypeMarkerMapping()
    {
        return new TableFieldMapping
        {
            value = "X",
            column = 2,
            row = 1
        };
    }

    private BoxMapping CreateOfertaFlexibleCodeMapping()
    {
        return new BoxMapping
        {
            codeName = "Oferta Flexible Code",
            boxMapping = CreateOfertaFlexibleCodeFieldMapping()
            
        };
    }

    private BoxFieldMapping CreateOfertaFlexibleCodeFieldMapping()
    {
        return new BoxFieldMapping
        {
            value = "###"
        };
    }

    // Transformation functions
    private string ExtractVisitDay(string value)
    {
        var result = OpenMRS_DateChecker(value, 8, 10);
        return result;
    }

    private string ExtractVisitMonth(string value)
    {
        var result = OpenMRS_DateChecker(value, 5, 7);
        return result;
    }

    private string ExtractVisitYear(string value)
    {
        var result = OpenMRS_DateChecker(value, 0, 4);
        return result;
    }

    private string ExtractVisitTime(string value)
    {
        var result = OpenMRS_DateChecker(value, 11, 16);
        return result;
    }
}

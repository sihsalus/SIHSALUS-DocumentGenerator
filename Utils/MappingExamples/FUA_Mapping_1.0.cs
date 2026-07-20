using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// Friendly template for developers writing mapping scripts with typing support.
// Contract: Roslyn loader should create an instance and call Create().
public class Fua_Mapping : IDocumentMappingContract
{
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
                            codeName = "MINSA Symbols",
                            fields = []
                        },
                        new SectionMapping
                        {
                            codeName = "IPRESS Data",
                            fields = []
                            /*fields =
                            [
                                new TableMapping {
                                    codeName = "Visit Date",                                    
                                    top = 2.4,
                                    left = 0.0,
                                    showLabel = true,
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    //fieldType = FieldTypeEnum.Table,
                                    columns = [
                                        new Table_ColumnMapping{
                                            width = 10.1
                                        },
                                         new Table_ColumnMapping{
                                            width = 10.7
                                        },
                                         new Table_ColumnMapping{
                                            width = 29.2
                                        }
                                    ]
                                }
                            ]*/
                        }
                    ]
                }
            ]
        };
    }

    
}



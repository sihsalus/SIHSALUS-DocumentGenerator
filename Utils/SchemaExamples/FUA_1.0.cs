using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// Friendly template for developers writing mapping scripts with typing support.
// Contract: Roslyn loader should create an instance and call Create().
public class DocumentSchemaImplementation : IDocumentSchemaContract
{
    public DocumentSchema Create()
    {
        return new DocumentSchema
        {
            name = "Ficha Única de Atención",
            pages =
            [
                new PageSchema
                {
                    pageNumber = 1,
                    height = 306.0,
                    width = 210.0,
                    sections =
                    [
                        new SectionSchema 
                        {
                            codeName = "MINSA Symbols",
                            showTitle = false,
                            top = 0.0,
                            left = 0.0,
                            fields = []
                        },
                        new SectionSchema
                        {
                            codeName = "IPRESS Data",
                            showTitle = true,
                            title = "FORMATO UNICO DE ATENCIÓN - FUA",
                            titleHeight = 1.0,
                            bodyHeight = 58.0,
                            bodyWidth = 192.0,
                            top = 7.7,
                            left = 0.0,
                            fields =
                            [
                                new TableSchema {
                                    codeName = "Visit Date",                                    
                                    top = 2.4,
                                    left = 0.0,
                                    showLabel = true,
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    //fieldType = FieldTypeEnum.Table,
                                    columns = [
                                        new Table_ColumnSchema{
                                            width = 10.1
                                        },
                                         new Table_ColumnSchema{
                                            width = 10.7
                                        },
                                         new Table_ColumnSchema{
                                            width = 29.2
                                        }
                                    ],
                                    rows=[
                                        new Table_RowSchema{
                                            index=1,
                                            height= 3.2,
                                            cells=[
                                                new Table_CellSchema {
                                                    text= "DIA",
                                                    extraStyles= "background-color: #F0F0F0;"
                                                },
                                                new Table_CellSchema {
                                                    text= "MES",
                                                    extraStyles= "background-color: #F0F0F0;"
                                                },
                                                new Table_CellSchema {
                                                    text= "AÑO",
                                                    extraStyles= "background-color: #F0F0F0;"
                                                }
                                            ]
                                        }
                                    ]
                                }
                            ]
                        }
                    ]
                }
            ]
        };
    }

    
}



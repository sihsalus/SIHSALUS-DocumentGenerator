using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using System.Text.RegularExpressions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// Friendly template for developers writing mapping scripts with typing support.
// Contract: Roslyn loader should create an instance and call Create().
public class Fua_Mapping : IDocumentMappingContract
{
    public static string OpenMRS_DateChecker(string value, int ini, int end)
    {
        //Example
        //2026-06-09T21:36:38.000+0000
        
        //Make sure its not Empty
        if (value == string.Empty) throw new Exception("OpenMRS_DateChecker - Empty string.");

        string pattern = @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d{3}[+-]\d{4}$";
        Boolean isValid = Regex.IsMatch(value, pattern);
        if(!isValid) throw new Exception("OpenMRS_DateChecker - Invalid Datetime format.");


        return value.Substring(8, end - 8);
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
                            codeName = "MINSA Symbols",
                            fields = []
                        },
                        new SectionMapping
                        {
                            codeName = "IPRESS Data",
                            fields =
                            [
                                // Visit Date
                                new TableMapping {
                                    codeName = "Visit Date",
                                    mappings = [
                                        // DIA
                                        new TableFieldMapping {
                                            target = "payload.startDatetime",
                                            column = 1,
                                            row = 2,
                                            extraProcessing = (string value) => {
                                                return OpenMRS_DateChecker (value, 8, 10);
                                            }
                                        },
                                        //MES
                                        new TableFieldMapping {
                                            target = "payload.startDatetime",
                                            column = 2,
                                            row = 2,
                                            extraProcessing = (string value) => {
                                                return OpenMRS_DateChecker (value, 5, 7);
                                            }
                                        },
                                        //AÑO
                                        new TableFieldMapping {
                                            target = "payload.startDatetime",
                                            column = 2,
                                            row = 2,
                                            extraProcessing = (value) => {
                                                return OpenMRS_DateChecker (value, 0, 4);
                                            }
                                        }
                                    ]
                                },
                                // Visit Time
                                new BoxMapping {
                                    codeName = "Visit Time",
                                    mappings = [
                                        new BoxFieldMapping {
                                            target = "payload.startDatetime",
                                            extraProcessing = (string value) => {
                                                return OpenMRS_DateChecker (value, 11, 16);
                                            }
                                        }
                                    ]
                                },
                                // IPRESS Info
                                new TableMapping {
                                    codeName = "IPRESS provider",
                                    mappings = [
                                        // RENAES Code
                                        new TableFieldMapping {
                                            value = "00000066",
                                            column = 1,
                                            row = 2
                                        },
                                        // NOMBRE IPRESS
                                        new TableFieldMapping {
                                            value = "HOSPITAL II-1 SANTA CLOTILDE",
                                            column = 2,
                                            row = 2
                                        }
                                    ]
                                },
                                // Provider Type
                                new FieldMapping {
                                    codeName = "Provider Type",
                                    fields = [
                                        // Provider Type
                                        new TableMapping {
                                            codeName = "Provider Type",
                                            mappings = [
                                                new TableFieldMapping {
                                                    value = "X",
                                                    column = 2,
                                                    row = 1
                                                }
                                            ]
                                        },
                                        // CODIGO DE LA OFERTA FLEXIBLE
                                        new BoxMapping {
                                            codeName = "Oferta Flexible Code",
                                            mappings = [
                                                new BoxFieldMapping {
                                                    value = "###"
                                                }
                                            ]
                                        }
                                    ]
                                },
                                // TODO: cambiar con la locacion dinamica de location type
                                // Visit Location Typr
                                new TableMapping {
                                    codeName = "Visit Location Type",

                                }
                            ]
                        }
                    ]
                }
            ]
        };
    }

    
}



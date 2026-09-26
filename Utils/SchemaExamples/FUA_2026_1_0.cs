using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

// Typed C# schema generated from FUA_1.0.jsonc.
public class FUA_2026_1_0 : IDocumentSchemaContract
{
    public DocumentSchema Create()
    {
        return new DocumentSchema
        {
            name = "Ficha \u00DAnica de Atenci\u00F3n",
            pages =
            [
                new PageSchema
                {
                    pageNumber = 1,
                    height = 340.0,
                    width = 210.0,
                    extraStyles = "",
                    sections =
                    [
                        new SectionSchema
                        {
                            codeName = "MINSA Symbols",
                            title = "",
                            showTitle = false,
                            bodyHeight = 9.0,
                            bodyWidth = 192.0,
                            top = 0.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "IPRESS Data",
                            title = "FORMATO UNICO DE ATENCI\u00D3N - FUA",
                            showTitle = true,
                            titleHeight = 3.5,
                            bodyHeight = 48.0,
                            bodyWidth = 192.0,
                            top = 9.5,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "FUA Information",
                                    top = 0.8,
                                    left = 42.3,
                                    showLabel = false,
                                    label = null,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 39.7 },
                                        new Table_ColumnSchema { width = 13.7 },
                                        new Table_ColumnSchema { width = 54.4 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "RENIPRESS" },
                                                new Table_CellSchema { text = "LOTE" },
                                                new Table_CellSchema { text = "N\u00D9MERO DE FORMATO" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 7.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "00000066" },
                                                new Table_CellSchema { text = "26" },
                                                new Table_CellSchema { text = "XXXXXXXX" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "IPRESS Infomarmation",
                                    top = 13.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "DE LA INSTITUCION PRESTRADORA DE SERVICIOS SALUD",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.0,
                                    width = 196.0,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 83.7 },
                                        new Table_ColumnSchema { width = 107.3 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "C\u00D3DIGO RENIPRESS DE LA IPRESS" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS QUE REALIZA LA ATENCI\u00D3N" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 7.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "00000066" },
                                                new Table_CellSchema { text = "SANTA CLOTILDE" },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = "Provider Type",
                                    top = 28.0,
                                    left = -0.3,
                                    showLabel = true,
                                    label = "PERSONAL QUE ATIENDE",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    width = 52.5,
                                    height = 14.0,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "Provider Type",
                                            top = -0.2,
                                            left = -0.2,
                                            showLabel = false,
                                            label = "C\u00D3DIGO DE LA OFERTA\u003Cbr\u003EFLEXIBLE",
                                            labelPosition = LabelPosition.Top,
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 5.6,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 18.8 },
                                                new Table_ColumnSchema { width = 5.3 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 4.9,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "DE LA IPRESS", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 4.5,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "ITINERANTE", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 4.5,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "OFERTA FLEXIBLE", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ]
                                                },
                                            ]
                                        },
                                        new BoxSchema
                                        {
                                            codeName = "Oferta Flexible Code",
                                            top = -0.2,
                                            left = 23.8,
                                            showLabel = true,
                                            label = "C\u00D3DIGO DE LA OFERTA\u003Cbr\u003EFLEXIBLE",
                                            labelPosition = LabelPosition.Top,
                                            labelHeight = 4.8,
                                            labelExtraStyles = "line-height: 1.9mm;",
                                            width = 28.5,
                                            height = 8.9,
                                            value = "",
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Visit Location Type",
                                    top = 28.5,
                                    left = 52.5,
                                    showLabel = true,
                                    label = "LUGAR DE ATENCI\u00D3N",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 16.2 },
                                        new Table_ColumnSchema { width = 6.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.9,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "INTRAMURAL" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EXTRAMURAL" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Visit Type",
                                    top = 28.5,
                                    left = 74.7,
                                    showLabel = true,
                                    label = "ATENCI\u00D3N",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.2,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 21.0 },
                                        new Table_ColumnSchema { width = 5.7 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "AMBULATORIA" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "REFERENCIA" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EMERGENCIA" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "IPRESS Info",
                                    top = 28.5,
                                    left = 101.5,
                                    showLabel = true,
                                    label = "REFERENCIA REALIZADA POR",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.8,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 20.5 },
                                        new Table_ColumnSchema { width = 51.0 },
                                        new Table_ColumnSchema { width = 17.8 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "C\u00D3D. RENAES" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS U OFERTA FLEXIBLE" },
                                                new Table_CellSchema { text = "N\u00BA DE HOJA DE\u003Cbr\u003E REFERENCIA" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 9.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Patient Data",
                            title = "DEL ASEGURADO USUARIO",
                            showTitle = true,
                            titleHeight = 2.5,
                            bodyHeight = 57.2,
                            bodyWidth = 192.0,
                            top = 61.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Patient Identifiers",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "IDENTIFICACI\u00D3N",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 10.0 },
                                        new Table_ColumnSchema { width = 32.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.9,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "TDI" },
                                                new Table_CellSchema { text = "N\u00BA DOCUMENTO DE IDENTIDAD" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.8,
                                            cells =
                                            [
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Healthcare Coverage",
                                    top = 0.0,
                                    left = 43.5,
                                    showLabel = true,
                                    label = "C\u00D3DIGO DEL ASEGURADO SIS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 3.0,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 12.8 },
                                        new Table_ColumnSchema { width = 39.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DIRESA /\u003Cbr\u003EOTROS", extraStyles = "line-height: 1.9mm;" },
                                                new Table_CellSchema { text = "N\u00DAMERO" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.8,
                                            cells =
                                            [
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Other insurance",
                                    top = 0.0,
                                    left = 97.0,
                                    showLabel = true,
                                    label = "ASEGURADO DE OTRAS IAFAS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 16.0 },
                                        new Table_ColumnSchema { width = 78.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "INSTITUCI\u00D3N" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "C\u00D2D SEGURO" },
                                            ]
                                        },
                                    ]
                                },
                                new BoxSchema
                                {
                                    codeName = "Paternal Lastname",
                                    top = 12.5,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "APELLIDO PATERNO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 95.5,
                                    height = 6.4,
                                },
                                new BoxSchema
                                {
                                    codeName = "Maternal Lastname",
                                    top = 12.5,
                                    left = 97.0,
                                    showLabel = true,
                                    label = "APELLIDO MATERNO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 94.0,
                                    height = 6.4,
                                },
                                new BoxSchema
                                {
                                    codeName = "Firstname",
                                    top = 21.5,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "PRIMER NOMBRE",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 95.5,
                                    height = 6.5,
                                },
                                new BoxSchema
                                {
                                    codeName = "Other names",
                                    top = 21.5,
                                    left = 97.0,
                                    showLabel = true,
                                    label = "OTROS NOMBRES",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 94.0,
                                    height = 6.5,
                                },
                                new TableSchema
                                {
                                    codeName = "Patient Gender",
                                    top = 31.0,
                                    left = 0,
                                    showLabel = true,
                                    label = "SEXO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.9,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 13.9 },
                                        new Table_ColumnSchema { width = 8.5 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "MASCULINO" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FEMININO" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "MATERNAL HEALTH",
                                    top = 41.5,
                                    left = 0,
                                    showLabel = true,
                                    label = "SALUD MATERNA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 13.8 },
                                        new Table_ColumnSchema { width = 8.5 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "GESTANTE" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "PUERPERA" },
                                            ]
                                        },
                                    ]
                                },
                                new BoxSchema
                                {
                                    codeName = "CLINIC HISTORY NUMBER",
                                    top = 31.5,
                                    left = 106.0,
                                    showLabel = true,
                                    label = "N\u00B0 DE HISTORIA CL\u00CDNICA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.8,
                                    width = 44.0,
                                    height = 6.9,
                                    value = "",
                                },
                                new BoxSchema
                                {
                                    codeName = "ETHNICITY",
                                    top = 31.5,
                                    left = 152.4,
                                    showLabel = true,
                                    label = "ETNIA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.8,
                                    width = 38.5,
                                    height = 6.9,
                                },
                                new TableSchema
                                {
                                    codeName = "DATE OF DEATH",
                                    top = 31.0,
                                    left = 23.4,
                                    showLabel = false,
                                    label = "FECHA DE FALLECIMIENTO",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 3.1,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 23.2 },
                                        new Table_ColumnSchema { width = 15.5 },
                                        new Table_ColumnSchema { width = 14.0 },
                                        new Table_ColumnSchema { width = 29.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FECHA" },
                                                new Table_CellSchema { text = "DIA" },
                                                new Table_CellSchema { text = "MES" },
                                                new Table_CellSchema { text = "A\u00D1O" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 7.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FECHA PROBABLE DE\u003Cbr\u003EPARTO / FECHA DE\u003Cbr\u003EPARTO", extraStyles = "font-size: 1.55mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "BIRTHDATE",
                                    top = 41.3,
                                    left = 23.4,
                                    showLabel = false,
                                    label = "",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 23.1 },
                                        new Table_ColumnSchema { width = 15.8 },
                                        new Table_ColumnSchema { width = 14.0 },
                                        new Table_ColumnSchema { width = 29.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.1,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FECHA DE NACIMIENTO" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "DATE OF DEATH",
                                    top = 48.5,
                                    left = 23.4,
                                    showLabel = false,
                                    label = "FECHA DE FALLECIMIENTO",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 23.1 },
                                        new Table_ColumnSchema { width = 15.8 },
                                        new Table_ColumnSchema { width = 14.0 },
                                        new Table_ColumnSchema { width = 29.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.1,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FECHA DE\u003Cbr\u003EFALLECIMIENTO" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "DNI/Affiliation",
                                    top = 41.7,
                                    left = 105.8,
                                    showLabel = false,
                                    label = "",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 34.9 },
                                        new Table_ColumnSchema { width = 50.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.3,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACI\u00D3N DEL RN 1" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACI\u00D3N DEL RN 2" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 4.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACI\u00D3N DEL RN 3" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Visit Data",
                            title = "DE LA ATENCI\u00D3N",
                            showTitle = true,
                            titleHeight = 3.0,
                            bodyHeight = 40.2,
                            bodyWidth = 192.0,
                            top = 121.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new BoxSchema
                                {
                                    codeName = "Visit Time",
                                    top = 0.0,
                                    left = 50.6,
                                    showLabel = true,
                                    label = "HORA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.5,
                                    width = 14.5,
                                    height = 9.0,
                                },
                                new TableSchema
                                {
                                    codeName = "Visit Date",
                                    top = 0.0,
                                    left = 0,
                                    showLabel = true,
                                    label = "FECHA DE ATENCI\u00D3N",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 3.2,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 9.8 },
                                        new Table_ColumnSchema { width = 10.7 },
                                        new Table_ColumnSchema { width = 29.2 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DIA" },
                                                new Table_CellSchema { text = "MES" },
                                                new Table_CellSchema { text = "A\u00D1O" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 7.4,
                                            cells =
                                            [
                                            ]
                                        },
                                    ]
                                },
                                new BoxSchema
                                {
                                    codeName = "UPS",
                                    top = 0.0,
                                    left = 66.0,
                                    showLabel = true,
                                    label = "UPS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.2,
                                    width = 8.6,
                                    height = 9.4,
                                    value = "",
                                },
                                new BoxSchema
                                {
                                    codeName = "ATTENTION CODE",
                                    top = 0.2,
                                    left = 75.4,
                                    showLabel = true,
                                    label = "C\u00D3DIGO \u003Cbr\u003EPRESTACIONAL",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.0,
                                    labelExtraStyles = "font-size: 1.8mm; line-height: 2.4mm;",
                                    width = 16.3,
                                    height = 9.4,
                                    value = "",
                                },
                                new BoxSchema
                                {
                                    codeName = "ADDITIONAL ATTENTION CODE",
                                    top = 0.2,
                                    left = 92.5,
                                    showLabel = true,
                                    label = "\u003Cp style=\u0027line-height: 1.5mm; font-size: 1.5mm;\u0027\u003EC\u00D3DIGO PRESTACIONAL(ES)\u003Cbr\u003EADICIONAL(ES)\u003C/p\u003E",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.0,
                                    width = 29.4,
                                    height = 9.4,
                                    value = "",
                                },
                                new BoxSchema
                                {
                                    codeName = "N\u00B0 FUA TO BE LINKED",
                                    top = 15.0,
                                    left = 67.6,
                                    showLabel = true,
                                    label = "N\u00B0 FUA A VINCULAR",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.8,
                                    width = 54.5,
                                    height = 4.1,
                                },
                                new TableSchema
                                {
                                    codeName = "LINKED REPORT",
                                    top = 15.0,
                                    left = -0.2,
                                    showLabel = true,
                                    label = "REPORTE\u003Cbr\u003EVINCULADO",
                                    labelPosition = LabelPosition.Left,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelWidth = 26.9,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 40.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "C\u00D3D. AUTORIZACI\u00D3N", extraStyles = "font-size: 1.7mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "HOSPITALISATION",
                                    top = 0.5,
                                    left = 132.9,
                                    showLabel = false,
                                    label = "HOSPITALIZACI\u00D3N",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 19.3 },
                                        new Table_ColumnSchema { width = 10.3 },
                                        new Table_ColumnSchema { width = 10.6 },
                                        new Table_ColumnSchema { width = 17.8 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "FECHA" },
                                                new Table_CellSchema { text = "DIA" },
                                                new Table_CellSchema { text = "MES" },
                                                new Table_CellSchema { text = "A\u00D1O" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DE INGRESO" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 6.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DE ALTA" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 6.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DE CORTE\u003Cbr\u003EADMINISTRATIVO" },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = "Attention concept",
                                    top = 22.7,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "CONCEPTO PRESTACIONAL",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 3.0,
                                    width = 190.7,
                                    height = 13.1,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "Direction Attention",
                                            top = -0.2,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "ATENCI\u00D3N DIRECTA",
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 13.4 },
                                                new Table_ColumnSchema { width = 6.8 },
                                                new Table_ColumnSchema { width = 93.5 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 12.9,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "ATENCI\u00D3N\u003Cbr\u003EDIRECTA" },
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                            ]
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Burial",
                                            top = -0.2,
                                            left = 119.2,
                                            showLabel = true,
                                            label = "SEPELIO",
                                            labelPosition = LabelPosition.Top,
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 3.0,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 21.1 },
                                                new Table_ColumnSchema { width = 9.0 },
                                                new Table_ColumnSchema { width = 12.8 },
                                                new Table_ColumnSchema { width = 10.5 },
                                                new Table_ColumnSchema { width = 9.0 },
                                                new Table_ColumnSchema { width = 9.2 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 10.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "NATIMUERTO" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "OBITO" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "OTRO" },
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Reference Data",
                            title = "DEL DESTINO DEL ASEGURADO/USUARIO",
                            showTitle = true,
                            titleHeight = 3.0,
                            bodyHeight = 70.1,
                            bodyWidth = 192.0,
                            top = 164.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Normal Destiny",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 4.5 },
                                        new Table_ColumnSchema { width = 5.3 },
                                        new Table_ColumnSchema { width = 10.2 },
                                        new Table_ColumnSchema { width = 6.6 },
                                        new Table_ColumnSchema { width = 19.5 },
                                        new Table_ColumnSchema { width = 6.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "ALTA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CITA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "HOSPITALIZACI\u00D3N", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "REFFERED DESTINY",
                                    top = 0.0,
                                    left = 52.0,
                                    showLabel = true,
                                    label = "REFERIDO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.0,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 15.2 },
                                        new Table_ColumnSchema { width = 6.6 },
                                        new Table_ColumnSchema { width = 21.5 },
                                        new Table_ColumnSchema { width = 5.5 },
                                        new Table_ColumnSchema { width = 21.0 },
                                        new Table_ColumnSchema { width = 6.4 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EMERGENCIA", extraStyles = "font-size: 1.5mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CONSULTA EXTERNA", extraStyles = "font-size: 1.5mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "APOYO AL\u003Cbr\u003EDIAGN\u00D3STICO", extraStyles = "font-size: 1.5mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "COUNTER REFERRED",
                                    top = 0.0,
                                    left = 128.2,
                                    showLabel = false,
                                    label = "",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 17.0 },
                                        new Table_ColumnSchema { width = 4.6 },
                                        new Table_ColumnSchema { width = 17.8 },
                                        new Table_ColumnSchema { width = 5.3 },
                                        new Table_ColumnSchema { width = 8.8 },
                                        new Table_ColumnSchema { width = 9.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CONTRA\u003Cbr\u003ERREFERIDO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "FALLECIDO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CORTE\u003Cbr\u003EADMINIS.", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "REFFERS / COUNTERREFERS TO",
                                    top = 7.4,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "SE REFIERE / CONTRARREFIERE A:",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.9,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 38.0 },
                                        new Table_ColumnSchema { width = 107.0 },
                                        new Table_ColumnSchema { width = 46.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.3,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "C\u00D3DIGO RENAES DE LA IPRESS", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS A LA QUE SE REFIERE / CONTRARREFIERE", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "N\u00B0 HOJA DE REFER / CONTRARR.", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.9,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Triages Data",
                            title = "ACTIVIDADES PREVENTIVAS Y OTROS",
                            showTitle = true,
                            titleHeight = 2.5,
                            bodyHeight = 47.0,
                            bodyWidth = 119.5,
                            top = 187.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Basic Triage",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "ACTIVIDADES PREVENTIVAS",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 13.6 },
                                        new Table_ColumnSchema { width = 10.5 },
                                        new Table_ColumnSchema { width = 11.6 },
                                        new Table_ColumnSchema { width = 10.3 },
                                        new Table_ColumnSchema { width = 13.1 },
                                        new Table_ColumnSchema { width = 14.5 },
                                        new Table_ColumnSchema { width = 10.0 },
                                        new Table_ColumnSchema { width = 11.9 },
                                        new Table_ColumnSchema { width = 9.9 },
                                        new Table_ColumnSchema { width = 12.9 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "PESO (kg)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "TALLA (cm)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "P.A. (mmHg)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "IMC\u003Cbr\u003E(Kg/m2)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "PAB (cm)" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Young Adult Eval",
                                    top = 5.1,
                                    left = 100.1,
                                    showLabel = true,
                                    label = "\u003Cp style=\u0027line-height: 1.5mm; font-size: 1.6mm; padding: 0.1mm\u0027\u003EJOVEN Y\u003Cbr\u003EADULTO\u003C/p\u003E",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 12.7 },
                                        new Table_ColumnSchema { width = 5.7 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.1,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EVALUACI\u00D3N \u003Cbr\u003E INTEGRAL", extraStyles = "font-size: 1.4mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Young Adult Eval",
                                    top = 16.8,
                                    left = 100.2,
                                    showLabel = true,
                                    label = "ADULTO\u003Cbr\u003EMAYOR",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.5,
                                    labelExtraStyles = "font-size: 1.8mm; line-height: 2.4mm;",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 12.6 },
                                        new Table_ColumnSchema { width = 5.5 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "VACAM", extraStyles = "font-size: 1.6mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 7.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "TAMIZAJE\u003Cbr\u003EDE SALUD\u003Cbr\u003EMENTAL", extraStyles = "font-size: 1.6mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Cronic Pathologies Screening",
                                    top = 36.3,
                                    left = 18.2,
                                    showLabel = true,
                                    label = "TAMIZAJE DE PATOLOG\u00CDAS CR\u00D3NICAS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.8,
                                    labelExtraStyles = "font-size: 1.8mm; line-height: 2.4mm;",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 20.3 },
                                        new Table_ColumnSchema { width = 10.7 },
                                        new Table_ColumnSchema { width = 24.3 },
                                        new Table_ColumnSchema { width = 9.8 },
                                        new Table_ColumnSchema { width = 25.4 },
                                        new Table_ColumnSchema { width = 9.6 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "HB. GLICOSILADA\u003Cbr\u003E(MG/DL)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "DOSAJE DE ALBUMINA\u003Cbr\u003EEN ORINA (UG/ML)" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "DEPURACI\u00D3N DE\u003Cbr\u003ECREATININA (ML/MIN)" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Of the pregnant woman",
                                    top = 5.1,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "DE LA\u003Cbr\u003EGESTANTE",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.3,
                                    labelExtraStyles = "line-height: 2.2mm;",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 9.5 },
                                        new Table_ColumnSchema { width = 7.1 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CPN (N\u00B0)", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EDAD\u003Cbr\u003EGEST", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 6.4,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "ALTURA\u003Cbr\u003EUTERIA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 7.4,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "PARTO\u003Cbr\u003EVERTICAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 10.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CONTROL\u003Cbr\u003EPUERP\u003Cbr\u003E(N\u00B0)", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Of the newborn",
                                    top = 5.0,
                                    left = 18.3,
                                    showLabel = true,
                                    label = "DEL RECIEN NACIDO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.8,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 19.0 },
                                        new Table_ColumnSchema { width = 9.0 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "EDAD GEST RN\u003Cbr\u003E(SEM)", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Apgar",
                                    top = 16.6,
                                    left = 18.3,
                                    showLabel = false,
                                    label = "APGAR",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 8.1 },
                                        new Table_ColumnSchema { width = 3.1 },
                                        new Table_ColumnSchema { width = 6.1 },
                                        new Table_ColumnSchema { width = 3.1 },
                                        new Table_ColumnSchema { width = 7.6 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 12.4,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "APGAR", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "1\u00B0", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "5\u00B0", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Corte Tard\u00EDo de Cord\u00F3n",
                                    top = 28.9,
                                    left = 18.3,
                                    showLabel = false,
                                    label = "Corte Tard\u00EDo de Cord\u00F3n",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 6.8,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 20.1 },
                                        new Table_ColumnSchema { width = 7.9 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CORTE TARD\u00CDO DE\u003Cbr\u003ECORD\u00D3N (2 A 3 MIN)", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "PREGNANT/IN/CHILD/ADOLESCENT/YOUNG AND ADULT/OLDER ADULT",
                                    top = 5.0,
                                    left = 47.5,
                                    showLabel = true,
                                    label = "\u003Cp style=\u0027line-height: 1.5mm; font-size: 1.6mm; padding: 0.1mm\u0027\u003EGESTANTE /RN/NI\u00D1O/ADOLESCENTE/JOVEN Y\u003Cbr\u003EADULTO/ADULTO MAYOR \u003C/p\u003E",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.6,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 14.7 },
                                        new Table_ColumnSchema { width = 11.5 },
                                        new Table_ColumnSchema { width = 9.6 },
                                        new Table_ColumnSchema { width = 15.9 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CRED N\u00B0", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Premature, LOW BIRTH WEIGHT",
                                    top = 16.5,
                                    left = 47.5,
                                    showLabel = false,
                                    label = "R.N. PREMATURO, BAJO PESO AL NACER",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 19.6 },
                                        new Table_ColumnSchema { width = 6.4 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "R.N. PREMATURO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 6.3,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "BAJO PESO A\u003Cbr\u003ENACER", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "CONGENITAL DISEASE / SEQUEL AT BIRTH, NUMBER OF RELATIVES AT GEST / PUERP. MAT. HOME",
                                    top = 28.5,
                                    left = 47.5,
                                    showLabel = false,
                                    label = "ENFER. CONGENITA / SECUELA AL NACER, N\u00B0 FAMILIARES DE GEST / PUERP. CASA MAT.",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 19.6 },
                                        new Table_ColumnSchema { width = 6.2 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "ENFER. CONGENITA /\u003Cbr\u003ESECUELA AL NACER", extraStyles = "font-size: 1.6mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Nutritional Counseling, TAP/EEDP or TEPSI",
                                    top = 16.5,
                                    left = 73.5,
                                    showLabel = false,
                                    label = "CONSEJERIA NUTRICIONAL, TAP/EEDP o TEPSI",
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 16.2 },
                                        new Table_ColumnSchema { width = 9.2 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "TAP/EEDP O\u003Cbr\u003ETEPST", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 6.4,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CONSEJERIA\u003Cbr\u003ENUTRICIONAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "NUTRITIONAL COUNSELING, BMI (Kg/M\u00B2)",
                                    top = 28.7,
                                    left = 73.6,
                                    showLabel = false,
                                    label = "CONSEJERIA NUTRICIONAL, IMC (Kg/M\u00B2)",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 16.1 },
                                        new Table_ColumnSchema { width = 9.2 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "CONSEJERIA\u003Cbr\u003EINTEGRAL", extraStyles = "font-size: 1.6mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Triages Data",
                            title = "VACUNA N\u00BA DE DOSIS",
                            showTitle = true,
                            titleHeight = 2.5,
                            bodyHeight = 47.0,
                            bodyWidth = 72.0,
                            top = 187.0,
                            left = 120.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Immunisation data",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "IMMUNIZACI\u00D3N DATA",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 12.9 },
                                        new Table_ColumnSchema { width = 9.9 },
                                        new Table_ColumnSchema { width = 14.6 },
                                        new Table_ColumnSchema { width = 10.0 },
                                        new Table_ColumnSchema { width = 14.7 },
                                        new Table_ColumnSchema { width = 8.8 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "BCG", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "INFLUENZA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTIMARILICA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 6.2,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "DPT", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "PAROTID", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTINEUMOC", extraStyles = "font-size: 1.8mm; padding: 0.3mm; " },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 5.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "APO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "RUBEOLA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTITETANICA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 5.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "ASA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; " },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ROTAVIRUS", extraStyles = "font-size: 1.8mm; padding: 0.3mm; " },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "COMPLETAS\u003Cbr\u003EPARA LA EDAD", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "SI _ NO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 6.3,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "SPR", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "DT ADULTO\u003Cbr\u003E(N\u00B0 DOSIS)", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "VPH", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 6,
                                            height = 3.8,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "SR", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "IPV", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "VARICELA", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 7,
                                            height = 6.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "HVB", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "PENTAVAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm; " },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "OTRA VACUNA\u003Cbr\u003E______", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Risk group number",
                                    top = 38.6,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "GRUPO DE RIESGO HVB",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 18.1 },
                                        new Table_ColumnSchema { width = 7.0 },
                                        new Table_ColumnSchema { width = 45.8 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.3,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "GRUPO DE RIESGO\u003Cbr\u003EHVB", extraStyles = "font-size: 1.8mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "GRUPO DE RIESGO HVB: 1. TRABAJADOR DE SALUD 2. TRABAJAD.\u003Cbr\u003ESEXUALES 3. HSH 4. PRIVADO LIBERTAD 5. FF. AA. 6. POLICIA\u003Cbr\u003ENACIONAL 7. ESTUDIANTES DE SALUD 8. POLITRANFUNDIDOS 9.\u003Cbr\u003EDROGO DEPENDIENTES", extraStyles = "font-size: 1.4mm;" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Diagnostics data",
                            title = "DIAGN\u00D3STICOS",
                            showTitle = true,
                            titleHeight = 2.2,
                            bodyHeight = 28.9,
                            bodyWidth = 192.0,
                            top = 237.5,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Diagnostics Table",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = null,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 4.6 },
                                        new Table_ColumnSchema { width = 114.5 },
                                        new Table_ColumnSchema { width = 4.5 },
                                        new Table_ColumnSchema { width = 4.5 },
                                        new Table_ColumnSchema { width = 4.5 },
                                        new Table_ColumnSchema { width = 24.3 },
                                        new Table_ColumnSchema { width = 5.2 },
                                        new Table_ColumnSchema { width = 5.2 },
                                        new Table_ColumnSchema { width = 23.6 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.6,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "N\u00BA" },
                                                new Table_CellSchema { text = "DESCRIPCI\u00D3N" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "1" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "2" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "3" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "4" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 6,
                                            height = 4.5,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "5" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                        new SectionSchema
                        {
                            codeName = "Provider data",
                            title = "NOMBRE DEL RESPONSABLE DE LA ATENCI\u00D3N",
                            showTitle = false,
                            titleHeight = 2.3,
                            bodyHeight = 51.5,
                            bodyWidth = 192.0,
                            top = 270.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "Provider data / DNI / COLEGIATURA",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.0,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 38.5 },
                                        new Table_ColumnSchema { width = 113.2 },
                                        new Table_ColumnSchema { width = 39.1 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 1.0,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "N\u00B0 DE DNI" },
                                                new Table_CellSchema { text = "NOMBRE DEL REPONSABLE DE LA ATENCI\u00D3N" },
                                                new Table_CellSchema { text = "N\u00B0 DE COLEGIATURA" },
                                            ]
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.9,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new TableSchema
                                {
                                    codeName = "Provider data / Specialisation / N\u00B0 RNE/ Graduate",
                                    top = 8.1,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "",
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.0,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 38.5 },
                                        new Table_ColumnSchema { width = 7.7 },
                                        new Table_ColumnSchema { width = 20.8 },
                                        new Table_ColumnSchema { width = 54.8 },
                                        new Table_ColumnSchema { width = 15.1 },
                                        new Table_ColumnSchema { width = 14.8 },
                                        new Table_ColumnSchema { width = 30.0 },
                                        new Table_ColumnSchema { width = 9.1 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.1,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "RESPONSABLE DE LA ATENCI\u00D3N" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "ESPECIALIDAD" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "N\u00B0 RNE" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "EGRESADO" },
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                    ]
                },
                new PageSchema
                {
                    pageNumber = 2,
                    height = 330.0,
                    width = 210.0,
                    sections =
                    [
                        new SectionSchema
                        {
                            codeName = "Medications",
                            title = "",
                            showTitle = false,
                            titleHeight = 3.0,
                            bodyHeight = 286.0,
                            bodyWidth = 199.0,
                            top = 0.0,
                            left = 0.0,
                            extraStyles = "",
                            fields =
                            [
                                new TableSchema
                                {
                                    codeName = "attention format",
                                    top = 0.0,
                                    left = 107.3,
                                    showLabel = true,
                                    label = "FORMATO DE ATENCION N\u00B0",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    columns =
                                    [
                                        new Table_ColumnSchema { width = 35.8 },
                                        new Table_ColumnSchema { width = 15.0 },
                                        new Table_ColumnSchema { width = 39.7 },
                                    ],
                                    rows =
                                    [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.7,
                                            cells =
                                            [
                                                new Table_CellSchema { text = "" },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = "MEDICATION LIST LABEL",
                                    top = 9.2,
                                    left = 2.3,
                                    showLabel = true,
                                    label = "PRODUCTOS FARMACE\u00D9TIVOS / MEDICAMENTOS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 1.8,
                                    labelExtraStyles = "font-size: 1.2mm;",
                                    width = 195.5,
                                    height = 138.0,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "Medications list 1",
                                            top = -0.1,
                                            left = -0.1,
                                            showLabel = false,
                                            label = "MEDICAMENTOS 2",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.0,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.5 },
                                                new Table_ColumnSchema { width = 49.2 },
                                                new Table_ColumnSchema { width = 5.9 },
                                                new Table_ColumnSchema { width = 18.5 },
                                                new Table_ColumnSchema { width = 5.5 },
                                                new Table_ColumnSchema { width = 5.3 },
                                                new Table_ColumnSchema { width = 5.1 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO\u003Cbr\u003ESISMED", extraStyles = "font-size: 0.8mm; " },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "FF", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "CONCENTR", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "PREN", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "ENTR", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; " },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00143", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ACICLOVIR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00184", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO ACETILSALIC\u00CDLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00230", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO F\u00D3LICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00231", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO F\u00D3LICO \u002B FERROSO SULFATO (Eq. de Hierro elemental)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.4 mg \u002B 60 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00257", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/5 mL - 20 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00258", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00081", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALUMINIO HIDR\u00D3XIDO - MAGNESIO HIDR\u00D3XIDO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00612", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00613", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00360", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00361", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00362", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00364", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00365", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA (COMO SAL S\u00D3DICA) CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00083", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATORVASTATINA (COMO SAL C\u00C1LCICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00917", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATROPINA SULFATO - 500 \u00B5g/mL (0.5 mg/mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00373", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00374", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg/5 mL - 15 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA (COMO FOSFATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00945", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00946", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "18179", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA S\u00D3DICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,000,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "18181", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA S\u00D3DICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2,400,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01486", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,200,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01484", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "600,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01303", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZOATO DE BENCILO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "LOC", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/100 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01527", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENTIAMINA (COMO DIPIROPATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00532", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CALCIO CARBONATO (Equivale 500 mg)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01327", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAPTOPRIL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01584", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARBIDOPA \u002B LEVODOPA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25/250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01876", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CEFTRIAXONA S\u00D3DICA (COMO SAL S\u00D3DICA) CON DILUYENTE \u002B", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ECT INY 1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01596", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CIPROFLOXACINO (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01964", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO FOSFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 36,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01965", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL (COMO SUCCINATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 37,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01967", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 38,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02194", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 39,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02195", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 40,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02208", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 41,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02162", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 42,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02163", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 43,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02667", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 44,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02668", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 45,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02669", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA (FOSFATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 46,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02718", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXCLORFENIRAMINA BROMHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 47,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02725", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg/5 mL - 120 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 48,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02726", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 49,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02787", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 50,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02788", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 51,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02812", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO S\u00D3DICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 52,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02813", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO S\u00D3DICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "75 mg/3 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 53,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02821", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL S\u00D3DICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 54,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02822", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL S\u00D3DICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 55,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03048", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIFENHIDRAMINA CLORHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 56,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03105", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DOXICICLINA (COMO HICLATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 57,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03145", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ENALAPRIL MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 58,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03317", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03318", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 2.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                            ]
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Medications list 2",
                                            top = 0.0,
                                            left = 97.8,
                                            showLabel = false,
                                            label = "MEDICAMENTOS 2",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.0,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.5 },
                                                new Table_ColumnSchema { width = 49.2 },
                                                new Table_ColumnSchema { width = 5.9 },
                                                new Table_ColumnSchema { width = 18.5 },
                                                new Table_ColumnSchema { width = 5.5 },
                                                new Table_ColumnSchema { width = 5.3 },
                                                new Table_ColumnSchema { width = 5.1 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO\u003Cbr\u003ESISMED", extraStyles = "font-size: 0.8mm; " },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "FF", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "CONCENTR", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "PREN", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "ENTR", extraStyles = "font-size: 1.4mm; " },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; " },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00143", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ACICLOVIR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00184", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO ACETILSALIC\u00CDLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00230", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO F\u00D3LICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00231", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "\u00C1CIDO F\u00D3LICO \u002B FERROSO SULFATO (Eq. de Hierro elemental)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.4 mg \u002B 60 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00257", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/5 mL - 20 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00258", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00081", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALUMINIO HIDR\u00D3XIDO - MAGNESIO HIDR\u00D3XIDO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00612", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00613", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00360", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00361", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00362", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00364", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00365", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA (COMO SAL S\u00D3DICA) CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00083", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATORVASTATINA (COMO SAL C\u00C1LCICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00917", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATROPINA SULFATO - 500 \u00B5g/mL (0.5 mg/mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00373", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00374", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg/5 mL - 15 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA (COMO FOSFATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00945", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00946", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "18179", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA S\u00D3DICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,000,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "18181", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA S\u00D3DICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2,400,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01486", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,200,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01484", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "600,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01303", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZOATO DE BENCILO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "LOC", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/100 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01527", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENTIAMINA (COMO DIPIROPATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "00532", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CALCIO CARBONATO (Equivale 500 mg)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01327", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAPTOPRIL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01584", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARBIDOPA \u002B LEVODOPA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25/250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01876", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CEFTRIAXONA S\u00D3DICA (COMO SAL S\u00D3DICA) CON DILUYENTE \u002B", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ECT INY 1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01596", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CIPROFLOXACINO (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01964", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO FOSFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 36,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01965", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL (COMO SUCCINATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 37,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "01967", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 38,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02194", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 39,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02195", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 40,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02208", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 41,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02162", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 42,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02163", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 43,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02667", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 44,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02668", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 45,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02669", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA (FOSFATO S\u00D3DICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 46,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02718", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXCLORFENIRAMINA BROMHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 47,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02725", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg/5 mL - 120 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 48,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02726", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 49,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02787", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 50,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02788", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 51,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02812", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO S\u00D3DICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 52,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02813", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO S\u00D3DICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "75 mg/3 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 53,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02821", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL S\u00D3DICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 54,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "02822", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL S\u00D3DICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 55,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03048", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIFENHIDRAMINA CLORHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 56,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03105", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DOXICICLINA (COMO HICLATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 57,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03145", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ENALAPRIL MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 58,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03317", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 2.3,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "03318", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 2.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = " Medical dispositives",
                                    top = 149.0,
                                    left = 2.5,
                                    showLabel = true,
                                    label = "DISPOSITIVOS M\u00C9DICOS / PRODUCTOS SANITARIOS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    labelExtraStyles = "font-size: 1.2mm;",
                                    width = 195.5,
                                    height = 30.4,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "COMPLEMENTARY SUPPLIES list 1",
                                            top = 0.0,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "INSUMOS COMPLEMENTARIOS 1",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.4,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.4 },
                                                new Table_ColumnSchema { width = 49.5 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 18.5 },
                                                new Table_ColumnSchema { width = 5.3 },
                                                new Table_ColumnSchema { width = 5.1 },
                                                new Table_ColumnSchema { width = 5.3 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.2,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "PR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARACT", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "PRES", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ENTR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36413", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36414", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36415", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36416", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36417", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36418", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36419", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36420", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36421", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.7,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36422", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36423", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 4.0,
                                                    cells =
                                                    [
                                                    ]
                                                },
                                            ]
                                        },
                                        new TableSchema
                                        {
                                            codeName = "COMPLEMENTARY SUPPLIES list 2",
                                            top = 0.0,
                                            left = 98.0,
                                            showLabel = false,
                                            label = "INSUMOS COMPLEMENTARIOS 2",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.4,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.4 },
                                                new Table_ColumnSchema { width = 49.5 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 18.5 },
                                                new Table_ColumnSchema { width = 5.3 },
                                                new Table_ColumnSchema { width = 5.1 },
                                                new Table_ColumnSchema { width = 5.0 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.2,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "PR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARACT", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36413", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36414", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 2.1,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36415", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36416", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36417", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36418", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36419", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36420", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36421", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.7,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36422", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36423", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 4.0,
                                                    cells =
                                                    [
                                                    ]
                                                },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY Field",
                                    top = 182.1,
                                    left = 2.3,
                                    showLabel = true,
                                    label = "PROCEDIMIENTOS/DIAGN\u00D3STICO POR IMAGENES/ LABORATORIO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 191.0,
                                    height = 76.85,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY list 1",
                                            top = 2.5,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "PROCEDIMIENTOS/DIAGN\u00D3STICO POR IMAGENES/ LABORATORIO 1",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.0,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.5,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "INB", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "D0120", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "Examen estol\u00F3gico (Examen bucal)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 1.6,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                            ]
                                        },
                                        new TableSchema
                                        {
                                            codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY list 2",
                                            top = 2.5,
                                            left = 96.0,
                                            showLabel = false,
                                            label = "PROCEDIMIENTOS/DIAGN\u00D3STICO POR IMAGENES/ LABORATORIO 2",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.0,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "C\u00D3DIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "INB", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 2.0,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ]
                                                },
                                            ]
                                        },
                                    ]
                                },
                                new FieldSchema
                                {
                                    codeName = "PERFORMANCE SUBCOMPONENT Field",
                                    top = 275.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "SUB COMPONENTE PRESTACIONAL (MEDICALMENTOS, INSUMOS Y/O PROCEDIMIENTOS)",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    width = 191.0,
                                    height = 8.9,
                                    fields =
                                    [
                                        new TableSchema
                                        {
                                            codeName = "PERFORMANCE SUBCOMPONENT Table",
                                            top = 2.4,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "",
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.3,
                                            columns =
                                            [
                                                new Table_ColumnSchema { width = 8.3 },
                                                new Table_ColumnSchema { width = 73.2 },
                                                new Table_ColumnSchema { width = 19.6 },
                                                new Table_ColumnSchema { width = 16.9 },
                                                new Table_ColumnSchema { width = 15.1 },
                                                new Table_ColumnSchema { width = 22.7 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 7.7 },
                                                new Table_ColumnSchema { width = 11.0 },
                                            ],
                                            rows =
                                            [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.9,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "CODIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "CARACT", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "IND/PRES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "EJE/ENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "N\u00B0TICKET", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "PO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.5,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.5,
                                                    cells =
                                                    [
                                                        new Table_CellSchema { text = "" },
                                                    ]
                                                },
                                            ]
                                        },
                                    ]
                                },
                            ]
                        },
                    ]
                },
            ]
        };
    }
}

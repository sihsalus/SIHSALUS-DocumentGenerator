using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

namespace SIHSALUS_DocumentGenerator.Utils.MappingExamples;

[SchemaFile("FUA_test.cs")]
public class FuaTestDocumentSchemaImplementation : IDocumentSchemaContract
{
    public DocumentSchema Create()
        {
        return new DocumentSchema
        {
            name = "Ficha Única de Atención",
            pages = [
                new PageSchema
                {
                    pageNumber = 1,
                    height = 306.0,
                    width = 210.0,
                    sections = [
                        new SectionSchema
                        {
                            codeName = "MINSA Symbols",
                            showTitle = false,
                            bodyHeight = 10.0,
                            bodyWidth = 192.0,
                            top = 0.0,
                            left = 0.0,
                        },
                        new SectionSchema
                        {
                            codeName = "IPRESS Data",
                            title = "FORMATO UNICO DE ATENCIÓN - FUA",
                            showTitle = true,
                            titleHeight = 1.0,
                            bodyHeight = 58.0,
                            bodyWidth = 192.0,
                            top = 7.7,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Visit Date",
                                    top = 2.4,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "FECHA DE ATENCIÓN",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 10.1 },
                                        new Table_ColumnSchema { width = 10.7 },
                                        new Table_ColumnSchema { width = 29.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.2,
                                            cells = [
                                                new Table_CellSchema { text = "DIA", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "MES", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "AÑO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.0,
                                        },
                                    ],
                                },
                                new BoxSchema
                                {
                                    codeName = "Visit Time",
                                    top = 2.4,
                                    left = 54.0,
                                    showLabel = true,
                                    label = "HORA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 5.6,
                                    width = 12.0,
                                    height = 4.0,
                                },
                                new TableSchema
                                {
                                    codeName = "IPRESS provider",
                                    top = 2.5,
                                    left = 69.0,
                                    showLabel = true,
                                    label = "DE LA INSTITUCIÒN PRESTADORA DE SERVICIOS DE SALUD",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.4,
                                    columns = [
                                        new Table_ColumnSchema { width = 41.0 },
                                        new Table_ColumnSchema { width = 80.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.2,
                                            cells = [
                                                new Table_CellSchema { text = "CÓDIGO RENAES DE LA IPRESS", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS QUE REALIZA LA ATENCIÓN", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
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
                                    labelHeight = 4.0,
                                    width = 52.7,
                                    height = 22.5,
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "Provider Type",
                                            top = -0.2,
                                            left = -0.2,
                                            showLabel = false,
                                            label = "CÓDIGO DE LA OFERTA<br>FLEXIBLE",
                                            columns = [
                                                new Table_ColumnSchema { width = 18.0 },
                                                new Table_ColumnSchema { width = 5.0 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 4.38,
                                                    cells = [
                                                        new Table_CellSchema { text = "DE LA IPRESS", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 4.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "ITINERANTE", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 4.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "PLAN MAS SALUD", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 4.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "OFERTA FLEXIBLE", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 4.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "TELESALUD", extraStyles = "font-size: 1.8mm; text-align: left;" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new BoxSchema
                                        {
                                            codeName = "Oferta Flexible Code",
                                            top = -0.2,
                                            left = 22.8,
                                            showLabel = true,
                                            label = "CÓDIGO DE LA OFERTA<br>FLEXIBLE",
                                            labelPosition = LabelPosition.Top,
                                            labelHeight = 4.2,
                                            labelExtraStyles = "line-height: 1.9mm;",
                                            width = 29.5,
                                            height = 17.9,
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Visit Location Type",
                                    top = 28.0,
                                    left = 52.5,
                                    showLabel = true,
                                    label = "LUGAR DE ATENCIÓN",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.0,
                                    columns = [
                                        new Table_ColumnSchema { width = 16.2 },
                                        new Table_ColumnSchema { width = 6.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "INTRAMURAL", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "EXTRAMURAL", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Visit Type",
                                    top = 28.0,
                                    left = 74.7,
                                    showLabel = true,
                                    label = "ATENCIÓN",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.0,
                                    columns = [
                                        new Table_ColumnSchema { width = 22.0 },
                                        new Table_ColumnSchema { width = 5.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "AMBULATORIA", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 8.0,
                                            cells = [
                                                new Table_CellSchema { text = "REFERENCIA", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 8.0,
                                            cells = [
                                                new Table_CellSchema { text = "EMERGENCIA", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "IPRESS Info",
                                    top = 28.0,
                                    left = 102.0,
                                    showLabel = true,
                                    label = "REFERENCIA REALIZADA POR",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.0,
                                    columns = [
                                        new Table_ColumnSchema { width = 20.5 },
                                        new Table_ColumnSchema { width = 51.0 },
                                        new Table_ColumnSchema { width = 17.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "CÓD. RENAES", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS U OFERTA FLEXIBLE", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "Nº DE HOJA DE<br> REFERENCIA", extraStyles = "background-color: #F0F0F0; line-height: 2.0mm;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 16.0,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Patient Data",
                            title = "DEL ASEGURADO USUARIO",
                            showTitle = true,
                            titleHeight = 2.2,
                            bodyHeight = 55.7,
                            bodyWidth = 192.0,
                            top = 70.0,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Patient Identifiers",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "IDENTIFICACIÓN",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns = [
                                        new Table_ColumnSchema { width = 10.0 },
                                        new Table_ColumnSchema { width = 32.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "TDI", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "Nº DOCUMENTO DE IDENTIDAD", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.9,
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Healthcare Coverage",
                                    top = 0.0,
                                    left = 44.0,
                                    showLabel = true,
                                    label = "CÓDIGO DEL ASEGURADO SIS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    columns = [
                                        new Table_ColumnSchema { width = 12.6 },
                                        new Table_ColumnSchema { width = 39.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "DIRESA /<br>OTROS", extraStyles = "background-color: #F0F0F0; line-height: 1.9mm;" },
                                                new Table_CellSchema { text = "NÚMERO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.9,
                                        },
                                    ],
                                },
                                new BoxSchema
                                {
                                    codeName = "Paternal Lastname",
                                    top = 13.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "APELLIDO PATERNO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 96.0,
                                    height = 5.0,
                                },
                                new BoxSchema
                                {
                                    codeName = "Maternal Lastname",
                                    top = 13.0,
                                    left = 97.5,
                                    showLabel = true,
                                    label = "APELLIDO MATERNO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 92.0,
                                    height = 5.0,
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
                                    width = 96.0,
                                    height = 5.0,
                                },
                                new BoxSchema
                                {
                                    codeName = "Other names",
                                    top = 21.5,
                                    left = 97.5,
                                    showLabel = true,
                                    label = "OTROS NOMBRES",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.7,
                                    width = 92.0,
                                    height = 5.0,
                                },
                                new TableSchema
                                {
                                    codeName = "Patient Gender",
                                    top = 32.3,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "SEXO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 14.6 },
                                        new Table_ColumnSchema { width = 8.9 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.3,
                                            cells = [
                                                new Table_CellSchema { text = "MASCULINO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.3,
                                            cells = [
                                                new Table_CellSchema { text = "FEMININO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "MATERNAL HEALTH",
                                    top = 42.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "SALUD MATERNA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 14.6 },
                                        new Table_ColumnSchema { width = 8.9 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.3,
                                            cells = [
                                                new Table_CellSchema { text = "GESTANTE", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.3,
                                            cells = [
                                                new Table_CellSchema { text = "PUERPERA", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new BoxSchema
                                {
                                    codeName = "CLINIC HISTORY NUMBER",
                                    top = 30.0,
                                    left = 111.0,
                                    showLabel = true,
                                    label = "N° DE HISTORIA CLÍNICA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    width = 37.3,
                                    height = 6.7,
                                },
                                new BoxSchema
                                {
                                    codeName = "ETHNICITY",
                                    top = 30.0,
                                    left = 149.0,
                                    showLabel = true,
                                    label = "ETNIA",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    width = 40.3,
                                    height = 6.7,
                                },
                                new TableSchema
                                {
                                    codeName = "DATE OF DEATH",
                                    top = 30.4,
                                    left = 25.0,
                                    showLabel = false,
                                    label = "FECHA DE FALLECIMIENTO",
                                    columns = [
                                        new Table_ColumnSchema { width = 24.2 },
                                        new Table_ColumnSchema { width = 16.7 },
                                        new Table_ColumnSchema { width = 14.7 },
                                        new Table_ColumnSchema { width = 30.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.8,
                                            cells = [
                                                new Table_CellSchema { text = "FECHA", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "DIA", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "MES", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "AÑO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 6.0,
                                            cells = [
                                                new Table_CellSchema { text = "FECHA PROBABLE DE<br>PARTO / FECHA DE<br>PARTO", extraStyles = "font-size: 1.55mm; padding: 0.2mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "BIRTHDATE",
                                    top = 40.0,
                                    left = 25.0,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 24.2 },
                                        new Table_ColumnSchema { width = 16.7 },
                                        new Table_ColumnSchema { width = 14.7 },
                                        new Table_ColumnSchema { width = 38.8 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.5,
                                            cells = [
                                                new Table_CellSchema { text = "FECHA DE NACIMIENTO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "DATE OF DEATH",
                                    top = 46.0,
                                    left = 25.0,
                                    showLabel = false,
                                    label = "FECHA DE FALLECIMIENTO",
                                    columns = [
                                        new Table_ColumnSchema { width = 24.2 },
                                        new Table_ColumnSchema { width = 16.7 },
                                        new Table_ColumnSchema { width = 14.7 },
                                        new Table_ColumnSchema { width = 38.8 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.5,
                                            cells = [
                                                new Table_CellSchema { text = "FECHA DE FALLECIMIENTO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "DNI/Affiliation",
                                    top = 40.0,
                                    left = 120.0,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 34.5 },
                                        new Table_ColumnSchema { width = 35.8 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.7,
                                            cells = [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACIÓN DEL RN 1", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.6,
                                            cells = [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACIÓN DEL RN 2", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 4.4,
                                            cells = [
                                                new Table_CellSchema { text = "DNI / CNV / AFILIACIÓN DEL RN 3", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Visit Data",
                            title = "DE LA ATENCIÓN",
                            showTitle = true,
                            titleHeight = 2.4,
                            bodyHeight = 37.5,
                            bodyWidth = 192.0,
                            top = 130.0,
                            left = 0.0,
                            fields = [
                                new BoxSchema
                                {
                                    codeName = "UPS",
                                    top = 0.5,
                                    left = 72.2,
                                    showLabel = true,
                                    label = "UPS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.8,
                                    width = 11.0,
                                    height = 9.0,
                                },
                                new BoxSchema
                                {
                                    codeName = "ATTENTION CODE",
                                    top = 0.5,
                                    left = 84.9,
                                    showLabel = true,
                                    label = "CÓDIGO <br>PRESTACIONAL",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.8,
                                    labelExtraStyles = "font-size: 1.8mm; line-height: 2.4mm;",
                                    width = 15.2,
                                    height = 9.0,
                                },
                                new BoxSchema
                                {
                                    codeName = "ADDITIONAL ATTENTION CODE",
                                    top = 0.5,
                                    left = 102.6,
                                    showLabel = true,
                                    label = "<p style='line-height: 1.5mm; font-size: 1.5mm;'>CÓDIGO PRESTACIONAL(ES)<br>ADICIONAL(ES)</p>",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.8,
                                    labelExtraStyles = "line-height: 2.0mm; font-size: 1.5mm; vertical-align: middle;",
                                    width = 26.5,
                                    height = 9.0,
                                },
                                new BoxSchema
                                {
                                    codeName = "N° FUA TO BE LINKED",
                                    top = 15.0,
                                    left = 72.2,
                                    showLabel = true,
                                    label = "N° FUA A VINCULAR",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.5,
                                    width = 56.7,
                                    height = 3.8,
                                },
                                new TableSchema
                                {
                                    codeName = "LINKED REPORT",
                                    top = 15.0,
                                    left = -0.2,
                                    showLabel = true,
                                    label = "REPORTE VINCULADO",
                                    labelPosition = LabelPosition.Left,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelWidth = 30.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 40.8 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.5,
                                            cells = [
                                                new Table_CellSchema { text = "CÓD. AUTORIZACIÓN", extraStyles = "font-size: 1.7mm;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "HOSPITALISATION",
                                    top = 0.5,
                                    left = 129.5,
                                    showLabel = false,
                                    label = "HOSPITALIZACIÓN",
                                    columns = [
                                        new Table_ColumnSchema { width = 20.0 },
                                        new Table_ColumnSchema { width = 10.7 },
                                        new Table_ColumnSchema { width = 11.0 },
                                        new Table_ColumnSchema { width = 18.9 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 3.0,
                                            cells = [
                                                new Table_CellSchema { text = "FECHA", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "DIA" },
                                                new Table_CellSchema { text = "MES" },
                                                new Table_CellSchema { text = "AÑO" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.8,
                                            cells = [
                                                new Table_CellSchema { text = "DE INGRESO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 5.7,
                                            cells = [
                                                new Table_CellSchema { text = "DE ALTA", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 6.2,
                                            cells = [
                                                new Table_CellSchema { text = "DE CORTE<br>ADMINISTRATIVO", extraStyles = "background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new FieldSchema
                                {
                                    codeName = "Attention concept",
                                    top = 20.7,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "CONCEPTO PRESTACIONAL",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.2,
                                    width = 190.0,
                                    height = 12.0,
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "Direction Attention",
                                            top = -0.2,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "ATENCIÓN DIRECTA",
                                            columns = [
                                                new Table_ColumnSchema { width = 14.5 },
                                                new Table_ColumnSchema { width = 7.2 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 11.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "ATENCIÓN<br>DIRECTA", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Extaordinary COB",
                                            top = -0.2,
                                            left = 21.6,
                                            showLabel = true,
                                            label = "COB EXTRAORDINARIA",
                                            labelPosition = LabelPosition.Top,
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.3,
                                            columns = [
                                                new Table_ColumnSchema { width = 22.6 },
                                                new Table_ColumnSchema { width = 20.9 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 3.8,
                                                    cells = [
                                                        new Table_CellSchema { text = "N° Autorización", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Amount",
                                            top = 6.0,
                                            left = 21.6,
                                            showLabel = false,
                                            label = "Monto S/.",
                                            columns = [
                                                new Table_ColumnSchema { width = 19.1 },
                                                new Table_ColumnSchema { width = 24.4 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 5.8,
                                                    cells = [
                                                        new Table_CellSchema { text = "Monto S/.", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Warranty card",
                                            top = -0.2,
                                            left = 65.1,
                                            showLabel = true,
                                            label = "CARTA DE GARANTIA",
                                            labelPosition = LabelPosition.Top,
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.3,
                                            columns = [
                                                new Table_ColumnSchema { width = 18.7 },
                                                new Table_ColumnSchema { width = 19.8 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 3.8,
                                                    cells = [
                                                        new Table_CellSchema { text = "N° Autorización", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Amount2",
                                            top = 6.0,
                                            left = 65.1,
                                            showLabel = false,
                                            label = "Monto S/.",
                                            columns = [
                                                new Table_ColumnSchema { width = 14.5 },
                                                new Table_ColumnSchema { width = 24.0 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 5.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "Monto S/.", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Transfer",
                                            top = -0.2,
                                            left = 103.6,
                                            showLabel = false,
                                            label = "TRASLADO",
                                            columns = [
                                                new Table_ColumnSchema { width = 15.3 },
                                                new Table_ColumnSchema { width = 5.3 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 11.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "TRASLADO", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Burial",
                                            top = -0.2,
                                            left = 124.2,
                                            showLabel = true,
                                            label = "SEPELIO",
                                            labelPosition = LabelPosition.Top,
                                            labelOrientation = LabelOrientation.Horizontal,
                                            labelHeight = 2.3,
                                            columns = [
                                                new Table_ColumnSchema { width = 17.5 },
                                                new Table_ColumnSchema { width = 8.5 },
                                                new Table_ColumnSchema { width = 12.7 },
                                                new Table_ColumnSchema { width = 8.5 },
                                                new Table_ColumnSchema { width = 9.0 },
                                                new Table_ColumnSchema { width = 9.2 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 9.3,
                                                    cells = [
                                                        new Table_CellSchema { text = "NATIMUERTO", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "OBITO", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                        new Table_CellSchema { text = "OTRO", extraStyles = "background-color: #F0F0F0;" },
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Reference Data",
                            title = "DEL DESTINO DEL ASEGURADO/USUARIO",
                            showTitle = true,
                            titleHeight = 2.3,
                            bodyHeight = 20.0,
                            bodyWidth = 192.0,
                            top = 171.0,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Normal Destiny",
                                    top = 0.3,
                                    left = 0.1,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 5.9 },
                                        new Table_ColumnSchema { width = 6.1 },
                                        new Table_ColumnSchema { width = 10.3 },
                                        new Table_ColumnSchema { width = 6.7 },
                                        new Table_ColumnSchema { width = 22.4 },
                                        new Table_ColumnSchema { width = 6.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.0,
                                            cells = [
                                                new Table_CellSchema { text = "ALTA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CITA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "HOSPITALIZACIÓN", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "REFFERED DESTINY",
                                    top = 0.3,
                                    left = 58.0,
                                    showLabel = true,
                                    label = "REFERIDO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.0,
                                    columns = [
                                        new Table_ColumnSchema { width = 12.0 },
                                        new Table_ColumnSchema { width = 8.5 },
                                        new Table_ColumnSchema { width = 17.0 },
                                        new Table_ColumnSchema { width = 8.1 },
                                        new Table_ColumnSchema { width = 13.8 },
                                        new Table_ColumnSchema { width = 7.9 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.7,
                                            cells = [
                                                new Table_CellSchema { text = "EMERGENCIA", extraStyles = "font-size: 1.5mm; padding: 0.2mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CONSULTA EXTERNA", extraStyles = "font-size: 1.5mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "APOYO AL<br>DIAGNÓSTICO", extraStyles = "font-size: 1.5mm; padding: 0.2mm;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "COUNTER REFERRED",
                                    top = 0.3,
                                    left = 129.6,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 5.9 },
                                        new Table_ColumnSchema { width = 6.1 },
                                        new Table_ColumnSchema { width = 10.3 },
                                        new Table_ColumnSchema { width = 6.7 },
                                        new Table_ColumnSchema { width = 22.4 },
                                        new Table_ColumnSchema { width = 6.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 7.0,
                                            cells = [
                                                new Table_CellSchema { text = "CONTRA<br>RREFERIDO", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "FALLECIDO", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "CORTE<br>ADMINIS.", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "REFFERS / COUNTERREFERS TO",
                                    top = 8.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "SE REFIERE / CONTRARREFIERE A:",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.0,
                                    columns = [
                                        new Table_ColumnSchema { width = 40.0 },
                                        new Table_ColumnSchema { width = 99.0 },
                                        new Table_ColumnSchema { width = 52.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.8,
                                            cells = [
                                                new Table_CellSchema { text = "CÓDIGO RENAES DE LA IPRESS", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "NOMBRE DE LA IPRESS A LA QUE SE REFIERE / CONTRARREFIERE", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "N° HOJA DE REFER / CONTRARR.", extraStyles = "font-size: 1.9mm; padding: 0.3mm;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.7,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Triages Data",
                            title = "ACTIVIDADES PREVENTIVAS Y OTROS",
                            showTitle = true,
                            titleHeight = 2.5,
                            bodyHeight = 40.0,
                            bodyWidth = 120.0,
                            top = 194.0,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Basic Triage",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "ACTIVIDADES PREVENTIVAS",
                                    columns = [
                                        new Table_ColumnSchema { width = 24.6 },
                                        new Table_ColumnSchema { width = 14.2 },
                                        new Table_ColumnSchema { width = 23.6 },
                                        new Table_ColumnSchema { width = 12.2 },
                                        new Table_ColumnSchema { width = 31.1 },
                                        new Table_ColumnSchema { width = 13.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.0,
                                            cells = [
                                                new Table_CellSchema { text = "PESO (kg)", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "TALLA (cm)", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "P.A. (mmHg)", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Young Adult Eval",
                                    top = 4.1,
                                    left = 102.1,
                                    showLabel = true,
                                    label = "<p style='line-height: 1.5mm; font-size: 1.6mm; padding: 0.1mm'>JOVEN Y <br> ADULTO</p>",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 11.4 },
                                        new Table_ColumnSchema { width = 5.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.0,
                                            cells = [
                                                new Table_CellSchema { text = "EVALUACIÓN <br> INTEGRAL", extraStyles = "font-size: 1.4mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Young Adult Eval",
                                    top = 15.0,
                                    left = 103.0,
                                    showLabel = true,
                                    label = "<p style='line-height: 1.5mm; font-size: 1.6mm; padding: 0.1mm'>ADULTO MAYOR</p>",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 10.0 },
                                        new Table_ColumnSchema { width = 5.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.0,
                                            cells = [
                                                new Table_CellSchema { text = "VACAM", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.0,
                                            cells = [
                                                new Table_CellSchema { text = "TAMIZAJE<br>DE SALUD<br>MENTAL", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Of the pregnant woman",
                                    top = 4.1,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "DE LA<br>GESTANTE",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    labelExtraStyles = "line-height: 2.2mm;",
                                    columns = [
                                        new Table_ColumnSchema { width = 11.0 },
                                        new Table_ColumnSchema { width = 7.7 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "CPN (N°)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "EDAD<br>GEST", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "ALTURA<br>UTERIA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "PARTO<br>VERTICAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "CONTROL<br>PUERP (N°)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Of the newborn",
                                    top = 4.1,
                                    left = 19.3,
                                    showLabel = true,
                                    label = "DEL RECIEN NACIDO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 19.0 },
                                        new Table_ColumnSchema { width = 12.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "EDAD GEST RN<br>(SEM)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Apgar",
                                    top = 15.0,
                                    left = 19.3,
                                    showLabel = false,
                                    label = "APGAR",
                                    columns = [
                                        new Table_ColumnSchema { width = 9.1 },
                                        new Table_ColumnSchema { width = 3.3 },
                                        new Table_ColumnSchema { width = 6.8 },
                                        new Table_ColumnSchema { width = 3.3 },
                                        new Table_ColumnSchema { width = 8.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 11.0,
                                            cells = [
                                                new Table_CellSchema { text = "APGAR", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "1°", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "5°", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Corte Tardío de Cordón",
                                    top = 27.0,
                                    left = 19.3,
                                    showLabel = false,
                                    label = "Corte Tardío de Cordón",
                                    columns = [
                                        new Table_ColumnSchema { width = 22.5 },
                                        new Table_ColumnSchema { width = 8.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.8,
                                            cells = [
                                                new Table_CellSchema { text = "Corte Tardío de Cordón<br>(2 a 3min)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "PREGNANT/IN/CHILD/ADOLESCENT/YOUNG AND ADULT/OLDER ADULT",
                                    top = 4.1,
                                    left = 50.8,
                                    showLabel = true,
                                    label = "<p style='line-height: 1.5mm; font-size: 1.6mm; padding: 0.1mm'>GESTANTE /RN/NIÑO/ADOLESCENTE/JOVEN Y<br>ADULTO/ADULTO MAYOR </p>",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 4.5,
                                    columns = [
                                        new Table_ColumnSchema { width = 13.2 },
                                        new Table_ColumnSchema { width = 11.7 },
                                        new Table_ColumnSchema { width = 9.3 },
                                        new Table_ColumnSchema { width = 16.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "CRED N°", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "PAB(cm)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Premature, LOW BIRTH WEIGHT",
                                    top = 15.0,
                                    left = 50.8,
                                    showLabel = false,
                                    label = "R.N. PREMATURO, BAJO PESO AL NACER",
                                    columns = [
                                        new Table_ColumnSchema { width = 18.7 },
                                        new Table_ColumnSchema { width = 6.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "R.N. PREMATURO", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "BAJO PESO AL NACER", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "CONGENITAL DISEASE / SEQUEL AT BIRTH, NUMBER OF RELATIVES AT GEST / PUERP. MAT. HOME",
                                    top = 26.2,
                                    left = 50.8,
                                    showLabel = false,
                                    label = "ENFER. CONGENITA / SECUELA AL NACER, N° FAMILIARES DE GEST / PUERP. CASA MAT.",
                                    columns = [
                                        new Table_ColumnSchema { width = 18.7 },
                                        new Table_ColumnSchema { width = 6.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "ENFER. CONGENITA /<br>SECUELA AL NACER", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "N° FAMILIARES DE<br>GEST / PUERP. CASA<br>MAT.", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Nutritional Counseling, TAP/EEDP or TEPSI",
                                    top = 15.0,
                                    left = 76.1,
                                    showLabel = false,
                                    label = "CONSEJERIA NUTRICIONAL, TAP/EEDP o TEPSI",
                                    columns = [
                                        new Table_ColumnSchema { width = 18.7 },
                                        new Table_ColumnSchema { width = 6.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "TAP/EEDP o<br>TEPSI", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "CONSEJERIA<br>NUTRICIONAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "NUTRITIONAL COUNSELING, BMI (Kg/M²)",
                                    top = 26.2,
                                    left = 76.1,
                                    showLabel = false,
                                    label = "CONSEJERIA NUTRICIONAL, IMC (Kg/M²)",
                                    columns = [
                                        new Table_ColumnSchema { width = 18.7 },
                                        new Table_ColumnSchema { width = 6.2 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "CONSEJERIA<br>INTEGRAL", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.4,
                                            cells = [
                                                new Table_CellSchema { text = "IMC (Kg/M²)", extraStyles = "font-size: 1.6mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Triages Data",
                            title = "VACUNA Nº DE DOSIS",
                            showTitle = true,
                            titleHeight = 2.5,
                            bodyHeight = 40.0,
                            bodyWidth = 72.0,
                            top = 194.0,
                            left = 120.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Immunisation data",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "IMMUNIZACIÓN DATA",
                                    columns = [
                                        new Table_ColumnSchema { width = 13.9 },
                                        new Table_ColumnSchema { width = 7.5 },
                                        new Table_ColumnSchema { width = 16.6 },
                                        new Table_ColumnSchema { width = 7.5 },
                                        new Table_ColumnSchema { width = 16.7 },
                                        new Table_ColumnSchema { width = 7.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "BCG", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "INFLUENZA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTIAMARILICA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "DPT", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "PAROTID", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTINEUMOC", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "APO", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "RUBEOLA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ANTITETANICA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "ASA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "ROTAVIRUS", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "COMPLETAS<br>PARA LA EDAD", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "SI | NO", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "SPR", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "DT ADULTO (N°<br>DOSIS)", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "VPH", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 6,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "SR", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "IPV", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "VARICELA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 7,
                                            height = 4.5,
                                            cells = [
                                                new Table_CellSchema { text = "HVB", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "PENTAVAL", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "", extraStyles = "font-size: 1.8mm; padding: 0.3mm;" },
                                                new Table_CellSchema { text = "OTRA VACUNA", extraStyles = "font-size: 1.8mm; padding: 0.3mm; background-color: #F0F0F0;" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Risk group number",
                                    top = 31.5,
                                    left = 0.1,
                                    showLabel = false,
                                    label = "GRUPO DE RIESGO HVB",
                                    columns = [
                                        new Table_ColumnSchema { width = 19.8 },
                                        new Table_ColumnSchema { width = 5.0 },
                                        new Table_ColumnSchema { width = 45.0 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 6.0,
                                            cells = [
                                                new Table_CellSchema { text = "GRUPO DE RIESGO<br>HVB", extraStyles = "font-size: 1.8mm; background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "GRUPO DE RIESGO HVB: 1. TRABAJADOR DE SALUD 2. TRABAJAD<br>SEXUALES 3. HSH 4. PRIVADO LIBERTAD 5. FF. AA. 6. POLICIA<br>NACIONAL 7. ESTUDIANTES DE SALUD 8. POLITRANFUNDIDOS 9.<br>DROGO DEPENDIENTES", extraStyles = "font-size: 1.2mm;" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Diagnostics data",
                            title = "DIAGNÓSTICOS",
                            showTitle = true,
                            titleHeight = 2.2,
                            bodyHeight = 24.0,
                            bodyWidth = 192.0,
                            top = 237.5,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Basic Triage",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "ACTIVIDADES PREVENTIVAS",
                                    columns = [
                                        new Table_ColumnSchema { width = 4.8 },
                                        new Table_ColumnSchema { width = 110.0 },
                                        new Table_ColumnSchema { width = 14.2 },
                                        new Table_ColumnSchema { width = 24.2 },
                                        new Table_ColumnSchema { width = 14.2 },
                                        new Table_ColumnSchema { width = 23.4 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 4.4,
                                            cells = [
                                                new Table_CellSchema { text = "Nº" },
                                                new Table_CellSchema { text = "DESCRIPCIÓN" },
                                                new Table_CellSchema { text = "DX INGRESO" },
                                                new Table_CellSchema { text = "CIE - 10" },
                                                new Table_CellSchema { text = "DX EGRESO" },
                                                new Table_CellSchema { text = "CIE - 10" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "1" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 3,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "2" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 4,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "3" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 5,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "4" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 6,
                                            height = 3.8,
                                            cells = [
                                                new Table_CellSchema { text = "5" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                        new SectionSchema
                        {
                            codeName = "Provider data",
                            showTitle = false,
                            bodyHeight = 21.0,
                            bodyWidth = 192.0,
                            top = 266.0,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "Provider data / DNI / COLEGIATURA",
                                    top = 0.0,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 40.6 },
                                        new Table_ColumnSchema { width = 105.2 },
                                        new Table_ColumnSchema { width = 40.5 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.3,
                                            cells = [
                                                new Table_CellSchema { text = "N° DE DNI", extraStyles = "font-size: 2.1mm; padding: 0.3mm; background-color: lightgrey; font-weight: 700;" },
                                                new Table_CellSchema { text = "NOMBRE DEL REPONSABLE DE LA ATENCIÓN", extraStyles = "font-size: 2.1mm; padding: 0.3mm; background-color: lightgrey; font-weight: 700;" },
                                                new Table_CellSchema { text = "N° DE COLEGIATURA", extraStyles = "font-size: 2.1mm; padding: 0.3mm; background-color:lightgrey; font-weight: 700;" },
                                            ],
                                        },
                                        new Table_RowSchema
                                        {
                                            index = 2,
                                            height = 5.0,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new TableSchema
                                {
                                    codeName = "Provider data / Specialisation / N° RNE/ Graduate",
                                    top = 8.5,
                                    left = 0.0,
                                    showLabel = false,
                                    label = "",
                                    columns = [
                                        new Table_ColumnSchema { width = 40.6 },
                                        new Table_ColumnSchema { width = 7.7 },
                                        new Table_ColumnSchema { width = 18.9 },
                                        new Table_ColumnSchema { width = 52.3 },
                                        new Table_ColumnSchema { width = 15.8 },
                                        new Table_ColumnSchema { width = 15.2 },
                                        new Table_ColumnSchema { width = 30.7 },
                                        new Table_ColumnSchema { width = 9.4 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.9,
                                            cells = [
                                                new Table_CellSchema { text = "RESPONSABLE DE LA ATENCIÓN", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "ESPECIALIDAD", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "N° RNE", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                                new Table_CellSchema { text = "EGRESADO", extraStyles = "background-color: #F0F0F0;" },
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
                new PageSchema
                {
                    pageNumber = 2,
                    height = 330.0,
                    width = 210.0,
                    sections = [
                        new SectionSchema
                        {
                            codeName = "Medications",
                            showTitle = false,
                            bodyHeight = 288.0,
                            bodyWidth = 192.0,
                            top = 0.0,
                            left = 0.0,
                            fields = [
                                new TableSchema
                                {
                                    codeName = "attention format",
                                    top = 0.0,
                                    left = 132.8,
                                    showLabel = true,
                                    label = "FORMATO DE ATENCION N°",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.6,
                                    columns = [
                                        new Table_ColumnSchema { width = 22.9 },
                                        new Table_ColumnSchema { width = 35.1 },
                                    ],
                                    rows = [
                                        new Table_RowSchema
                                        {
                                            index = 1,
                                            height = 2.5,
                                            cells = [
                                                new Table_CellSchema { text = "" },
                                            ],
                                        },
                                    ],
                                },
                                new FieldSchema
                                {
                                    codeName = "MEDICATION LIST LABEL",
                                    top = 6.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "MEDICAMENTOS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    width = 191.0,
                                    height = 139.6,
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "Medications list 1",
                                            top = -0.1,
                                            left = -0.1,
                                            showLabel = false,
                                            label = "MEDICAMENTOS 2",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 47.0 },
                                                new Table_ColumnSchema { width = 5.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.3,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO<br>SISMED", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "FF", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "CONCENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "PREN", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "ENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00143", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ACICLOVIR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00184", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO ACETILSALICÍLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00230", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO FÓLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00231", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO FÓLICO + FERROSO SULFATO (Eq. de Hierro elemental)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.4 mg + 60 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00257", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/5 mL - 20 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00258", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00081", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALUMINIO HIDRÓXIDO - MAGNESIO HIDRÓXIDO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00612", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00613", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00360", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00361", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00362", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00364", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00365", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA (COMO SAL SÓDICA) CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00083", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATORVASTATINA (COMO SAL CÁLCICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00917", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATROPINA SULFATO - 500 µg/mL (0.5 mg/mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00373", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00374", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg/5 mL - 15 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA (COMO FOSFATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00945", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00946", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "18179", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA SÓDICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,000,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "18181", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA SÓDICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2,400,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01486", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,200,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01484", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "600,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01303", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZOATO DE BENCILO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "LOC", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/100 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01527", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENTIAMINA (COMO DIPIROPATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00532", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CALCIO CARBONATO (Equivale 500 mg)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01327", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAPTOPRIL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01584", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARBIDOPA + LEVODOPA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25/250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01876", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CEFTRIAXONA SÓDICA (COMO SAL SÓDICA) CON DILUYENTE +", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ECT INY 1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01596", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CIPROFLOXACINO (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01964", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO FOSFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 36,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01965", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL (COMO SUCCINATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 37,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01967", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 38,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02194", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 39,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02195", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 40,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02208", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 41,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02162", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 42,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02163", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 43,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02667", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 44,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02668", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 45,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02669", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA (FOSFATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 46,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02718", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXCLORFENIRAMINA BROMHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 47,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02725", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg/5 mL - 120 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 48,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02726", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 49,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02787", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 50,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02788", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 51,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02812", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO SÓDICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 52,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02813", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO SÓDICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "75 mg/3 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 53,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02821", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL SÓDICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 54,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02822", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL SÓDICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 55,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03048", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIFENHIDRAMINA CLORHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 56,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03105", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DOXICICLINA (COMO HICLATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 57,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03145", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ENALAPRIL MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 58,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03317", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03318", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 60,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03322", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ESCOPOLAMINA N BUTILBROMURO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 61,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03323", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ESCOPOLAMINA N BUTILBROMURO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 62,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03356", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "FIERRO SULFATO (Eq. a 60 mg de Hierro)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 63,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03358", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "FIERRO SÓDICO POLIMALTOSADO (8 mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg eq Fe/mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "Medications list 2",
                                            top = -0.1,
                                            left = 96.0,
                                            showLabel = false,
                                            label = "MEDICAMENTOS 2",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 47.0 },
                                                new Table_ColumnSchema { width = 5.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 2.3,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO<br>SISMED", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "FF", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "CONCENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "PREN", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "ENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00143", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ACICLOVIR", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00184", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO ACETILSALICÍLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00230", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO FÓLICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00231", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ÁCIDO FÓLICO + FERROSO SULFATO (Eq. de Hierro elemental)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.4 mg + 60 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00257", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/5 mL - 20 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00258", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALBENDAZOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00081", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ALUMINIO HIDRÓXIDO - MAGNESIO HIDRÓXIDO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00612", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00613", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMIKACINA (COMO SULFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00360", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00361", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00362", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMOXICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00364", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00365", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AMPICILINA (COMO SAL SÓDICA) CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00083", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATORVASTATINA (COMO SAL CÁLCICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00917", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ATROPINA SULFATO - 500 µg/mL (0.5 mg/mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00373", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00374", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AZITROMICINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "200 mg/5 mL - 15 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA (COMO FOSFATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00945", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CRE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00946", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BETAMETASONA DIPROPIONATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "18179", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA SÓDICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,000,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "18181", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENCILPENICILINA SÓDICA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2,400,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01486", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1,200,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01484", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZATINA BENCILPENICILINA CON DILUYENTE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "600,000 UI", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01303", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENZOATO DE BENCILO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "LOC", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/100 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01527", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "BENTIAMINA (COMO DIPIROPATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "00532", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CALCIO CARBONATO (Equivale 500 mg)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01327", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAPTOPRIL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01584", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CARBIDOPA + LEVODOPA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25/250 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01876", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CEFTRIAXONA SÓDICA (COMO SAL SÓDICA) CON DILUYENTE +", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ECT INY 1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01596", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CIPROFLOXACINO (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01944", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO CLORHIDRATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01964", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLINDAMICINA (COMO FOSFATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 36,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01965", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL (COMO SUCCINATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "1 g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 37,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "01967", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORANFENICOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "UNG", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/g", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 38,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02194", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 39,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02195", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 40,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02208", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORFENAMINA MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 41,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02162", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 42,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02163", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CLORPROMAZINA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 43,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02667", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "0.5 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 44,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02668", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 45,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02669", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXAMETASONA (FOSFATO SÓDICO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "4 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 46,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02718", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXCLORFENIRAMINA BROMHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "2 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 47,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02725", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "JBE", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg/5 mL - 120 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 48,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02726", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DEXTROMETORFANO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "15 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 49,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02787", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 50,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02788", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIAZEPAM", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg/2 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 51,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02812", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO SÓDICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 52,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02813", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOFENACO SÓDICO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "75 mg/3 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 53,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02821", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL SÓDICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "CAP", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 54,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "02822", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DICLOXACILINA (COMO SAL SÓDICA)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 55,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03048", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DIFENHIDRAMINA CLORHIDRATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "50 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 56,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03105", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "DOXICICLINA (COMO HICLATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "100 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 57,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03145", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ENALAPRIL MALEATO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 58,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03317", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "500 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 59,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03318", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ERITROMICINA (COMO ESTEARATO O ETILSUCINATO)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SUS", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "250 mg/5 mL - 60 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 60,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03322", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ESCOPOLAMINA N BUTILBROMURO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "10 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 61,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03323", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "ESCOPOLAMINA N BUTILBROMURO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "INY", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "20 mg/mL - 1 mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 62,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03356", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "FIERRO SULFATO (Eq. a 60 mg de Hierro)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "TAB", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "300 mg", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 63,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "03358", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "FIERRO SÓDICO POLIMALTOSADO (8 mL)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "SOL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "25 mg eq Fe/mL", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                    ],
                                },
                                new FieldSchema
                                {
                                    codeName = "COMPLEMENTARY SUPPLIES Field",
                                    top = 148.0,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "INSUMOS COMPLEMENTARIOS",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    width = 191.0,
                                    height = 39.6,
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "COMPLEMENTARY SUPPLIES list 1",
                                            top = 0.0,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "INSUMOS COMPLEMENTARIOS 1",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "INB", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "COMPLEMENTARY SUPPLIES list 2",
                                            top = 0.0,
                                            left = 96.0,
                                            showLabel = false,
                                            label = "INSUMOS COMPLEMENTARIOS 2",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "IND", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "EJE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                    ],
                                },
                                new FieldSchema
                                {
                                    codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY Field",
                                    top = 190.1,
                                    left = 0.0,
                                    showLabel = true,
                                    label = "PROCEDIMIENTOS/DIAGNÓSTICO POR IMAGENES/ LABORATORIO",
                                    labelPosition = LabelPosition.Top,
                                    labelOrientation = LabelOrientation.Horizontal,
                                    labelHeight = 2.3,
                                    width = 191.0,
                                    height = 76.85,
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY list 1",
                                            top = 2.5,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "PROCEDIMIENTOS/DIAGNÓSTICO POR IMAGENES/ LABORATORIO 1",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "INB", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "D0120", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "Examen estológico (Examen bucal)", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                        new TableSchema
                                        {
                                            codeName = "PROCEDURES/DIAGNOSTIC IMAGING/LABORATORY list 2",
                                            top = 2.5,
                                            left = 96.0,
                                            showLabel = false,
                                            label = "PROCEDIMIENTOS/DIAGNÓSTICO POR IMAGENES/ LABORATORIO 2",
                                            columns = [
                                                new Table_ColumnSchema { width = 8.7 },
                                                new Table_ColumnSchema { width = 52.5 },
                                                new Table_ColumnSchema { width = 16.3 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                                new Table_ColumnSchema { width = 5.7 },
                                            ],
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "CÓDIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "INB", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "...", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 4,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 5,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 6,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 7,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 8,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 9,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 10,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 11,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 12,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 13,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 14,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 15,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 16,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 17,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 18,
                                                    height = 1.7,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 19,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 20,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 21,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 22,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 23,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 24,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 25,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 26,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 27,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 28,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 29,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 30,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 31,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 32,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 33,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 34,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 35,
                                                    height = 1.6,
                                                    cells = [
                                                        new Table_CellSchema { text = "36412", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "AEROCAMARA DE PLASTICO ADULTO", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                        new Table_CellSchema { text = "", extraStyles = "font-size: 1.4mm;" },
                                                    ],
                                                },
                                            ],
                                        },
                                    ],
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
                                    fields = [
                                        new TableSchema
                                        {
                                            codeName = "PERFORMANCE SUBCOMPONENT Table",
                                            top = 2.4,
                                            left = 0.0,
                                            showLabel = false,
                                            label = "",
                                            columns = [
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
                                            rows = [
                                                new Table_RowSchema
                                                {
                                                    index = 1,
                                                    height = 1.9,
                                                    cells = [
                                                        new Table_CellSchema { text = "CODIGO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "NOMBRE", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "CARACT", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "IND/PRES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "EJE/ENTR", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "DX", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "RES", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "N°TICKET", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                        new Table_CellSchema { text = "PO", extraStyles = "font-size: 1.4mm; background-color: lightgrey;" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 2,
                                                    height = 1.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                                new Table_RowSchema
                                                {
                                                    index = 3,
                                                    height = 1.5,
                                                    cells = [
                                                        new Table_CellSchema { text = "" },
                                                    ],
                                                },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
            ]
        };
    }
}

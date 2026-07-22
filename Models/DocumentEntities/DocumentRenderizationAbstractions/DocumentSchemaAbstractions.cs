using System.Globalization;
using System.Text.RegularExpressions;
using static SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions.TableSchema;

using static System.Net.Mime.MediaTypeNames;

namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

public record Table_ColumnSchema
{
    public double width { get; set; }
}

public record Table_CellSchema
{
    public required string text { get; set; }
    public string? extraStyles { get; set; }
}

public record Table_RowSchema
{
    public int index { get; set; }
    public double height { get; set; }
    public List<Table_CellSchema>? cells { get; set; }

    public string Render(int index, int colAmount, string prefix, Boolean printLayout)
    {
        string htmlContent = string.Empty;

        if (colAmount == 0) return htmlContent;

        // Row height
        string height = $"style=\"height: {this.height.ToString("F1")}mm;\"";

        // Get cell if any
        var cells = this.cells ?? null;
        List<string> rowContent = new List<string>();
        for (int i = 0; i < colAmount; i++)
        {
            string extraStyles = string.Empty;
            Table_CellSchema? cell = (cells != null && i < cells.Count) ? cells[i] : null;
            if (cell != null)
            {
                extraStyles = $$"""
                    <style>
                        #{{prefix}}-row-{{index.ToString()}}-cell-{{i}} {
                            {{cell.extraStyles ?? string.Empty}},
                            min-width: 0;
                        }
                    </style>
                 """;
            }
            // TODO: Text from mapping
            string auxCellContent = $$"""
                {{extraStyles}}
                 <td id="{{prefix}}-row-{{index}}-cell-{{i}}" class="field-border text-container {{(printLayout ? "format-related-print" : string.Empty)}}" > 
                    {{cell?.text ?? string.Empty}} 
                </td>
             """;
            rowContent.Add(auxCellContent);
        }

        htmlContent = $$"""
            <tr {{height}} class="field-border {{(printLayout ? "format-related-print" : string.Empty)}}">
                {{(rowContent.Count > 0 ? string.Concat(rowContent) : string.Empty)}}
            </tr>

         """;
        return htmlContent; 
    }
}

public record TableSchema : BaseFieldSchema
{
    public string? target { get; set; }
    public string? value { get; set; }
    public List<Table_ColumnSchema> columns { get; set; } = [];
    public List<Table_RowSchema> rows { get; set; } = [];
    public Func<string>? extraProcessing { get; set; }

    public override string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping)
    {
        double auxWidthValue = 0.0;

        // Define colgroups
        var auxColumns = columns
            .Select(item => $"<col style=\"width: {item.width.ToString("F1")}mm;\" />")
            .ToList();

        var colgroups = $"""
        <colgroup>
            {string.Join(string.Empty, auxColumns)}
        </colgroup>
        """;

        auxWidthValue = 0.0 + this.columns.Sum( (Table_ColumnSchema column) => column.width );
        logicAdditionalStyles += $"width: {auxWidthValue.ToString("F1")}mm";


        var auxRows = this.rows.OrderBy(r => r.index);

        var finalRows = string.Concat(
            auxRows.Select( (item, index) => item.Render( index, auxColumns.Count(), $"{prefix}-field-{fieldIndex}", printLayout ))
            );

        return colgroups + finalRows;
    }
}

public record BoxSchema : BaseFieldSchema
{
    public string? target { get; set; }
    public string? value { get; set; }
    public Func<string>? extraProcessing { get; set; }

    public override string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping)
    {
        var mappingValue = mapping?.ToString() ?? string.Empty; //TODO

        string fieldContent = $$"""
            <tr>
                <td class="text-container {{(printLayout ? "format-related-print" : string.Empty)}}">{{this.value ?? string.Empty}} {{mappingValue}}</td>
            </tr>
         """;
        logicAdditionalStyles += $$"""
            width: {{this.width:F1}}mm; 
            height: {{this.height:F1}}mm;";
         """;

        return fieldContent;
    }
}

public record FieldSchema : BaseFieldSchema
{
    public required List<BaseFieldSchema> fields { get; set; } = [];
    public override string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping)
    {
        string fieldContent = string.Concat(
            this.fields.Select( (field,index) => field.RenderContent(
                fieldIndex: index, 
                prefix: $"{prefix}-field-{fieldIndex}", 
                printLayout: printLayout,
                mapping: null
            ) ) 
        );
        logicAdditionalStyles += $$"""
            width:  {{( this.width  is not null ? this.width.Value.ToString("F1")  : 200.ToString("F1") )}}mm; 
            height: {{( this.height is not null ? this.height.Value.ToString("F1") : 200.ToString("F1") )}}mm;  
         """;

        string finalFieldContent = $$"""
            <tr>
               <td style="padding: 0px;" class="field-content {{( printLayout ? "format-related-print" : string.Empty )}}"> 
                   {{fieldContent}}
               </td>
           </tr>

         """;

        return finalFieldContent;
    }

}


public enum FieldTypeEnum
{
    Field,
    Table,
    Box
}

public enum LabelPosition
{
    Top,
    Bottom,
    Left,
    Right
}

public enum LabelOrientation
{
    Vertical,
    Horizontal
}

public record Paddings
{
    public Double padding_top { get; set; }
    public Double padding_left { get; set; }

}

public abstract record BaseFieldSchema
{
    // Codename
    public required string codeName { get; set; }
    // Position and size
    public required double top { get; set; }
    public required double left { get; set; }
    public double? width { get; set; }
    public double? height { get; set; }
    // Title
    public required bool showLabel { get; set; }
    public required string? label { get; set; }
    public LabelPosition? labelPosition { get; set; }
    public LabelOrientation? labelOrientation { get; set; }
    public double? labelHeight { get; set; }
    public double? labelWidth { get; set; }
    public string? labelExtraStyles { get; set; }
    // Body
    public double? bodyHeight { get; set; }
    public double? bodyWidth { get; set; }
    
    // Extrastyles
    public string? extraStyles { get; set; }

    private static (string captionStyle, string flexDir) eraseBorderOfFieldCaption(LabelPosition? captionSide)
    {
        if (captionSide == null)
        {
            captionSide = LabelPosition.Top;
        }

        string baseStyle = $"""
            display: flex; 
            justify-content: center; 
            align-items: center;
         """;

        string captionStyle = "border-bottom: none;";
        string flexDir = "column";

        switch (captionSide)
        {
            case LabelPosition.Top:
                captionStyle = "border-bottom: none; " + baseStyle;
                break;
            case LabelPosition.Left:
                flexDir = "row";
                captionStyle = "border-right: none; " + baseStyle;
                break;
            case LabelPosition.Right:
                flexDir = "row";
                captionStyle = "border-left:none; " + baseStyle;
                break;
            case LabelPosition.Bottom:
                captionStyle = "border-top: none; " + baseStyle;
                break;
        }

        return (captionStyle, flexDir);
    }

    public abstract string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping);
    private string getLabelPosition(LabelPosition? labelPosition)
    {
        string horizontalPos = string.Empty;
        string verticalPos = string.Empty;

        if (labelPosition is LabelPosition.Left or LabelPosition.Right)
        {
            string width = this.labelWidth is not null
                ? $"{this.labelWidth.Value.ToString("F1")}mm;"
                : "100%;";

            horizontalPos = $"width: {width}";
        }

        if (labelPosition is LabelPosition.Top or LabelPosition.Bottom)
        {
            string height = this.labelHeight is not null
                ? $"{this.labelHeight.Value.ToString("F1")}mm;"
                : "100%;";

            verticalPos = $"height: {width}";
        }

        return horizontalPos + verticalPos;
    }

    public static string RemoveBackgroundColor(string? inlineStyle)
    {
        if (string.IsNullOrWhiteSpace(inlineStyle))
        {
            return string.Empty;
        }

        return string.Join("; ",
            inlineStyle
                .Split(';')
                .Select(rule => rule.Trim())
                .Where(rule =>
                    rule.Length > 0 &&
                    !Regex.IsMatch(rule, @"^background-color\s*:", RegexOptions.IgnoreCase)
                )
        );
    }

    public (string labelContent, string flexDir) RenderLabel(string prefix,Boolean printLayout, int fieldIndex)
    {
        string label = string.Empty;
        string flexDir = string.Empty;

        if (this.showLabel)
        {
            var (captionStyle, flexDirComputed) = eraseBorderOfFieldCaption(this.labelPosition);
            flexDir = flexDirComputed;
            string labelPosition = getLabelPosition(this.labelPosition);
            label = $$"""
                <style>
                 #{{prefix}}-field-{{fieldIndex}}-caption {
                    {{captionStyle}}             
                    {{labelPosition}}           

                    font-weight: bold;
                    background-color: lightgray;
                    {{(this.labelHeight is not null ? ($"height: {this.labelHeight:F1}mm;") : string.Empty)}}
                    {{(this.labelHeight is not null ? ($"line-height: {this.labelHeight:F1}mm;") : string.Empty)}}
                    {{(this.labelExtraStyles is not null ? (printLayout is false ? RemoveBackgroundColor(this.labelExtraStyles) : this.labelExtraStyles) : string.Empty)}}
                 }
             </style>
             <div id="{{prefix}}-field-{{fieldIndex}}-caption" class="field-border text-container {{(printLayout ? "format-related-print" : string.Empty)}}">
                 {{this.label}}
             </div>
             """;

        }
        return (label, flexDir);
    }

    public string RenderContent(int fieldIndex, string prefix, bool printLayout, object? mapping)
    {
        string logicAdditionalStyles = String.Empty;

        string fieldContent = Render(fieldIndex, prefix, printLayout, ref logicAdditionalStyles, mapping);
        var (labelContent, flexDir) = RenderLabel(prefix, printLayout, fieldIndex);


        var containerStyleSuffix = flexDir is not null
            ? $"flex-direction: {flexDir}; position: absolute;"
            : string.Empty;

        string labelBefore = this.labelPosition is LabelPosition.Top or LabelPosition.Left ? labelContent : string.Empty;
        string labelAfter = this.labelPosition is LabelPosition.Bottom or LabelPosition.Right ? labelContent : string.Empty;

        return $$"""
            <style>
                #{{prefix}}-field-{{fieldIndex}} {
                    top:    {{this.top:F1}}mm;
                    left:   {{this.left:F1}}mm;
                    {{this.extraStyles ?? string.Empty}}
                }
                #{{prefix}}-field-{{fieldIndex}}-content {
                    {{logicAdditionalStyles}}
                }
            </style>
            <div id="{{prefix}}-field-{{fieldIndex}}" style="position: absolute; width: min-content; border: none; padding: 0; background: none; display: flex; {{containerStyleSuffix}};">
                {{labelBefore}}
                <table id="{{prefix}}-field-{{fieldIndex}}-content" class="table-field">
                    {{fieldContent}}
                </table>
                {{labelAfter}}
            </div>
            """;
    }
}

public record SectionSchema
{
    public string codeName { get; set; } = string.Empty;
    public string? title { get; set; }
    public bool showTitle { get; set; }
    public double? titleHeight { get; set; }
    public double bodyHeight { get; set; }
    public double bodyWidth { get; set; }
    public double top { get; set; }
    public double left { get; set; }
    public string? extraStyles { get; set; }
    public List<BaseFieldSchema> fields { get; set; } = [];

    public string Render(int sectionIndex, string prefix, Paddings paddings, Boolean printLayout)
    {
        string sectionContent = string.Empty;

        //Tile
        string title = string.Empty;
        if(this.showTitle == true)
        {
            title = $$"""
                <tr>
                    <th class="section-header text-container {{(printLayout ? "format-related-print" : string.Empty)}}" style="height: {{this.titleHeight?.ToString("F1")}}mm;" > {{this.title ?? string.Empty}} </th>
                </tr>
             """;
        }

        //Get Section Content
        if(this.fields is not null)
        {
            string aux = string.Empty;
            sectionContent = string.Join("", this.fields.Select((BaseFieldSchema item, int index) =>
                item.RenderContent(
                    fieldIndex: index,
                    prefix: $"{prefix}-section-{sectionIndex.ToString()}",
                    printLayout: printLayout,
                    mapping: null )
            ));
        }

        string htmlContent = $$"""
         <style>
             #{{prefix}}-section-{{sectionIndex.ToString()}} {
                 {{( "top: "  + (paddings.padding_top + this.top ).ToString("F1")   + "mm;" )}}
                 {{( "left: " + (paddings.padding_left + this.left ).ToString("F1") + "mm;" )}}
                 width: {{ this.bodyWidth.ToString("F1")+"mm;" }}
                 {{this.extraStyles}}
             }
         </style>
         <table id="{{prefix}}-section-{{sectionIndex.ToString()}}" class="table-section {{( printLayout ? "format-related-print" : string.Empty )}}" >                  
             {{title}}    
             <tr style="height: {{this.bodyHeight.ToString("F1")}}mm;">                    
                 <td class="section-content">
                     {{sectionContent}}
                 </td>
             </tr>                           
         </table>
         """;

        return htmlContent;
    }
}

public record PageSchema
{
    public int pageNumber { get; set; }
    public double height { get; set; }
    public double width { get; set; }
    public string? extraStyles { get; set; }
    public List<SectionSchema>? sections { get; set; }

    public string Render(int index, Boolean printLayout, ref string pageSizes)
    {
        string pageContent = string.Empty;

        //Check for sections
        if (this.sections is not null)
        {
            // TODO: Add page padding fields to PageSchema and use their schema-defined values here.
            Paddings auxPaddings = new Paddings
            {
                padding_top = 10.0,
                padding_left = 10.0
            };

            pageContent = string.Join("", this.sections.Select((SectionSchema item, int localIndex) =>
                item.Render(
                    sectionIndex: localIndex,
                    prefix: $"document-page-{index.ToString()}",
                    paddings: auxPaddings,
                    printLayout: printLayout )
            ));
        }

        //Process Page Size
        string auxPageSize = $$""" 
            @page document-page-size-{{index.ToString()}} {
                margin: 0;
                size: {{this.width.ToString("F1")}}mm {{this.height.ToString("F1")}}mm;
            }

            #document-page-{{index.ToString()}} {
                page: document-page-size-{{index.ToString()}};
                width: {{this.width.ToString("F1")}}mm;
                height: {{this.height.ToString("F1")}}mm;
                page-break-after: always;
            }        
         """;

        pageSizes += auxPageSize;

        string htmlContent = $$""" 
            <div id="document-page-{{index.ToString()}}" class="document-page {{( printLayout ? "format-related-print" : string.Empty )}}" {{( this.extraStyles is not null ? $" style=\"{this.extraStyles}\"" : string.Empty )}}>
                {{ pageContent }}
            </div>
         """;

        return htmlContent;
    } 
}

public record DocumentSchema
{
    public List<PageSchema>? pages { get; set; }
    public string name { get; set; } = string.Empty;

    private static string LoadDocumentPrevisualizationCss()
    {
        var cssPath = Path.Combine(
            AppContext.BaseDirectory,
            "Utils",
            "RenderUtils",
            "DocumentPrevisualization.css");

        return File.Exists(cssPath) ? File.ReadAllText(cssPath) : string.Empty;
    }

    // Pending to add mapping
    public string Render(Boolean printLayout)
    {
        string formatContent = string.Empty;

        // Get CSS style from public folder
        string cssStyles = LoadDocumentPrevisualizationCss();

        // pageSizes variable to hold pages size and other properties
        string pageSizes = string.Empty;

        //Validate pages
        if(this.pages is not null)
        {
            formatContent = string.Join("", this.pages.Select( (PageSchema item, int index) => 
                item.Render(
                    index:          index, 
                    printLayout:    printLayout, 
                    pageSizes:      ref pageSizes )
            ) );
        }

        // Structure
        string finalContent = $$"""
            <!DOCTYPE html>
            <html lang="es">
                <head>
                    <meta charset="UTF-8">
                    <meta name="viewport" content="width=device-width, initial-scale=1.0">
                    <title>Render de Documento</title>
                    <style>
                        {{cssStyles}}
                        {{pageSizes}}
                    </style>
                </head>
                <body>                   
                    {{ formatContent }}                                        
                </body>
            </html>
        """;

        return finalContent;
    }

    
}

public interface IDocumentSchemaContract
{
    DocumentSchema Create();
}


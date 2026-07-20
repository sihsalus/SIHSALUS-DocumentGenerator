using System.Globalization;
using System.Text.RegularExpressions;

namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

/// <summary>
/// Holds additional styles that can be populated by Render() implementations.
/// Uses a class (reference type) so Render() can mutate Value directly.
/// </summary>
public class LogicAdditionalStyles
{
    public string Value { get; set; } = string.Empty;
}

/// <summary>
/// Result returned by RenderLabel() containing the label HTML and optional flex direction.
/// </summary>
public class LabelRenderResult
{
    public string LabelContent { get; set; } = string.Empty;
    public string? FlexDir { get; set; }
}

public record DocumentFieldOptions
{
    public required double Top { get; init; }
    public required double Left { get; init; }
    public required double Width { get; init; }
    public required double Height { get; init; }
    public required string Label { get; init; }
    public required string ValueType { get; init; }
    public bool ShowLabel { get; init; } = true;
    public string? ExtraStyles { get; init; }
    public double? LabelHeight { get; init; }
    public double? LabelWidth { get; init; }
    public string? LabelPosition { get; init; }
    public string? LabelExtraStyles { get; init; }
}

public record DocumentFieldBoxOptions : DocumentFieldOptions
{
    public string? Text { get; init; }
}



/// <summary>
/// Represents a single field in a document layout, mapped from FUAFieldInterface.
/// Not a DB entity — used during document rendering/processing.
/// </summary>
public abstract class DocumentField
{
    // Position and size
    public double Top { get; set; }
    public double Left { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    // Optional extra CSS/style string for the field container
    public string? ExtraStyles { get; set; }

    // Label configuration
    public bool ShowLabel { get; set; }
    public double? LabelHeight { get; set; }
    public double? LabelWidth { get; set; }
    public string Label { get; set; }
    public string? LabelPosition { get; set; }
    public string? LabelExtraStyles { get; set; }

    // Determines how the field value is interpreted/rendered (e.g. "text", "date", "checkbox")
    public string ValueType { get; set; }

    protected DocumentField(DocumentFieldOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        Top = options.Top;
        Left = options.Left;
        Width = options.Width;
        Height = options.Height;
        Label = options.Label;
        ValueType = options.ValueType;
        ShowLabel = options.ShowLabel;
        ExtraStyles = options.ExtraStyles;
        LabelHeight = options.LabelHeight;
        LabelWidth = options.LabelWidth;
        LabelPosition = options.LabelPosition;
        LabelExtraStyles = options.LabelExtraStyles;
    }

    /// <summary>
    /// Renders the inner field content (table rows, inputs, etc.).
    /// Subclasses can populate logicAdditionalStyles.Value with extra CSS.
    /// </summary>
    public abstract string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping);

    private static (string captionStyle, string flexDir) eraseBorderOfFieldCaption(string? captionSide) {
        if (captionSide == null) { 
            captionSide = "Top";
        }

        string baseStyle = $"""
            display: flex; 
            justify-content: center; 
            align-items: center;
         """;
        
        string captionStyle = "border-bottom: none";
        string flexDir = "column";

        switch (captionSide)
        {
            case "Top":
                captionStyle = "border-bottom: none; " + baseStyle;
                break;
            case "Left":
                flexDir = "row";
                captionStyle = "border-right: none; " + baseStyle;
                break;
            case "Right":
                flexDir = "row";
                captionStyle = "border-left:none; " + baseStyle;
                break;
            case "Bottom":
                captionStyle = "border-top: none; " + baseStyle;
                break;
        };
        return (captionStyle, flexDir);
    }

    private static string getLabelPosition(string? labelPosition)
    {
        string horizontalPos = string.Empty;
        string verticalPos = string.Empty;

        if (labelPosition is "Left" or "Right")
        {
            string width = labelPosition is not null
                ? $"{labelPosition:F1}mm;"
                : "100%;";

            horizontalPos = $"width: {width}";
        }

        if (labelPosition is "Top" or "Bottom")
        {
            string width = labelPosition is not null
                ? $"{labelPosition:F1}mm;"
                : "100%;";

            verticalPos = $"width: {width}";
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

    private (string labelContent, string flexDir) RenderLabel(string prefix, bool printLayout, int fieldIndex)
    {
        string label = string.Empty;
        string flexDir = string.Empty;

        if (this.ShowLabel)
        {
            var (captionStyle, flexDirComputed) = eraseBorderOfFieldCaption(this.LabelPosition);
            flexDir = flexDirComputed;
            string labelPosition = getLabelPosition(this.LabelPosition);
            label = $$"""
                <style>
                 #{{prefix}}-field-{{fieldIndex}}-caption {
                    {{captionStyle}}             
                    {{labelPosition}}           

                    font-weight: bold;
                    background-color: lightgray;
                    {{( this.LabelHeight is not null ? ($"height: {this.LabelHeight:F1}mm;") : string.Empty )}}
                    {{( this.LabelHeight is not null ? ($"line-height: {this.LabelHeight:F1}mm;") : string.Empty )}}
                    {{( this.LabelExtraStyles is not null ? (printLayout is false ? RemoveBackgroundColor(this.LabelExtraStyles) : this.LabelExtraStyles) : string.Empty)}}
                 }
             </style>
             <div id="{{prefix}}-field-{{fieldIndex}}-caption" class="field-border text-container {{(printLayout ? "format-related-print" : string.Empty)}}">
                 {{this.Label}}
             </div>
             """;
            
        }
        return (label, flexDir);
    }

    /// <summary>
    /// Builds the full field HTML: scoped styles + positioned container + label + content.
    /// </summary>
    public string RenderContent(int fieldIndex, string prefix, bool printLayout, object? mapping)
    {
        string logicAdditionalStyles = String.Empty;

        string fieldContent = Render(fieldIndex, prefix, printLayout, ref logicAdditionalStyles, mapping);
        var (labelContent, flexDir) = RenderLabel(prefix, printLayout, fieldIndex);
        

        var containerStyleSuffix = flexDir is not null
            ? $"flex-direction: {flexDir}; position: absolute;"
            : string.Empty;

        string labelBefore = LabelPosition is "Top" or "Left" ? labelContent : string.Empty;
        string labelAfter = LabelPosition is "Bottom" or "Right" ? labelContent : string.Empty;

        return $$"""
            <style>
                #{{prefix}}-field-{{fieldIndex}} {
                    top:    {{this.Top:F1}}mm;
                    left:   {{this.Left:F1}}mm;
                    {{this.ExtraStyles ?? string.Empty}}
                }
                #{{prefix}}-field-{{fieldIndex}}-content {
                    {{logicAdditionalStyles}}
                }
            </style>
            <div id="{{prefix}}-field-{{fieldIndex}}" style="position: absolute; width: min-content; border: none; padding: 0; background: none; display: flex; {{containerStyleSuffix}}">
                {{labelBefore}}
                <table id="{{prefix}}-field-{{fieldIndex}}-content" class="table-field">
                    {{fieldContent}}
                </table>
                {{labelAfter}}
            </div>
            """;
    }

}

public class DocumentField_Box : DocumentField
{
    private string? Text { get; set; }

    public DocumentField_Box(DocumentFieldBoxOptions options)
        : base(options as DocumentFieldOptions)
    {
        Text = options.Text;
    }

    public override string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping)
    {
        var mappingValue = mapping?.ToString() ?? string.Empty; //TODO

        string fieldContent = $$"""
            <tr>
                <td class="text-container {{(printLayout ? "format-related-print" : string.Empty)}}">{{this.Text ?? string.Empty}} {{mappingValue}}</td>
            </tr>
         """;
        logicAdditionalStyles += $$"""
            width: {{this.Width:F1}}mm; 
            height: {{this.Height:F1}}mm;";
         """;

        return fieldContent;
    }

}

public record DocumentField_Table_Column
{
    public double width { get; set; }
}

public record DocumentField_Table_Row_Cells
{
    public string text { get; set; }
    public string? extraStyles { get; set; }
}

public record DocumentField_Table_Row
{
    public int index { get; set; }
    public int height { get; set; }
    public Boolean isHeader { get; set; }
    public List<DocumentField_Table_Row_Cells> cells { get; set; }
}

public record DocumentField_TableOptions : DocumentFieldOptions
{
    public List<DocumentField_Table_Column> columns { get; set; }
    public List<DocumentField_Table_Row> rows { get; set; }
}

public class DocumentField_Table : DocumentField
{
    public List<DocumentField_Table_Column> Columns { get; set; }
    public List<DocumentField_Table_Row> Rows { get; set; }

    public DocumentField_Table(DocumentField_TableOptions options)
        : base(options as DocumentFieldOptions)
    {
        Columns = options.columns;
        Rows = options.rows;
    }

    private string TableRenderer_Row(DocumentField_Table_Row row, int index, int colAmount, string prefix, Boolean printLayout, object? mapping)
    {
        string htmlContent = string.Empty;
        if (colAmount is 0) return string.Empty;

        // Row Height 
        string height = $"style=\"height: {row.height:F1}mm;\"";

        // Get cell if the are
        var cells = row.cells ?? null;
        var rowContent = new List<string>();
        for (int i = 0; i < colAmount; i++)
        {
            string extraStyles = string.Empty;
            if(cells != null)
            {
                extraStyles = $$"""
                    <style>
                     #{{prefix}}-row-{{index.ToString()}}-cell-{{i.ToString()}} {
                         {cells?.[i]?.extraStyles ?? string.Empty},
                         min-width: 0;
                     }
                    </style>

                 """;
            }
            //Text form mapping
            /*
            string textFromMapping = string.Empty;
            if(mapping is not null)
            {
                textFromMapping = mapping.find
            }
            
            string auxCellContent = $"""
                {extraStyles}
                <td id="{prefix}-row-{index}-cell-{i}" class="field-border text-container {(printLayout ? "format-related-print" : string.Empty)}" > 
                    {cells?[i]?.text ?? string.Empty} {textFromMapping}
                </td>
             """;
            */
        }
        
        return string.Empty;
    }

    public override string Render(int fieldIndex, string prefix, bool printLayout, ref string logicAdditionalStyles, object? mapping)
    {
        double auxWidthValue = 0.0;

        // Define colgroups
        var auxColumns = Columns
            .Select(item => $"<col style=\"width: {item.width.ToString("F1", CultureInfo.InvariantCulture)}mm;\" />");

        var colgroups = $"""
        <colgroup>
            {string.Join(string.Empty, auxColumns)}
        </colgroup>
        """;
        /*
        var auxRows = this.Rows
            .OrderBy(r => r.index)
            .Select(row => row.ToString())
        */

        return string.Empty;
    }
}






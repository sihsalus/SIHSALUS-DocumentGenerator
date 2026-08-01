namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

/// <summary>
/// Contract for Roslyn-loaded mapping definitions.
/// Every mapping class should implement Create() and return a typed DocumentMapping.
/// </summary>
public interface IDocumentMappingContract
{
    DocumentMapping Create();
}



public record BoxFieldMapping : BaseMapping { }

public record BoxMapping : FieldBaseMapping
{
    public required List<BoxFieldMapping> mappings { get; set; } = [];
}

public record TableFieldMapping : BaseMapping
{
    public required int column { get; set; }
    public required int row { get; set; }
}

public abstract record BaseMapping 
{
    public string? target { get; set; }
    public string? value { get; set; }
    // To only be used by processFieldMapping
    public string? valueToPut { get; set; }
    public Func<string, string>? extraProcessing { get; set; }
}

public record FieldMapping : FieldBaseMapping
{
    public required List<FieldBaseMapping> fields { get; set; } = [];
}

public record TableMapping : FieldBaseMapping
{
    public required List<TableFieldMapping> mappings { get; set; } = [];
}

public abstract record FieldBaseMapping
{
    public required string codeName { get; set; }
}

public record SectionMapping
{
    public string codeName { get; set; } = string.Empty;
    public List<FieldBaseMapping> fields { get; set; } = [];
}

public record PageMapping
{
    public int pageNumber { get; set; }
    public List<SectionMapping> sections { get; set; } = [];
}

public record DocumentMapping
{
    public List<PageMapping> pages { get; set; } = [];
    public string name { get; set; } = string.Empty;
}

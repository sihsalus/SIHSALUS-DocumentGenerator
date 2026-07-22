namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

/// <summary>
/// Contract for Roslyn-loaded mapping definitions.
/// Every mapping class should implement Create() and return a typed DocumentRecordMapping.
/// </summary>
public interface IDocumentMappingContract
{
    DocumentMapping Create();
}



public abstract record BaseFieldMapping
{
    public required string codeName { get; set; }
    
}

public record SectionMapping
{
    public string codeName { get; set; } = string.Empty;
    public List<BaseFieldSchema> fields { get; set; } = [];
}

public record PageMapping
{
    public int pageNumber { get; set; }
    public List<SectionMapping>? sections { get; set; }
}

public record DocumentMapping
{
    public List<PageMapping>? pages { get; set; } = [];
    public string name { get; set; } = string.Empty;
}

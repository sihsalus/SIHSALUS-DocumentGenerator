namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;

/// <summary>
/// Maps a schema implementation compiled into the application to the source
/// file name accepted by the demo document endpoint.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class SchemaFileAttribute : Attribute
{
    public SchemaFileAttribute(string fileName)
    {
        FileName = fileName;
    }

    public string FileName { get; }
}

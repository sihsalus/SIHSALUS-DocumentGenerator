using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SIHSALUS_DocumentGenerator.Models.BaseEntities;
using SIHSALUS_DocumentGenerator.Models.DocumentEntities.DocumentRenderizationAbstractions;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Loader;
using System.Text.Json;

namespace SIHSALUS_DocumentGenerator.Models.DocumentEntities;

/// <summary>
/// Base class for entities that store a versioned JSON/JSONC form schema declaration.
/// </summary>
public class DocumentFromSchema : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = null!;

    // Large .CS text content — the form layout declaration
    [Required]
    public string Content { get; set; } = null!;

    [Required]
    public int Version { get; set; } = 1;

    [Required]
    [MaxLength(50)]
    public string VersionName { get; set; } = null!;

    public DocumentFromSchema()
    {
    }

    public DocumentFromSchema(JsonElement payload)
    {
        Name = GetRequiredString(payload, "name");
        Content = GetRequiredString(payload, "content");
        VersionName = GetRequiredString(payload, "versionName");
        CreatedBy = GetRequiredString(payload, "createdBy");
        Version = GetOptionalInt(payload, "version") ?? 1;
    }

    private static string GetRequiredString(JsonElement payload, string propertyName)
    {
        if (!TryGetPropertyCaseInsensitive(payload, propertyName, out var propertyValue) ||
            propertyValue.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            throw new ArgumentException($"Missing required property '{propertyName}'.", nameof(payload));
        }

        var value = propertyValue.GetString();
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"Property '{propertyName}' cannot be empty.", nameof(payload));
        }

        return value;
    }

    private static int? GetOptionalInt(JsonElement payload, string propertyName)
    {
        if (!TryGetPropertyCaseInsensitive(payload, propertyName, out var propertyValue) ||
            propertyValue.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
        {
            return null;
        }

        return propertyValue.ValueKind == JsonValueKind.Number
            ? propertyValue.GetInt32()
            : int.Parse(propertyValue.GetString() ?? "1");
    }

    private static bool TryGetPropertyCaseInsensitive(JsonElement payload, string propertyName, out JsonElement value)
    {
        foreach (var property in payload.EnumerateObject())
        {
            if (string.Equals(property.Name, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                value = property.Value;
                return true;
            }
        }

        value = default;
        return false;
    }

    public string RenderDocument()
    {
        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(Content, path: $"{Name}.cs");
        IEnumerable<MetadataReference> references = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(assembly => !assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
            .Select(assembly => MetadataReference.CreateFromFile(assembly.Location));

        CSharpCompilation compilation = CSharpCompilation.Create(
            assemblyName: $"DynamicSchema_{Guid.NewGuid():N}",
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        using MemoryStream assemblyStream = new();
        var emitResult = compilation.Emit(assemblyStream);

        if (!emitResult.Success)
        {
            IEnumerable<string> diagnostics = emitResult.Diagnostics
                .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                .Select(diagnostic => diagnostic.GetMessage());

            throw new InvalidOperationException($"Schema compilation failed. {string.Join(" | ", diagnostics)}");
        }

        assemblyStream.Position = 0;
        var schemaAssembly = AssemblyLoadContext.Default.LoadFromStream(assemblyStream);

        Type? schemaType = schemaAssembly.GetTypes()
            .FirstOrDefault(type => !type.IsAbstract && typeof(IDocumentSchemaContract).IsAssignableFrom(type));

        if (schemaType is null)
        {
            throw new InvalidOperationException("No implementation of IDocumentSchemaContract was found.");
        }

        if (Activator.CreateInstance(schemaType) is not IDocumentSchemaContract schemaImplementation)
        {
            throw new InvalidOperationException("The schema implementation could not be created.");
        }

        DocumentSchema documentSchema = schemaImplementation.Create();

        return documentSchema.Render(printLayout: false);
    }
}


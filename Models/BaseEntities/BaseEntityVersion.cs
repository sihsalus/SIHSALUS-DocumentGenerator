using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIHSALUS_DocumentGenerator.Models.BaseEntities;

public class BaseEntityVersion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // UUID of the source entity this version snapshot belongs to
    [Required]
    public Guid UuidEntity { get; set; }

    [Required]
    public int VersionCounter { get; set; }

    // Entity type name (e.g. "Document", "Patient")
    [Required]
    [MaxLength(100)]
    public string Type { get; set; } = null!;

    // Hash of the content for integrity/change detection
    [Required]
    public string Hash { get; set; } = null!;

    // Action that triggered this snapshot
    [Required]
    [MaxLength(20)]
    public string Action { get; set; } = null!;

    // Full JSON snapshot of the entity at this version
    [Required]
    public string Content { get; set; } = null!;

    [Required]
    [MaxLength(36)]
    public string CreatedBy { get; set; } = null!;

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [MaxLength(36)]
    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}


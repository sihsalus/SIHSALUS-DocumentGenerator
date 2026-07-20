using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIHSALUS_DocumentGenerator.Models.BaseEntities;

public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public Guid Uuid { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(36)]
    public string CreatedBy { get; set; } = null!;

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [MaxLength(36)]
    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    [MaxLength(36)]
    public string? InactiveBy { get; set; }

    public DateTime? InactiveAt { get; set; }

    [MaxLength(500)]
    public string? InactiveReason { get; set; }
}


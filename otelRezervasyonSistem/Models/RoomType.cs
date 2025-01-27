using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otelRezervasyonSistem.Models;

public class RoomType
{
    [Key]
    public int RoomTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public int MaxOccupancy { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal BasePrice { get; set; }

    // Navigation property
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
} 
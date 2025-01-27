using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otelRezervasyonSistem.Models;

public class Room
{
    [Key]
    public int RoomId { get; set; }

    [Required]
    [StringLength(10)]
    public string RoomNumber { get; set; } = string.Empty;

    public int RoomTypeId { get; set; }

    [ForeignKey("RoomTypeId")]
    public virtual RoomType RoomType { get; set; } = null!;

    public int Floor { get; set; }

    [Required]
    public RoomStatus Status { get; set; } = RoomStatus.Available;

    [Column(TypeName = "decimal(18,2)")]
    public decimal PricePerNight { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    // Navigation property
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}

public enum RoomStatus
{
    Available,
    Occupied,
    Cleaning,
    Maintenance,
    OutOfService
} 
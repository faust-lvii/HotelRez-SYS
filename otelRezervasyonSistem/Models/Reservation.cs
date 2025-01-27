using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otelRezervasyonSistem.Models;

public class Reservation
{
    [Key]
    public int ReservationId { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public int RoomId { get; set; }

    [Required]
    public DateTime CheckInDate { get; set; }

    [Required]
    public DateTime CheckOutDate { get; set; }

    [Required]
    public int NumberOfGuests { get; set; }

    [Required]
    public ReservationStatus Status { get; set; }

    [StringLength(500)]
    public string? SpecialRequests { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPrice { get; set; }

    public DateTime CreatedDate { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("RoomId")]
    public virtual Room Room { get; set; } = null!;

    public virtual Invoice? Invoice { get; set; }
}

public enum ReservationStatus
{
    All = -1,
    Pending,
    Confirmed,
    CheckedIn,
    CheckedOut,
    Cancelled
} 
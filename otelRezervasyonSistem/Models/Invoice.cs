using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otelRezervasyonSistem.Models;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    [Required]
    [StringLength(50)]
    public string InvoiceNumber { get; set; } = string.Empty;

    [Required]
    public DateTime InvoiceDate { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    public InvoiceStatus Status { get; set; }

    [StringLength(500)]
    public string? Notes { get; set; }

    public DateTime CreatedDate { get; set; }

    [Required]
    public int ReservationId { get; set; }

    [ForeignKey("ReservationId")]
    public virtual Reservation? Reservation { get; set; }
}

public enum InvoiceStatus
{
    All = -1,
    Pending,
    Paid,
    Cancelled
} 
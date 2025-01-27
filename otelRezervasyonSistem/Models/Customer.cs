using System.ComponentModel.DataAnnotations;

namespace otelRezervasyonSistem.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(11)]
    public string IdentityNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Phone { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Address { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    // Navigation property
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
} 
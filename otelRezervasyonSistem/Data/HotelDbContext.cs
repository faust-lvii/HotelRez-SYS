using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Data;

public class HotelDbContext : DbContext
{
    public HotelDbContext(DbContextOptions<HotelDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<RoomType> RoomTypes { get; set; } = null!;
    public DbSet<Reservation> Reservations { get; set; } = null!;
    public DbSet<Invoice> Invoices { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships and constraints
        modelBuilder.Entity<Room>()
            .HasOne(r => r.RoomType)
            .WithMany(rt => rt.Rooms)
            .HasForeignKey(r => r.RoomTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Customer)
            .WithMany(c => c.Reservations)
            .HasForeignKey(r => r.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Room)
            .WithMany(rm => rm.Reservations)
            .HasForeignKey(r => r.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Reservation)
            .WithOne(r => r.Invoice)
            .HasForeignKey<Invoice>(i => i.ReservationId)
            .OnDelete(DeleteBehavior.Restrict);

        // Add some sample data
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        // Add sample room types
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType { RoomTypeId = 1, Name = "Standart Oda", MaxOccupancy = 2, BasePrice = 1000.00m },
            new RoomType { RoomTypeId = 2, Name = "Deluxe Oda", MaxOccupancy = 2, BasePrice = 1500.00m },
            new RoomType { RoomTypeId = 3, Name = "Suit", MaxOccupancy = 4, BasePrice = 2500.00m }
        );

        // Add sample rooms
        modelBuilder.Entity<Room>().HasData(
            new Room { RoomId = 1, RoomNumber = "101", RoomTypeId = 1, Floor = 1, Status = RoomStatus.Available, PricePerNight = 1000.00m },
            new Room { RoomId = 2, RoomNumber = "102", RoomTypeId = 1, Floor = 1, Status = RoomStatus.Available, PricePerNight = 1000.00m },
            new Room { RoomId = 3, RoomNumber = "201", RoomTypeId = 2, Floor = 2, Status = RoomStatus.Available, PricePerNight = 1500.00m },
            new Room { RoomId = 4, RoomNumber = "301", RoomTypeId = 3, Floor = 3, Status = RoomStatus.Available, PricePerNight = 2500.00m }
        );
    }
} 
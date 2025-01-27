using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;
using System.Data;

namespace otelRezervasyonSistem.Forms;

public partial class ReportsForm : Form
{
    private readonly HotelDbContext _context;

    private class ReportTypeItem
    {
        public required ReportType Type { get; init; }
        public required string Name { get; init; }
    }

    private class ReservationReportItem
    {
        public required string Customer { get; init; }
        public required string RoomNumber { get; init; }
        public required string RoomType { get; init; }
        public required string CheckInDate { get; init; }
        public required string CheckOutDate { get; init; }
        public required int NumberOfGuests { get; init; }
        public required string TotalPrice { get; init; }
        public required string Status { get; init; }
    }

    private class InvoiceReportItem
    {
        public required string InvoiceNumber { get; init; }
        public required string Customer { get; init; }
        public required string RoomNumber { get; init; }
        public required string InvoiceDate { get; init; }
        public required string DueDate { get; init; }
        public required string Amount { get; init; }
        public required string Status { get; init; }
    }

    private class RoomReportItem
    {
        public required string RoomNumber { get; init; }
        public required string RoomType { get; init; }
        public required int Capacity { get; init; }
        public required int ReservationCount { get; init; }
        public required string OccupancyRate { get; init; }
        public required string Revenue { get; init; }
    }

    private class CustomerReportItem
    {
        public required string Customer { get; init; }
        public required string Phone { get; init; }
        public required string Email { get; init; }
        public required int ReservationCount { get; init; }
        public required int TotalNights { get; init; }
        public required string TotalSpent { get; init; }
    }

    public ReportsForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        // Initialize date filters
        dtpStartDate.Value = DateTime.Today.AddDays(-30);
        dtpEndDate.Value = DateTime.Today;

        // Wire up events
        dtpStartDate.ValueChanged += DateFilter_ValueChanged;
        dtpEndDate.ValueChanged += DateFilter_ValueChanged;
        cmbReportType.SelectedIndexChanged += CmbReportType_SelectedIndexChanged;

        // Initialize report types
        var reportTypes = new[]
        {
            new ReportTypeItem { Type = ReportType.Reservations, Name = "Rezervasyon Raporu" },
            new ReportTypeItem { Type = ReportType.Invoices, Name = "Fatura Raporu" },
            new ReportTypeItem { Type = ReportType.Rooms, Name = "Oda Doluluk Raporu" },
            new ReportTypeItem { Type = ReportType.Customers, Name = "Müşteri Raporu" }
        };

        cmbReportType.DataSource = reportTypes;
        cmbReportType.DisplayMember = nameof(ReportTypeItem.Name);
        cmbReportType.ValueMember = nameof(ReportTypeItem.Type);
        cmbReportType.SelectedIndex = 0;
    }

    private void DateFilter_ValueChanged(object? sender, EventArgs e)
    {
        if (dtpStartDate.Value > dtpEndDate.Value)
        {
            if (sender == dtpStartDate)
                dtpEndDate.Value = dtpStartDate.Value;
            else
                dtpStartDate.Value = dtpEndDate.Value;
        }

        LoadReport();
    }

    private void CmbReportType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadReport();
    }

    private void LoadReport()
    {
        if (cmbReportType.SelectedItem is not ReportTypeItem selectedItem) return;

        switch (selectedItem.Type)
        {
            case ReportType.Reservations:
                LoadReservationsReport();
                break;
            case ReportType.Invoices:
                LoadInvoicesReport();
                break;
            case ReportType.Rooms:
                LoadRoomsReport();
                break;
            case ReportType.Customers:
                LoadCustomersReport();
                break;
        }
    }

    private void LoadReservationsReport()
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;

        var query = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
            .ThenInclude(r => r!.RoomType)
            .Where(r => r.CheckInDate.Date >= startDate && r.CheckInDate.Date <= endDate)
            .OrderByDescending(r => r.CheckInDate)
            .ToList();

        var reservations = query
            .Select(r => new ReservationReportItem
            {
                Customer = r.Customer != null ? $"{r.Customer.FirstName} {r.Customer.LastName}".Trim() : "",
                RoomNumber = r.Room?.RoomNumber ?? "",
                RoomType = r.Room?.RoomType?.Name ?? "",
                CheckInDate = r.CheckInDate.ToShortDateString(),
                CheckOutDate = r.CheckOutDate.ToShortDateString(),
                NumberOfGuests = r.NumberOfGuests,
                TotalPrice = r.TotalPrice.ToString("C2"),
                Status = GetReservationStatusText(r.Status)
            })
            .ToList();

        dgvReport.DataSource = reservations;

        // Update summary
        var totalAmount = query
            .Where(r => r.Status != ReservationStatus.Cancelled)
            .Sum(r => r.TotalPrice);
        var totalReservations = query.Count;
        var totalGuests = query.Sum(r => r.NumberOfGuests);

        lblSummary.Text = $"Toplam Rezervasyon: {totalReservations} | " +
                         $"Toplam Misafir: {totalGuests} | " +
                         $"Toplam Tutar: {totalAmount:C2}";
    }

    private void LoadInvoicesReport()
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;

        var query = _context.Invoices
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Customer)
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Room)
            .Where(i => i.InvoiceDate.Date >= startDate && i.InvoiceDate.Date <= endDate)
            .OrderByDescending(i => i.InvoiceDate)
            .ToList();

        var invoices = query
            .Select(i => new InvoiceReportItem
            {
                InvoiceNumber = i.InvoiceNumber,
                Customer = i.Reservation?.Customer != null 
                    ? $"{i.Reservation.Customer.FirstName} {i.Reservation.Customer.LastName}".Trim() 
                    : "",
                RoomNumber = i.Reservation?.Room?.RoomNumber ?? "",
                InvoiceDate = i.InvoiceDate.ToShortDateString(),
                DueDate = i.DueDate.ToShortDateString(),
                Amount = i.Amount.ToString("C2"),
                Status = GetInvoiceStatusText(i.Status)
            })
            .ToList();

        dgvReport.DataSource = invoices;

        // Update summary
        var totalAmount = query
            .Where(i => i.Status != InvoiceStatus.Cancelled)
            .Sum(i => i.Amount);
        var totalInvoices = query.Count;
        var paidAmount = query
            .Where(i => i.Status == InvoiceStatus.Paid)
            .Sum(i => i.Amount);

        lblSummary.Text = $"Toplam Fatura: {totalInvoices} | " +
                         $"Toplam Tutar: {totalAmount:C2} | " +
                         $"Tahsil Edilen: {paidAmount:C2}";
    }

    private void LoadRoomsReport()
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;

        var query = _context.Rooms
            .Include(r => r.RoomType)
            .Include(r => r.Reservations)
            .OrderBy(r => r.RoomNumber)
            .ToList();

        var rooms = query
            .Select(r =>
            {
                var reservations = r.Reservations
                    .Where(res => res.CheckInDate.Date >= startDate &&
                                res.CheckInDate.Date <= endDate &&
                                res.Status != ReservationStatus.Cancelled)
                    .ToList();

                var totalDays = (endDate - startDate).Days + 1;
                var reservedDays = reservations.Sum(res =>
                {
                    var start = res.CheckInDate > startDate ? res.CheckInDate : startDate;
                    var end = res.CheckOutDate < endDate ? res.CheckOutDate : endDate;
                    return (end - start).Days + 1;
                });

                var occupancyRate = totalDays > 0 ? (decimal)reservedDays / totalDays * 100 : 0;
                var totalRevenue = reservations.Sum(res => res.TotalPrice);

                return new RoomReportItem
                {
                    RoomNumber = r.RoomNumber,
                    RoomType = r.RoomType?.Name ?? "",
                    Capacity = r.RoomType?.MaxOccupancy ?? 0,
                    ReservationCount = reservations.Count,
                    OccupancyRate = $"{occupancyRate:N1}%",
                    Revenue = totalRevenue.ToString("C2")
                };
            })
            .ToList();

        dgvReport.DataSource = rooms;

        // Update summary
        var totalRooms = query.Count;
        var totalRevenue = query
            .SelectMany(r => r.Reservations)
            .Where(res => res.CheckInDate.Date >= startDate &&
                         res.CheckInDate.Date <= endDate &&
                         res.Status != ReservationStatus.Cancelled)
            .Sum(res => res.TotalPrice);
        var totalReservations = query
            .SelectMany(r => r.Reservations)
            .Count(res => res.CheckInDate.Date >= startDate &&
                         res.CheckInDate.Date <= endDate &&
                         res.Status != ReservationStatus.Cancelled);

        lblSummary.Text = $"Toplam Oda: {totalRooms} | " +
                         $"Toplam Rezervasyon: {totalReservations} | " +
                         $"Toplam Gelir: {totalRevenue:C2}";
    }

    private void LoadCustomersReport()
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;

        var query = _context.Customers
            .Include(c => c.Reservations)
            .ThenInclude(r => r.Room)
            .OrderBy(c => c.LastName)
            .ThenBy(c => c.FirstName)
            .ToList();

        var customers = query
            .Select(c =>
            {
                var reservations = c.Reservations
                    .Where(r => r.CheckInDate.Date >= startDate &&
                               r.CheckInDate.Date <= endDate &&
                               r.Status != ReservationStatus.Cancelled)
                    .ToList();

                var totalSpent = reservations.Sum(r => r.TotalPrice);
                var totalNights = reservations.Sum(r => (r.CheckOutDate - r.CheckInDate).Days);

                return new CustomerReportItem
                {
                    Customer = $"{c.FirstName} {c.LastName}".Trim(),
                    Phone = c.Phone ?? "",
                    Email = c.Email ?? "",
                    ReservationCount = reservations.Count,
                    TotalNights = totalNights,
                    TotalSpent = totalSpent.ToString("C2")
                };
            })
            .ToList();

        dgvReport.DataSource = customers;

        // Update summary
        var totalCustomers = query.Count;
        var activeCustomers = customers.Count(c => c.ReservationCount > 0);
        var totalRevenue = customers.Sum(c => decimal.TryParse(c.TotalSpent.TrimStart('₺', ' '), out var amount) ? amount : 0);

        lblSummary.Text = $"Toplam Müşteri: {totalCustomers} | " +
                         $"Aktif Müşteri: {activeCustomers} | " +
                         $"Toplam Gelir: {totalRevenue:C2}";
    }

    private static string GetReservationStatusText(ReservationStatus status)
    {
        return status switch
        {
            ReservationStatus.Pending => "Bekliyor",
            ReservationStatus.Confirmed => "Onaylandı",
            ReservationStatus.CheckedIn => "Giriş Yapıldı",
            ReservationStatus.CheckedOut => "Çıkış Yapıldı",
            ReservationStatus.Cancelled => "İptal Edildi",
            _ => "Bilinmiyor"
        };
    }

    private static string GetInvoiceStatusText(InvoiceStatus status)
    {
        return status switch
        {
            InvoiceStatus.Pending => "Bekliyor",
            InvoiceStatus.Paid => "Ödendi",
            InvoiceStatus.Cancelled => "İptal Edildi",
            _ => "Bilinmiyor"
        };
    }

    private void BtnExport_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Rapor dışa aktarma özelliği henüz eklenmedi.",
            "Bilgi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void BtnPrint_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Rapor yazdırma özelliği henüz eklenmedi.",
            "Bilgi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}

public enum ReportType
{
    Reservations,
    Invoices,
    Rooms,
    Customers
} 
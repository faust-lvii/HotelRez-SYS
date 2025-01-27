using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class ReservationsForm : Form
{
    private readonly HotelDbContext _context;

    private class StatusItem
    {
        public required ReservationStatus Status { get; init; }
        public required string Name { get; init; }
    }

    public ReservationsForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        // Wire up events
        btnAdd.Click += BtnAdd_Click;
        btnEdit.Click += BtnEdit_Click;
        btnDelete.Click += BtnDelete_Click;
        btnCheckIn.Click += BtnCheckIn_Click;
        btnCheckOut.Click += BtnCheckOut_Click;
        txtSearch.TextChanged += TxtSearch_TextChanged;
        dtpStartDate.ValueChanged += DateFilter_Changed;
        dtpEndDate.ValueChanged += DateFilter_Changed;
        cmbStatus.SelectedIndexChanged += DateFilter_Changed;

        // Initialize date filters
        dtpStartDate.Value = DateTime.Today;
        dtpEndDate.Value = DateTime.Today.AddDays(30);

        LoadReservationStatuses();
        LoadReservations();
    }

    private void LoadReservationStatuses()
    {
        var statuses = new[]
        {
            new StatusItem { Status = ReservationStatus.Pending, Name = "Bekliyor" },
            new StatusItem { Status = ReservationStatus.Confirmed, Name = "Onaylandı" },
            new StatusItem { Status = ReservationStatus.CheckedIn, Name = "Giriş Yapıldı" },
            new StatusItem { Status = ReservationStatus.CheckedOut, Name = "Çıkış Yapıldı" },
            new StatusItem { Status = ReservationStatus.Cancelled, Name = "İptal Edildi" }
        };
        
        cmbStatus.DataSource = statuses;
        cmbStatus.DisplayMember = nameof(StatusItem.Name);
        cmbStatus.ValueMember = nameof(StatusItem.Status);
    }

    private void LoadReservations()
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;
        var status = cmbStatus.SelectedItem is StatusItem selectedItem ? selectedItem.Status : ReservationStatus.Pending;

        var query = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
                .ThenInclude(r => r.RoomType)
            .Include(r => r.Invoice)
            .Where(r => r.CheckInDate.Date >= startDate && 
                       r.CheckOutDate.Date <= endDate)
            .Where(r => r.Status == status);

        if (!string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            var search = txtSearch.Text.ToLower();
            query = query.Where(r =>
                (r.Customer != null && (
                    EF.Functions.Like(r.Customer.FirstName.ToLower(), $"%{search}%") ||
                    EF.Functions.Like(r.Customer.LastName.ToLower(), $"%{search}%"))) ||
                (r.Room != null && EF.Functions.Like(r.Room.RoomNumber.ToLower(), $"%{search}%")));
        }

        var reservations = query
            .OrderByDescending(r => r.CheckInDate)
            .Select(r => new
            {
                r.ReservationId,
                CustomerName = r.Customer != null ? r.Customer.FirstName + " " + r.Customer.LastName : string.Empty,
                RoomNumber = r.Room != null ? r.Room.RoomNumber : string.Empty,
                RoomType = r.Room != null && r.Room.RoomType != null ? r.Room.RoomType.Name : string.Empty,
                r.CheckInDate,
                r.CheckOutDate,
                r.NumberOfGuests,
                r.TotalPrice,
                r.Status,
                HasInvoice = r.Invoice != null
            })
            .ToList()
            .Select(r => new
            {
                r.ReservationId,
                Customer = r.CustomerName,
                RoomNumber = r.RoomNumber,
                RoomType = r.RoomType,
                CheckIn = r.CheckInDate.ToShortDateString(),
                CheckOut = r.CheckOutDate.ToShortDateString(),
                r.NumberOfGuests,
                TotalPrice = r.TotalPrice.ToString("C2"),
                Status = GetReservationStatusText(r.Status),
                r.HasInvoice
            })
            .ToList();

        dgvReservations.DataSource = reservations;

        if (dgvReservations.Columns["ReservationId"] is DataGridViewColumn idColumn)
            idColumn.Visible = false;
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
            _ => status.ToString()
        };
    }

    private void DateFilter_Changed(object? sender, EventArgs e)
    {
        LoadReservations();
    }

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadReservations();
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        var addForm = new ReservationAddEditForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadReservations();
        }
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        if (dgvReservations.CurrentRow?.Cells["ReservationId"].Value is not int reservationId) 
            return;

        var reservation = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
            .FirstOrDefault(r => r.ReservationId == reservationId);

        if (reservation != null)
        {
            var editForm = new ReservationAddEditForm(reservation);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadReservations();
            }
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvReservations.CurrentRow?.Cells["ReservationId"].Value is not int reservationId) 
            return;

        var reservation = _context.Reservations.Find(reservationId);
        if (reservation == null) return;

        if (reservation.Status == ReservationStatus.CheckedIn)
        {
            MessageBox.Show(
                "Giriş yapılmış bir rezervasyon silinemez.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show(
            "Bu rezervasyonu silmek istediğinizden emin misiniz?",
            "Rezervasyon Sil",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Rezervasyon silinirken bir hata oluştu: " + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    private void BtnCheckIn_Click(object? sender, EventArgs e)
    {
        if (dgvReservations.CurrentRow?.Cells["ReservationId"].Value is not int reservationId) 
            return;

        var reservation = _context.Reservations
            .Include(r => r.Room)
            .FirstOrDefault(r => r.ReservationId == reservationId);

        if (reservation == null) return;

        if (reservation.Status != ReservationStatus.Confirmed)
        {
            MessageBox.Show(
                "Sadece onaylanmış rezervasyonlar için giriş yapılabilir.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            reservation.Status = ReservationStatus.CheckedIn;
            if (reservation.Room != null)
            {
                reservation.Room.Status = RoomStatus.Occupied;
            }
            _context.SaveChanges();
            LoadReservations();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Check-in işlemi sırasında bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void BtnCheckOut_Click(object? sender, EventArgs e)
    {
        if (dgvReservations.CurrentRow?.Cells["ReservationId"].Value is not int reservationId) 
            return;

        var reservation = _context.Reservations
            .Include(r => r.Room)
            .Include(r => r.Invoice)
            .Include(r => r.Customer)
            .FirstOrDefault(r => r.ReservationId == reservationId);

        if (reservation == null) return;

        if (reservation.Status != ReservationStatus.CheckedIn)
        {
            MessageBox.Show(
                "Sadece giriş yapılmış rezervasyonlar için çıkış yapılabilir.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (reservation.Invoice == null)
        {
            var result = MessageBox.Show(
                "Bu rezervasyon için henüz fatura kesilmemiş. Fatura kesmek ister misiniz?",
                "Fatura Gerekli",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Create a new invoice with the reservation
                var invoice = new Invoice
                {
                    ReservationId = reservation.ReservationId,
                    InvoiceNumber = GenerateInvoiceNumber(),
                    InvoiceDate = DateTime.Today,
                    DueDate = DateTime.Today.AddDays(15),
                    Amount = reservation.TotalPrice,
                    Status = InvoiceStatus.Pending,
                    CreatedDate = DateTime.Now
                };

                var invoiceForm = new InvoiceAddEditForm(invoice);
                if (invoiceForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
        }

        try
        {
            reservation.Status = ReservationStatus.CheckedOut;
            if (reservation.Room != null)
            {
                reservation.Room.Status = RoomStatus.Cleaning;
            }
            _context.SaveChanges();
            LoadReservations();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Check-out işlemi sırasında bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private string GenerateInvoiceNumber()
    {
        // Get the last invoice number
        var lastInvoice = _context.Invoices
            .OrderByDescending(i => i.InvoiceNumber)
            .FirstOrDefault();

        if (lastInvoice == null)
        {
            return "INV-0001";
        }

        // Extract the number part and increment it
        var lastNumber = int.Parse(lastInvoice.InvoiceNumber.Split('-')[1]);
        return $"INV-{(lastNumber + 1):D4}";
    }
} 
using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class ReservationSelectForm : Form
{
    private readonly HotelDbContext _context;
    public Reservation? SelectedReservation { get; private set; }

    public ReservationSelectForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        LoadReservations();

        txtSearch.TextChanged += TxtSearch_TextChanged;
        cmbStatus.SelectedIndexChanged += CmbStatus_SelectedIndexChanged;
        dgvReservations.CellDoubleClick += DgvReservations_CellDoubleClick;

        // Initialize status filter
        cmbStatus.Items.Add(new { Status = ReservationStatus.All, Name = "Tüm Durumlar" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.Pending, Name = "Bekliyor" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.Confirmed, Name = "Onaylandı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.CheckedIn, Name = "Giriş Yapıldı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.CheckedOut, Name = "Çıkış Yapıldı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.Cancelled, Name = "İptal Edildi" });
        cmbStatus.DisplayMember = "Name";
        cmbStatus.ValueMember = "Status";
        cmbStatus.SelectedIndex = 0;
    }

    private void LoadReservations(string? searchText = null)
    {
        var query = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
            .ThenInclude(r => r.RoomType)
            .AsQueryable();

        if (cmbStatus.SelectedIndex > 0)
        {
            var status = (ReservationStatus)cmbStatus.SelectedValue;
            query = query.Where(r => r.Status == status);
        }

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            searchText = searchText.ToLower();
            query = query.Where(r =>
                r.Customer.FirstName.ToLower().Contains(searchText) ||
                r.Customer.LastName.ToLower().Contains(searchText) ||
                r.Room.RoomNumber.ToLower().Contains(searchText));
        }

        var reservations = query
            .OrderByDescending(r => r.CheckInDate)
            .ThenBy(r => r.Room.RoomNumber)
            .ToList();

        dgvReservations.DataSource = reservations.Select(r => new
        {
            r.ReservationId,
            Müşteri = $"{r.Customer.FirstName} {r.Customer.LastName}",
            OdaNo = r.Room.RoomNumber,
            OdaTipi = r.Room.RoomType.Name,
            GirişTarihi = r.CheckInDate.ToShortDateString(),
            ÇıkışTarihi = r.CheckOutDate.ToShortDateString(),
            KişiSayısı = r.NumberOfGuests,
            Tutar = r.TotalPrice.ToString("C2"),
            Durum = GetReservationStatusText(r.Status)
        }).ToList();

        if (dgvReservations.Columns["ReservationId"] != null)
            dgvReservations.Columns["ReservationId"].Visible = false;
    }

    private string GetReservationStatusText(ReservationStatus status)
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

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadReservations(txtSearch.Text);
    }

    private void CmbStatus_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadReservations(txtSearch.Text);
    }

    private void DgvReservations_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var reservationId = (int)dgvReservations.Rows[e.RowIndex].Cells["ReservationId"].Value;
        SelectedReservation = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
            .ThenInclude(r => r.RoomType)
            .FirstOrDefault(r => r.ReservationId == reservationId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnSelect_Click(object sender, EventArgs e)
    {
        if (dgvReservations.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir rezervasyon seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var reservationId = (int)dgvReservations.CurrentRow.Cells["ReservationId"].Value;
        SelectedReservation = _context.Reservations
            .Include(r => r.Customer)
            .Include(r => r.Room)
            .ThenInclude(r => r.RoomType)
            .FirstOrDefault(r => r.ReservationId == reservationId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
} 
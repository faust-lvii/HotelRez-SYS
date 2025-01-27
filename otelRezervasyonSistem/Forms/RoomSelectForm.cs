using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class RoomSelectForm : Form
{
    private readonly HotelDbContext _context;
    private readonly DateTime _checkInDate;
    private readonly DateTime _checkOutDate;
    public Room? SelectedRoom { get; private set; }

    public RoomSelectForm(DateTime checkInDate, DateTime checkOutDate)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _checkInDate = checkInDate;
        _checkOutDate = checkOutDate;

        LoadRoomTypes();
        LoadRooms();

        txtSearch.TextChanged += TxtSearch_TextChanged;
        cmbRoomType.SelectedIndexChanged += CmbRoomType_SelectedIndexChanged;
        dgvRooms.CellDoubleClick += DgvRooms_CellDoubleClick;
    }

    private void LoadRoomTypes()
    {
        var roomTypes = _context.RoomTypes
            .OrderBy(rt => rt.Name)
            .ToList();

        cmbRoomType.Items.Add(new RoomType { RoomTypeId = 0, Name = "Tüm Oda Tipleri" });
        foreach (var roomType in roomTypes)
        {
            cmbRoomType.Items.Add(roomType);
        }

        cmbRoomType.DisplayMember = "Name";
        cmbRoomType.ValueMember = "RoomTypeId";
        cmbRoomType.SelectedIndex = 0;
    }

    private void LoadRooms(string? searchText = null)
    {
        var query = _context.Rooms
            .Include(r => r.RoomType)
            .Where(r => !_context.Reservations.Any(res =>
                res.RoomId == r.RoomId &&
                res.Status != ReservationStatus.Cancelled &&
                res.Status != ReservationStatus.CheckedOut &&
                ((_checkInDate >= res.CheckInDate && _checkInDate < res.CheckOutDate) ||
                 (_checkOutDate > res.CheckInDate && _checkOutDate <= res.CheckOutDate) ||
                 (_checkInDate <= res.CheckInDate && _checkOutDate >= res.CheckOutDate))));

        if (cmbRoomType.SelectedIndex > 0)
        {
            var roomTypeId = ((RoomType)cmbRoomType.SelectedItem).RoomTypeId;
            query = query.Where(r => r.RoomTypeId == roomTypeId);
        }

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            searchText = searchText.ToLower();
            query = query.Where(r =>
                r.RoomNumber.ToLower().Contains(searchText) ||
                r.RoomType.Name.ToLower().Contains(searchText));
        }

        var rooms = query
            .OrderBy(r => r.RoomNumber)
            .ToList();

        dgvRooms.DataSource = rooms.Select(r => new
        {
            r.RoomId,
            OdaNo = r.RoomNumber,
            OdaTipi = r.RoomType.Name,
            Kapasite = r.RoomType.MaxOccupancy,
            Fiyat = r.PricePerNight.ToString("C2")
        }).ToList();

        if (dgvRooms.Columns["RoomId"] != null)
            dgvRooms.Columns["RoomId"].Visible = false;
    }

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadRooms(txtSearch.Text);
    }

    private void CmbRoomType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        LoadRooms(txtSearch.Text);
    }

    private void DgvRooms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var roomId = (int)dgvRooms.Rows[e.RowIndex].Cells["RoomId"].Value;
        SelectedRoom = _context.Rooms
            .Include(r => r.RoomType)
            .FirstOrDefault(r => r.RoomId == roomId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnSelect_Click(object sender, EventArgs e)
    {
        if (dgvRooms.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir oda seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
        SelectedRoom = _context.Rooms
            .Include(r => r.RoomType)
            .FirstOrDefault(r => r.RoomId == roomId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
} 
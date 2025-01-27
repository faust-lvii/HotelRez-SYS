using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class RoomsForm : Form
{
    private readonly HotelDbContext _context;

    public RoomsForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        // Wire up events
        btnAdd.Click += BtnAdd_Click;
        btnEdit.Click += BtnEdit_Click;
        btnDelete.Click += BtnDelete_Click;
        txtSearch.TextChanged += TxtSearch_TextChanged;
        cmbRoomType.SelectedIndexChanged += FilterChanged;
        cmbStatus.SelectedIndexChanged += FilterChanged;

        LoadRoomTypes();
        LoadRoomStatuses();
        LoadRooms();
    }

    private void LoadRoomTypes()
    {
        var roomTypes = _context.RoomTypes.ToList();
        cmbRoomType.Items.Add(new { Id = 0, Name = "Tüm Tipler" });
        foreach (var type in roomTypes)
        {
            cmbRoomType.Items.Add(new { Id = type.RoomTypeId, Name = type.Name });
        }
        cmbRoomType.DisplayMember = "Name";
        cmbRoomType.ValueMember = "Id";
        cmbRoomType.SelectedIndex = 0;
    }

    private void LoadRoomStatuses()
    {
        cmbStatus.Items.Add(new { Status = RoomStatus.Available, Name = "Müsait" });
        cmbStatus.Items.Add(new { Status = RoomStatus.Occupied, Name = "Dolu" });
        cmbStatus.Items.Add(new { Status = RoomStatus.Cleaning, Name = "Temizleniyor" });
        cmbStatus.Items.Add(new { Status = RoomStatus.Maintenance, Name = "Bakımda" });
        cmbStatus.Items.Add(new { Status = RoomStatus.OutOfService, Name = "Hizmet Dışı" });
        
        cmbStatus.DisplayMember = "Name";
        cmbStatus.ValueMember = "Status";
        cmbStatus.SelectedIndex = 0;
    }

    private void LoadRooms()
    {
        var rooms = _context.Rooms
            .Include(r => r.RoomType)
            .Include(r => r.Reservations)
            .ToList();

        ApplyFilters(rooms);
    }

    private void ApplyFilters(List<Room> rooms)
    {
        var filteredRooms = rooms;

        // Apply room type filter
        if (cmbRoomType.SelectedIndex > 0)
        {
            var selectedType = (dynamic)cmbRoomType.SelectedItem;
            filteredRooms = filteredRooms.Where(r => r.RoomTypeId == selectedType.Id).ToList();
        }

        // Apply status filter
        if (cmbStatus.SelectedIndex >= 0)
        {
            var selectedStatus = (dynamic)cmbStatus.SelectedItem;
            filteredRooms = filteredRooms.Where(r => r.Status == selectedStatus.Status).ToList();
        }

        // Apply search filter
        if (!string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            var searchText = txtSearch.Text.ToLower();
            filteredRooms = filteredRooms.Where(r => 
                r.RoomNumber.ToLower().Contains(searchText) ||
                r.Description?.ToLower().Contains(searchText) == true ||
                r.RoomType.Name.ToLower().Contains(searchText)
            ).ToList();
        }

        dgvRooms.DataSource = filteredRooms.Select(r => new
        {
            r.RoomId,
            r.RoomNumber,
            OdaTipi = r.RoomType.Name,
            Kat = r.Floor,
            Durum = GetStatusText(r.Status),
            r.PricePerNight,
            AktifRezervasyon = r.Reservations.Any(res => 
                res.Status == ReservationStatus.Confirmed || 
                res.Status == ReservationStatus.CheckedIn)
        }).ToList();

        // Configure columns
        if (dgvRooms.Columns["RoomId"] != null)
            dgvRooms.Columns["RoomId"].Visible = false;

        if (dgvRooms.Columns["PricePerNight"] != null)
            dgvRooms.Columns["PricePerNight"].DefaultCellStyle.Format = "C2";
    }

    private string GetStatusText(RoomStatus status)
    {
        return status switch
        {
            RoomStatus.Available => "Müsait",
            RoomStatus.Occupied => "Dolu",
            RoomStatus.Cleaning => "Temizleniyor",
            RoomStatus.Maintenance => "Bakımda",
            RoomStatus.OutOfService => "Hizmet Dışı",
            _ => status.ToString()
        };
    }

    private void FilterChanged(object? sender, EventArgs e)
    {
        LoadRooms();
    }

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadRooms();
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        var addForm = new RoomAddEditForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadRooms();
        }
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        if (dgvRooms.CurrentRow == null) return;

        var roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
        var room = _context.Rooms
            .Include(r => r.RoomType)
            .FirstOrDefault(r => r.RoomId == roomId);

        if (room != null)
        {
            var editForm = new RoomAddEditForm(room);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadRooms();
            }
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvRooms.CurrentRow == null) return;

        var roomId = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
        var room = _context.Rooms.Find(roomId);

        if (room != null)
        {
            var result = MessageBox.Show(
                "Bu odayı silmek istediğinizden emin misiniz?",
                "Oda Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.Rooms.Remove(room);
                    _context.SaveChanges();
                    LoadRooms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Oda silinirken bir hata oluştu: " + ex.Message,
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
} 
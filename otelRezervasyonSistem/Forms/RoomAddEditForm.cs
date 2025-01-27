using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class RoomAddEditForm : Form
{
    private readonly HotelDbContext _context;
    private readonly Room? _room;
    private readonly bool _isEdit;

    public RoomAddEditForm(Room? room = null)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _room = room;
        _isEdit = room != null;

        LoadRoomTypes();
        LoadRoomStatuses();

        if (_isEdit)
        {
            Text = "Oda Düzenle";
            btnSave.Text = "Güncelle";
            LoadRoomData();
        }
        else
        {
            Text = "Yeni Oda";
            btnSave.Text = "Kaydet";
        }
    }

    private void LoadRoomTypes()
    {
        var roomTypes = _context.RoomTypes.ToList();
        cmbRoomType.DataSource = roomTypes;
        cmbRoomType.DisplayMember = "Name";
        cmbRoomType.ValueMember = "RoomTypeId";
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

    private void LoadRoomData()
    {
        if (_room == null) return;

        txtRoomNumber.Text = _room.RoomNumber;
        numFloor.Value = _room.Floor;
        cmbRoomType.SelectedValue = _room.RoomTypeId;
        numPrice.Value = _room.PricePerNight;
        txtDescription.Text = _room.Description;

        // Find and select the current status
        for (int i = 0; i < cmbStatus.Items.Count; i++)
        {
            var item = (dynamic)cmbStatus.Items[i];
            if (item.Status == _room.Status)
            {
                cmbStatus.SelectedIndex = i;
                break;
            }
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            if (_isEdit)
            {
                // Update existing room
                _room!.RoomNumber = txtRoomNumber.Text;
                _room.Floor = (int)numFloor.Value;
                _room.RoomTypeId = (int)cmbRoomType.SelectedValue;
                _room.Status = ((dynamic)cmbStatus.SelectedItem).Status;
                _room.PricePerNight = numPrice.Value;
                _room.Description = txtDescription.Text;

                _context.Rooms.Update(_room);
            }
            else
            {
                // Create new room
                var room = new Room
                {
                    RoomNumber = txtRoomNumber.Text,
                    Floor = (int)numFloor.Value,
                    RoomTypeId = (int)cmbRoomType.SelectedValue,
                    Status = ((dynamic)cmbStatus.SelectedItem).Status,
                    PricePerNight = numPrice.Value,
                    Description = txtDescription.Text
                };

                _context.Rooms.Add(room);
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Oda kaydedilirken bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
        {
            MessageBox.Show("Lütfen oda numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtRoomNumber.Focus();
            return false;
        }

        if (cmbRoomType.SelectedItem == null)
        {
            MessageBox.Show("Lütfen oda tipini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbRoomType.Focus();
            return false;
        }

        if (numPrice.Value <= 0)
        {
            MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numPrice.Focus();
            return false;
        }

        // Check if room number already exists (for new rooms)
        if (!_isEdit)
        {
            var exists = _context.Rooms.Any(r => r.RoomNumber == txtRoomNumber.Text);
            if (exists)
            {
                MessageBox.Show("Bu oda numarası zaten kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomNumber.Focus();
                return false;
            }
        }

        return true;
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
} 
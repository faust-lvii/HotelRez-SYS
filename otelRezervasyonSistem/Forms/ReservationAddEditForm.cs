using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class ReservationAddEditForm : Form
{
    private readonly HotelDbContext _context;
    private readonly Reservation? _reservation;
    private readonly bool _isEdit;
    private Customer? _selectedCustomer;
    private Room? _selectedRoom;

    public ReservationAddEditForm(Reservation? reservation = null)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _reservation = reservation;
        _isEdit = reservation != null;

        // Initialize dates
        dtpCheckIn.Value = DateTime.Today;
        dtpCheckOut.Value = DateTime.Today.AddDays(1);
        dtpCheckIn.MinDate = DateTime.Today;
        dtpCheckOut.MinDate = DateTime.Today.AddDays(1);

        LoadReservationStatuses();

        if (_isEdit)
        {
            Text = "Rezervasyon Düzenle";
            btnSave.Text = "Güncelle";
            LoadReservationData();
        }
        else
        {
            Text = "Yeni Rezervasyon";
            btnSave.Text = "Kaydet";
            cmbStatus.SelectedIndex = 0;
        }

        // Wire up events
        dtpCheckIn.ValueChanged += Dates_ValueChanged;
        dtpCheckOut.ValueChanged += Dates_ValueChanged;
        numGuests.ValueChanged += NumGuests_ValueChanged;
    }

    private void LoadReservationStatuses()
    {
        cmbStatus.Items.Add(new { Status = ReservationStatus.Pending, Name = "Bekliyor" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.Confirmed, Name = "Onaylandı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.CheckedIn, Name = "Giriş Yapıldı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.CheckedOut, Name = "Çıkış Yapıldı" });
        cmbStatus.Items.Add(new { Status = ReservationStatus.Cancelled, Name = "İptal Edildi" });
        
        cmbStatus.DisplayMember = "Name";
        cmbStatus.ValueMember = "Status";
    }

    private void LoadReservationData()
    {
        if (_reservation == null) return;

        _selectedCustomer = _reservation.Customer;
        _selectedRoom = _reservation.Room;

        txtCustomer.Text = $"{_selectedCustomer?.FirstName} {_selectedCustomer?.LastName}";
        txtRoom.Text = $"{_selectedRoom?.RoomNumber} - {_selectedRoom?.RoomType?.Name}";
        dtpCheckIn.Value = _reservation.CheckInDate;
        dtpCheckOut.Value = _reservation.CheckOutDate;
        numGuests.Value = _reservation.NumberOfGuests;
        txtNotes.Text = _reservation.SpecialRequests;

        // Find and select the current status
        for (int i = 0; i < cmbStatus.Items.Count; i++)
        {
            var item = cmbStatus.Items[i] as dynamic;
            if (item != null && item.Status == _reservation.Status)
            {
                cmbStatus.SelectedIndex = i;
                break;
            }
        }

        UpdateTotalPrice();
    }

    private void BtnSelectCustomer_Click(object sender, EventArgs e)
    {
        var selectForm = new CustomerSelectForm();
        if (selectForm.ShowDialog() == DialogResult.OK)
        {
            _selectedCustomer = selectForm.SelectedCustomer;
            txtCustomer.Text = $"{_selectedCustomer.FirstName} {_selectedCustomer.LastName}";
        }
    }

    private void BtnSelectRoom_Click(object sender, EventArgs e)
    {
        var selectForm = new RoomSelectForm(dtpCheckIn.Value, dtpCheckOut.Value);
        if (selectForm.ShowDialog() == DialogResult.OK)
        {
            _selectedRoom = selectForm.SelectedRoom;
            txtRoom.Text = $"{_selectedRoom.RoomNumber} - {_selectedRoom.RoomType.Name}";
            numGuests.Maximum = _selectedRoom.RoomType.MaxOccupancy;
            UpdateTotalPrice();
        }
    }

    private void Dates_ValueChanged(object? sender, EventArgs e)
    {
        if (dtpCheckIn.Value >= dtpCheckOut.Value)
        {
            dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
        }

        if (_selectedRoom != null)
        {
            var reservationId = _reservation?.ReservationId ?? 0;
            var isAvailable = !_context.Reservations
                .Any(r => r.RoomId == _selectedRoom.RoomId &&
                         r.ReservationId != reservationId &&
                         r.Status != ReservationStatus.Cancelled &&
                         r.Status != ReservationStatus.CheckedOut &&
                         ((dtpCheckIn.Value >= r.CheckInDate && dtpCheckIn.Value < r.CheckOutDate) ||
                          (dtpCheckOut.Value > r.CheckInDate && dtpCheckOut.Value <= r.CheckOutDate) ||
                          (dtpCheckIn.Value <= r.CheckInDate && dtpCheckOut.Value >= r.CheckOutDate)));

            if (!isAvailable)
            {
                MessageBox.Show(
                    "Seçili oda bu tarihler için müsait değil.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (_reservation != null)
                {
                    dtpCheckIn.Value = _reservation.CheckInDate;
                    dtpCheckOut.Value = _reservation.CheckOutDate;
                }
                else
                {
                    _selectedRoom = null;
                    txtRoom.Text = string.Empty;
                }
                return;
            }
        }

        UpdateTotalPrice();
    }

    private void NumGuests_ValueChanged(object? sender, EventArgs e)
    {
        if (_selectedRoom != null && numGuests.Value > _selectedRoom.RoomType.MaxOccupancy)
        {
            MessageBox.Show(
                $"Bu oda tipi maksimum {_selectedRoom.RoomType.MaxOccupancy} kişi kapasitelidir.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            numGuests.Value = _selectedRoom.RoomType.MaxOccupancy;
        }
    }

    private void UpdateTotalPrice()
    {
        if (_selectedRoom == null) return;

        var days = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
        var totalPrice = _selectedRoom.PricePerNight * days;
        lblTotalPrice.Text = totalPrice.ToString("C2");
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            if (_isEdit)
            {
                // Update existing reservation
                _reservation!.CustomerId = _selectedCustomer!.CustomerId;
                _reservation.RoomId = _selectedRoom!.RoomId;
                _reservation.CheckInDate = dtpCheckIn.Value;
                _reservation.CheckOutDate = dtpCheckOut.Value;
                _reservation.NumberOfGuests = (int)numGuests.Value;
                _reservation.Status = ((dynamic)cmbStatus.SelectedItem)?.Status ?? ReservationStatus.Pending;
                _reservation.SpecialRequests = txtNotes.Text;
                _reservation.TotalPrice = decimal.Parse(lblTotalPrice.Text.TrimEnd('₺', ' '));

                _context.Reservations.Update(_reservation);
            }
            else
            {
                // Create new reservation
                var reservation = new Reservation
                {
                    CustomerId = _selectedCustomer!.CustomerId,
                    RoomId = _selectedRoom!.RoomId,
                    CheckInDate = dtpCheckIn.Value,
                    CheckOutDate = dtpCheckOut.Value,
                    NumberOfGuests = (int)numGuests.Value,
                    Status = ((dynamic)cmbStatus.SelectedItem)?.Status ?? ReservationStatus.Pending,
                    SpecialRequests = txtNotes.Text,
                    TotalPrice = decimal.Parse(lblTotalPrice.Text.TrimEnd('₺', ' ')),
                    CreatedDate = DateTime.Now
                };

                _context.Reservations.Add(reservation);
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Rezervasyon kaydedilirken bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private bool ValidateInputs()
    {
        if (_selectedCustomer == null)
        {
            MessageBox.Show("Lütfen müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnSelectCustomer.Focus();
            return false;
        }

        if (_selectedRoom == null)
        {
            MessageBox.Show("Lütfen oda seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnSelectRoom.Focus();
            return false;
        }

        if (dtpCheckIn.Value >= dtpCheckOut.Value)
        {
            MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpCheckOut.Focus();
            return false;
        }

        if (numGuests.Value > _selectedRoom.RoomType.MaxOccupancy)
        {
            MessageBox.Show($"Bu oda tipi maksimum {_selectedRoom.RoomType.MaxOccupancy} kişi kapasitelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numGuests.Focus();
            return false;
        }

        return true;
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
} 
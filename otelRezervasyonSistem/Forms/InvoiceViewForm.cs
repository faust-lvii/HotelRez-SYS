using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class InvoiceViewForm : Form
{
    private readonly HotelDbContext _context;
    private readonly Invoice _invoice;

    public InvoiceViewForm(Invoice invoice)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _invoice = invoice;

        LoadInvoiceData();
    }

    private void LoadInvoiceData()
    {
        // Load invoice details
        txtInvoiceNumber.Text = _invoice.InvoiceNumber;
        txtInvoiceDate.Text = _invoice.InvoiceDate.ToShortDateString();
        txtDueDate.Text = _invoice.DueDate.ToShortDateString();
        txtAmount.Text = _invoice.Amount.ToString("C2");
        txtStatus.Text = GetInvoiceStatusText(_invoice.Status);
        txtNotes.Text = _invoice.Notes ?? string.Empty;

        if (_invoice.Reservation?.Customer != null)
        {
            // Load customer details
            var customer = _invoice.Reservation.Customer;
            txtCustomerName.Text = $"{customer.FirstName} {customer.LastName}";
            txtCustomerPhone.Text = customer.Phone;
            txtCustomerEmail.Text = customer.Email;

            // Load reservation details
            var reservation = _invoice.Reservation;
            if (reservation.Room != null)
            {
                txtRoomNumber.Text = reservation.Room.RoomNumber;
                txtRoomType.Text = reservation.Room.RoomType?.Name ?? "Bilinmiyor";
            }
            txtCheckIn.Text = reservation.CheckInDate.ToShortDateString();
            txtCheckOut.Text = reservation.CheckOutDate.ToShortDateString();
            txtGuests.Text = reservation.NumberOfGuests.ToString();
            txtReservationStatus.Text = GetReservationStatusText(reservation.Status);
        }
    }

    private string GetInvoiceStatusText(InvoiceStatus status)
    {
        return status switch
        {
            InvoiceStatus.Pending => "Bekliyor",
            InvoiceStatus.Paid => "Ödendi",
            InvoiceStatus.Cancelled => "İptal Edildi",
            _ => "Bilinmiyor"
        };
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

    private void BtnPrint_Click(object sender, EventArgs e)
    {
        // TODO: Implement invoice printing
        MessageBox.Show(
            "Fatura yazdırma özelliği henüz eklenmedi.",
            "Bilgi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
} 
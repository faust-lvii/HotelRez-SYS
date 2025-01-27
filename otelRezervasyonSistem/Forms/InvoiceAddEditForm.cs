using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class InvoiceAddEditForm : Form
{
    private readonly HotelDbContext _context;
    private readonly Invoice? _invoice;
    private readonly bool _isEdit;
    private Reservation? _selectedReservation;

    public InvoiceAddEditForm(Invoice? invoice = null)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _invoice = invoice;
        _isEdit = invoice != null;

        // Initialize dates
        dtpInvoiceDate.Value = DateTime.Today;
        dtpDueDate.Value = DateTime.Today.AddDays(15);

        LoadInvoiceStatuses();

        if (_isEdit)
        {
            Text = "Fatura Düzenle";
            btnSave.Text = "Güncelle";
            LoadInvoiceData();
        }
        else
        {
            Text = "Yeni Fatura";
            btnSave.Text = "Kaydet";
            cmbStatus.SelectedIndex = 0;
        }
    }

    private void LoadInvoiceStatuses()
    {
        cmbStatus.Items.Add(new { Status = InvoiceStatus.Pending, Name = "Bekliyor" });
        cmbStatus.Items.Add(new { Status = InvoiceStatus.Paid, Name = "Ödendi" });
        cmbStatus.Items.Add(new { Status = InvoiceStatus.Cancelled, Name = "İptal Edildi" });
        
        cmbStatus.DisplayMember = "Name";
        cmbStatus.ValueMember = "Status";
    }

    private void LoadInvoiceData()
    {
        if (_invoice == null) return;

        _selectedReservation = _invoice.Reservation;
        txtReservation.Text = $"{_selectedReservation.Customer.FirstName} {_selectedReservation.Customer.LastName} - {_selectedReservation.Room.RoomNumber}";
        txtInvoiceNumber.Text = _invoice.InvoiceNumber;
        dtpInvoiceDate.Value = _invoice.InvoiceDate;
        dtpDueDate.Value = _invoice.DueDate;
        numAmount.Value = _invoice.Amount;
        txtNotes.Text = _invoice.Notes;

        // Find and select the current status
        for (int i = 0; i < cmbStatus.Items.Count; i++)
        {
            var item = (dynamic)cmbStatus.Items[i];
            if (item.Status == _invoice.Status)
            {
                cmbStatus.SelectedIndex = i;
                break;
            }
        }
    }

    private void BtnSelectReservation_Click(object sender, EventArgs e)
    {
        var form = new ReservationSelectForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            _selectedReservation = form.SelectedReservation;
            txtReservation.Text = $"{_selectedReservation.Customer.FirstName} {_selectedReservation.Customer.LastName} - {_selectedReservation.Room.RoomNumber}";
            numAmount.Value = _selectedReservation.TotalPrice;
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            if (_isEdit)
            {
                // Update existing invoice
                _invoice!.ReservationId = _selectedReservation!.ReservationId;
                _invoice.InvoiceNumber = txtInvoiceNumber.Text;
                _invoice.InvoiceDate = dtpInvoiceDate.Value;
                _invoice.DueDate = dtpDueDate.Value;
                _invoice.Amount = numAmount.Value;
                _invoice.Status = ((dynamic)cmbStatus.SelectedItem).Status;
                _invoice.Notes = txtNotes.Text;

                _context.Invoices.Update(_invoice);
            }
            else
            {
                // Create new invoice
                var invoice = new Invoice
                {
                    ReservationId = _selectedReservation!.ReservationId,
                    InvoiceNumber = txtInvoiceNumber.Text,
                    InvoiceDate = dtpInvoiceDate.Value,
                    DueDate = dtpDueDate.Value,
                    Amount = numAmount.Value,
                    Status = ((dynamic)cmbStatus.SelectedItem).Status,
                    Notes = txtNotes.Text,
                    CreatedDate = DateTime.Now
                };

                _context.Invoices.Add(invoice);
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Fatura kaydedilirken bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private bool ValidateInputs()
    {
        if (_selectedReservation == null)
        {
            MessageBox.Show("Lütfen rezervasyon seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnSelectReservation.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtInvoiceNumber.Text))
        {
            MessageBox.Show("Lütfen fatura numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtInvoiceNumber.Focus();
            return false;
        }

        if (dtpDueDate.Value < dtpInvoiceDate.Value)
        {
            MessageBox.Show("Son ödeme tarihi fatura tarihinden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtpDueDate.Focus();
            return false;
        }

        if (numAmount.Value <= 0)
        {
            MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numAmount.Focus();
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
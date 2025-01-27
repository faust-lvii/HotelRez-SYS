using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class InvoicesForm : Form
{
    private readonly HotelDbContext _context;

    private class StatusItem
    {
        public required InvoiceStatus Status { get; init; }
        public required string Name { get; init; }
    }

    private class InvoiceGridItem
    {
        public required int InvoiceId { get; init; }
        public required string InvoiceNumber { get; init; }
        public required string Customer { get; init; }
        public required string RoomNumber { get; init; }
        public required string InvoiceDate { get; init; }
        public required string DueDate { get; init; }
        public required string Amount { get; init; }
        public required string Status { get; init; }
    }

    public InvoicesForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        // Initialize date filters
        dtpStartDate.Value = DateTime.Today.AddDays(-30);
        dtpEndDate.Value = DateTime.Today;

        LoadInvoiceStatuses();
        LoadInvoices(string.Empty);
    }

    private void LoadInvoiceStatuses()
    {
        var statuses = new[]
        {
            new StatusItem { Status = InvoiceStatus.All, Name = "Tümü" },
            new StatusItem { Status = InvoiceStatus.Pending, Name = "Bekliyor" },
            new StatusItem { Status = InvoiceStatus.Paid, Name = "Ödendi" },
            new StatusItem { Status = InvoiceStatus.Cancelled, Name = "İptal Edildi" }
        };

        cmbStatus.DataSource = statuses;
        cmbStatus.DisplayMember = "Name";
        cmbStatus.ValueMember = "Status";
    }

    private void LoadInvoices(string searchText)
    {
        var startDate = dtpStartDate.Value.Date;
        var endDate = dtpEndDate.Value.Date;
        var status = (InvoiceStatus)cmbStatus.SelectedValue;

        var query = _context.Invoices
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Customer)
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Room)
            .Where(i => i.InvoiceDate.Date >= startDate && i.InvoiceDate.Date <= endDate);

        if (status != InvoiceStatus.All)
        {
            query = query.Where(i => i.Status == status);
        }

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            var search = searchText.ToLower();
            query = query.Where(i => 
                i.InvoiceNumber.ToLower().Contains(search) ||
                (i.Reservation != null && i.Reservation.Customer != null && 
                 (i.Reservation.Customer.FirstName.ToLower().Contains(search) ||
                  i.Reservation.Customer.LastName.ToLower().Contains(search))) ||
                (i.Reservation != null && i.Reservation.Room != null && 
                 i.Reservation.Room.RoomNumber.ToLower().Contains(search)));
        }

        var invoices = query
            .OrderByDescending(i => i.InvoiceDate)
            .ToList()
            .Select(i => new InvoiceGridItem
            {
                InvoiceId = i.InvoiceId,
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

        dgvInvoices.DataSource = invoices;

        if (dgvInvoices.Columns["InvoiceId"] is DataGridViewColumn idColumn)
            idColumn.Visible = false;

        // Update total amount
        var totalAmount = query
            .Where(i => i.Status != InvoiceStatus.Cancelled)
            .Sum(i => i.Amount);
        lblTotalAmount.Text = totalAmount.ToString("C2");
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

    private void TxtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadInvoices(txtSearch.Text);
    }

    private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadInvoices(txtSearch.Text);
    }

    private void DtpStartDate_ValueChanged(object sender, EventArgs e)
    {
        LoadInvoices(txtSearch.Text);
    }

    private void DtpEndDate_ValueChanged(object sender, EventArgs e)
    {
        LoadInvoices(txtSearch.Text);
    }

    private void DgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (dgvInvoices.Rows[e.RowIndex].Cells["InvoiceId"].Value is not int invoiceId) return;

        var invoice = _context.Invoices
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Customer)
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Room)
            .FirstOrDefault(i => i.InvoiceId == invoiceId);

        if (invoice == null) return;

        var form = new InvoiceViewForm(invoice);
        form.ShowDialog();

        if (form.DialogResult == DialogResult.OK)
        {
            LoadInvoices(txtSearch.Text);
        }
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        var form = new InvoiceAddEditForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            LoadInvoices(txtSearch.Text);
        }
    }

    private void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvInvoices.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir fatura seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (dgvInvoices.CurrentRow.Cells["InvoiceId"].Value is not int invoiceId) return;

        var invoice = _context.Invoices
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Customer)
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Room)
            .FirstOrDefault(i => i.InvoiceId == invoiceId);

        if (invoice == null) return;

        var form = new InvoiceAddEditForm(invoice);
        if (form.ShowDialog() == DialogResult.OK)
        {
            LoadInvoices(txtSearch.Text);
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvInvoices.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir fatura seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (dgvInvoices.CurrentRow.Cells["InvoiceId"].Value is not int invoiceId) return;

        var invoice = _context.Invoices.Find(invoiceId);

        if (invoice == null) return;

        if (invoice.Status == InvoiceStatus.Paid)
        {
            MessageBox.Show(
                "Ödenmiş faturalar silinemez.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show(
            "Faturayı silmek istediğinize emin misiniz?",
            "Onay",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
            LoadInvoices(txtSearch.Text);
        }
    }

    private void BtnPrint_Click(object sender, EventArgs e)
    {
        if (dgvInvoices.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir fatura seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (dgvInvoices.CurrentRow.Cells["InvoiceId"].Value is not int invoiceId) return;

        var invoice = _context.Invoices
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Customer)
            .Include(i => i.Reservation)
            .ThenInclude(r => r!.Room)
            .FirstOrDefault(i => i.InvoiceId == invoiceId);

        if (invoice == null) return;

        MessageBox.Show(
            "Fatura yazdırma özelliği henüz eklenmedi.",
            "Bilgi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
} 
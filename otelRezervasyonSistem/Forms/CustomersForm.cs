using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class CustomersForm : Form
{
    private readonly HotelDbContext _context;

    public CustomersForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        
        // Wire up events
        btnAdd.Click += BtnAdd_Click;
        btnEdit.Click += BtnEdit_Click;
        btnDelete.Click += BtnDelete_Click;
        txtSearch.TextChanged += TxtSearch_TextChanged;

        LoadCustomers();
    }

    private void LoadCustomers(string? searchText = null)
    {
        try
        {
            var query = _context.Customers
                .Include(c => c.Reservations)
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.ToLower();
                query = query.Where(c =>
                    EF.Functions.Like(c.FirstName.ToLower(), $"%{searchText}%") ||
                    EF.Functions.Like(c.LastName.ToLower(), $"%{searchText}%") ||
                    EF.Functions.Like(c.Phone, $"%{searchText}%") ||
                    EF.Functions.Like(c.Email.ToLower(), $"%{searchText}%"));
            }

            var customers = query.Select(c => new
            {
                c.CustomerId,
                c.FirstName,
                c.LastName,
                c.IdentityNumber,
                c.Email,
                c.Phone,
                c.Address,
                ReservationCount = c.Reservations.Count
            }).ToList();

            dgvCustomers.DataSource = customers;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Müşteri listesi yüklenirken bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadCustomers(txtSearch.Text);
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        var addForm = new CustomerAddEditForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadCustomers(txtSearch.Text);
        }
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        if (dgvCustomers.CurrentRow?.Cells["CustomerId"].Value is not int customerId)
        {
            MessageBox.Show(
                "Lütfen bir müşteri seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var customer = _context.Customers.Find(customerId);
        if (customer == null) return;

        var editForm = new CustomerAddEditForm(customer);
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            LoadCustomers(txtSearch.Text);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (dgvCustomers.CurrentRow?.Cells["CustomerId"].Value is not int customerId)
        {
            MessageBox.Show(
                "Lütfen bir müşteri seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var customer = _context.Customers
            .Include(c => c.Reservations)
            .FirstOrDefault(c => c.CustomerId == customerId);

        if (customer == null) return;

        if (customer.Reservations.Any())
        {
            MessageBox.Show(
                "Bu müşteriye ait rezervasyonlar olduğu için silinemez.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show(
            "Bu müşteriyi silmek istediğinizden emin misiniz?",
            "Müşteri Sil",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                LoadCustomers(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Müşteri silinirken bir hata oluştu: " + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

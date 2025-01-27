using Microsoft.EntityFrameworkCore;
using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class CustomerSelectForm : Form
{
    private readonly HotelDbContext _context;
    public Customer? SelectedCustomer { get; private set; }

    public CustomerSelectForm()
    {
        InitializeComponent();
        _context = Program.GetDbContext();

        LoadCustomers();

        txtSearch.TextChanged += TxtSearch_TextChanged;
        dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
    }

    private void LoadCustomers(string? searchText = null)
    {
        var query = _context.Customers.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            searchText = searchText.ToLower();
            query = query.Where(c =>
                c.FirstName.ToLower().Contains(searchText) ||
                c.LastName.ToLower().Contains(searchText) ||
                c.Phone.Contains(searchText) ||
                c.Email.ToLower().Contains(searchText));
        }

        var customers = query
            .OrderBy(c => c.LastName)
            .ThenBy(c => c.FirstName)
            .ToList();

        dgvCustomers.DataSource = customers.Select(c => new
        {
            c.CustomerId,
            Ad = c.FirstName,
            Soyad = c.LastName,
            Telefon = c.Phone,
            Email = c.Email
        }).ToList();

        if (dgvCustomers.Columns["CustomerId"] != null)
            dgvCustomers.Columns["CustomerId"].Visible = false;
    }

    private void TxtSearch_TextChanged(object? sender, EventArgs e)
    {
        LoadCustomers(txtSearch.Text);
    }

    private void DgvCustomers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var customerId = (int)dgvCustomers.Rows[e.RowIndex].Cells["CustomerId"].Value;
        SelectedCustomer = _context.Customers.Find(customerId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnSelect_Click(object sender, EventArgs e)
    {
        if (dgvCustomers.CurrentRow == null)
        {
            MessageBox.Show(
                "Lütfen bir müşteri seçiniz.",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var customerId = (int)dgvCustomers.CurrentRow.Cells["CustomerId"].Value;
        SelectedCustomer = _context.Customers.Find(customerId);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
} 
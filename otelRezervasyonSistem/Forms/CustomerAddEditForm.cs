using otelRezervasyonSistem.Data;
using otelRezervasyonSistem.Models;

namespace otelRezervasyonSistem.Forms;

public partial class CustomerAddEditForm : Form
{
    private readonly HotelDbContext _context;
    private readonly Customer? _customer;
    private readonly bool _isEdit;

    public CustomerAddEditForm(Customer? customer = null)
    {
        InitializeComponent();
        _context = Program.GetDbContext();
        _customer = customer;
        _isEdit = customer != null;

        if (_isEdit)
        {
            Text = "Müşteri Düzenle";
            btnSave.Text = "Güncelle";
            LoadCustomerData();
        }
        else
        {
            Text = "Yeni Müşteri";
            btnSave.Text = "Kaydet";
        }
    }

    private void LoadCustomerData()
    {
        if (_customer == null) return;

        txtFirstName.Text = _customer.FirstName;
        txtLastName.Text = _customer.LastName;
        txtIdentityNumber.Text = _customer.IdentityNumber;
        txtEmail.Text = _customer.Email;
        txtPhone.Text = _customer.Phone;
        txtAddress.Text = _customer.Address;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            if (_isEdit)
            {
                // Update existing customer
                _customer!.FirstName = txtFirstName.Text;
                _customer.LastName = txtLastName.Text;
                _customer.IdentityNumber = txtIdentityNumber.Text;
                _customer.Email = txtEmail.Text;
                _customer.Phone = txtPhone.Text;
                _customer.Address = txtAddress.Text;

                _context.Customers.Update(_customer);
            }
            else
            {
                // Create new customer
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    IdentityNumber = txtIdentityNumber.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    CreatedDate = DateTime.Now
                };

                _context.Customers.Add(customer);
            }

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Müşteri kaydedilirken bir hata oluştu: " + ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text))
        {
            MessageBox.Show("Lütfen adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFirstName.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtLastName.Text))
        {
            MessageBox.Show("Lütfen soyadı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtLastName.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtIdentityNumber.Text))
        {
            MessageBox.Show("Lütfen TC kimlik numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtIdentityNumber.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtPhone.Text))
        {
            MessageBox.Show("Lütfen telefon numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPhone.Focus();
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
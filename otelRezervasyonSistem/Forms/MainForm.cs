using System.Drawing.Drawing2D;
using otelRezervasyonSistem.Data;

namespace otelRezervasyonSistem.Forms;

public partial class MainForm : Form
{
    private Button? currentButton;
    private Form? _activeForm;
    private readonly Color themeColor = Color.FromArgb(51, 51, 76);
    private readonly Color activeColor = Color.FromArgb(72, 72, 108);

    public MainForm()
    {
        InitializeComponent();
        CustomizeDesign();

        // Initialize database
        using var context = Program.GetDbContext();
        context.Database.EnsureCreated();

        // Wire up events
        btnCustomers.Click += BtnCustomers_Click!;
        btnRooms.Click += BtnRooms_Click!;
        btnReservations.Click += BtnReservations_Click!;
        btnInvoices.Click += BtnInvoices_Click!;
        btnReports.Click += BtnReports_Click!;
    }

    private void CustomizeDesign()
    {
        this.Text = "Otel Rezervasyon Sistemi";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MinimumSize = new Size(1200, 800);
        
        // Configure the panel for buttons
        panelMenu.BackColor = themeColor;
        panelMenu.Dock = DockStyle.Left;
        panelMenu.Width = 220;

        // Configure the main panel
        panelContent.BackColor = Color.FromArgb(41, 41, 61);
        panelContent.Dock = DockStyle.Fill;

        // Configure buttons
        ConfigureButton(btnCustomers, "Müşteriler");
        ConfigureButton(btnRooms, "Odalar");
        ConfigureButton(btnReservations, "Rezervasyonlar");
        ConfigureButton(btnInvoices, "Faturalar");
        ConfigureButton(btnReports, "Raporlar");
    }

    private void ConfigureButton(Button button, string text)
    {
        button.Text = text;
        button.FlatStyle = FlatStyle.Flat;
        button.ForeColor = Color.Gainsboro;
        button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        button.TextAlign = ContentAlignment.MiddleLeft;
        button.Padding = new Padding(10, 0, 0, 0);
        button.Cursor = Cursors.Hand;
        button.FlatAppearance.BorderSize = 0;
    }

    private void ActivateButton(Button btnSender)
    {
        if (btnSender != null)
        {
            if (currentButton != null)
            {
                DisableButton();
            }
            currentButton = btnSender;
            currentButton.BackColor = activeColor;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
        }
    }

    private void DisableButton()
    {
        if (currentButton != null)
        {
            currentButton.BackColor = themeColor;
            currentButton.ForeColor = Color.Gainsboro;
            currentButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }
    }

    private void OpenChildForm(Form childForm)
    {
        _activeForm?.Close();
        _activeForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        panelContent.Controls.Add(childForm);
        panelContent.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
    }

    private void BtnCustomers_Click(object sender, EventArgs e)
    {
        OpenChildForm(new CustomersForm());
        ActivateButton(btnCustomers);
    }

    private void BtnRooms_Click(object sender, EventArgs e)
    {
        OpenChildForm(new RoomsForm());
        ActivateButton(btnRooms);
    }

    private void BtnReservations_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ReservationsForm());
        ActivateButton(btnReservations);
    }

    private void BtnInvoices_Click(object sender, EventArgs e)
    {
        OpenChildForm(new InvoicesForm());
        ActivateButton(btnInvoices);
    }

    private void BtnReports_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ReportsForm());
        ActivateButton(btnReports);
    }
} 
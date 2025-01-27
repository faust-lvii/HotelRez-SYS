namespace otelRezervasyonSistem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnReports = new Button();
            btnInvoices = new Button();
            btnReservations = new Button();
            btnRooms = new Button();
            btnCustomers = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(45, 45, 45);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnInvoices);
            panelMenu.Controls.Add(btnReservations);
            panelMenu.Controls.Add(btnRooms);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 661);
            panelMenu.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(50, 50, 50);
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 260);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 4;
            btnReports.Text = "Raporlar";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnInvoices
            // 
            btnInvoices.BackColor = Color.FromArgb(50, 50, 50);
            btnInvoices.Dock = DockStyle.Top;
            btnInvoices.FlatAppearance.BorderSize = 0;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvoices.ForeColor = Color.White;
            btnInvoices.Location = new Point(0, 210);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(200, 50);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "Faturalar";
            btnInvoices.UseVisualStyleBackColor = false;
            // 
            // btnReservations
            // 
            btnReservations.BackColor = Color.FromArgb(50, 50, 50);
            btnReservations.Dock = DockStyle.Top;
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservations.ForeColor = Color.White;
            btnReservations.Location = new Point(0, 160);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(200, 50);
            btnReservations.TabIndex = 2;
            btnReservations.Text = "Rezervasyonlar";
            btnReservations.UseVisualStyleBackColor = false;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(50, 50, 50);
            btnRooms.Dock = DockStyle.Top;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(0, 110);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(200, 50);
            btnRooms.TabIndex = 1;
            btnRooms.Text = "Odalar";
            btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(50, 50, 50);
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 60);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(200, 50);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 30, 30);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 60);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(200, 60);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Otel Rezervasyon\r\nSistemi";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(30, 30, 30);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(984, 661);
            panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1184, 661);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otel Rezervasyon Sistemi";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnReports;
        private Button btnInvoices;
        private Button btnReservations;
        private Button btnRooms;
        private Button btnCustomers;
        private Panel panelLogo;
        private Label lblLogo;
        private Panel panelContent;
    }
} 
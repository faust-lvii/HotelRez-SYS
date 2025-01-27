namespace otelRezervasyonSistem.Forms
{
    partial class InvoicesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnPrint = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            lblTotalAmount = new Label();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvInvoices = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 60);
            panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(50, 50, 50);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(318, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 35);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(50, 50, 50);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(212, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(50, 50, 50);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(106, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 123, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Yeni";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 45);
            panel2.Controls.Add(lblTotalAmount);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtpStartDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 60);
            panel2.TabIndex = 1;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalAmount.Location = new Point(784, 24);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(188, 23);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.Text = "₺0.00";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(784, 6);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 8;
            label5.Text = "Toplam Tutar:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(50, 50, 50);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(578, 24);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 29);
            cmbStatus.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(578, 6);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Durum:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarForeColor = Color.White;
            dtpEndDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpEndDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpEndDate.CalendarTitleForeColor = Color.White;
            dtpEndDate.CalendarTrailingForeColor = Color.Gray;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(472, 24);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(100, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(472, 6);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Bitiş Tarihi:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarForeColor = Color.White;
            dtpStartDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpStartDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpStartDate.CalendarTitleForeColor = Color.White;
            dtpStartDate.CalendarTrailingForeColor = Color.Gray;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(366, 24);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(100, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(366, 6);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(50, 50, 50);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(12, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Fatura no, müşteri adı veya oda numarası ile arama yapın...";
            txtSearch.Size = new Size(348, 29);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Ara:";
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvInvoices.BorderStyle = BorderStyle.None;
            dgvInvoices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoices.ColumnHeadersHeight = 40;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.GridColor = Color.FromArgb(45, 45, 45);
            dgvInvoices.Location = new Point(0, 120);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvInvoices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.RowTemplate.Height = 35;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(984, 442);
            dgvInvoices.TabIndex = 2;
            // 
            // InvoicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(984, 562);
            Controls.Add(dgvInvoices);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "InvoicesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Faturalar";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvInvoices;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private ComboBox cmbStatus;
        private Label label4;
        private Label lblTotalAmount;
        private Label label5;
    }
} 
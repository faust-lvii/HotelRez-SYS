namespace otelRezervasyonSistem.Forms
{
    partial class ReportsForm
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
            btnExport = new Button();
            panel2 = new Panel();
            lblSummary = new Label();
            cmbReportType = new ComboBox();
            label3 = new Label();
            dtpEndDate = new DateTimePicker();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            label1 = new Label();
            dgvReport = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnExport);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 60);
            panel1.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(50, 50, 50);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(872, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 35);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(0, 123, 255);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(766, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 35);
            btnExport.TabIndex = 0;
            btnExport.Text = "Dışa Aktar";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 45);
            panel2.Controls.Add(lblSummary);
            panel2.Controls.Add(cmbReportType);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpStartDate);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 60);
            panel2.TabIndex = 0;
            // 
            // lblSummary
            // 
            lblSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSummary.ForeColor = Color.White;
            lblSummary.Location = new Point(424, 24);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(548, 23);
            lblSummary.TabIndex = 6;
            lblSummary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.FromArgb(50, 50, 50);
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FlatStyle = FlatStyle.Flat;
            cmbReportType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbReportType.ForeColor = Color.White;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(12, 24);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(200, 29);
            cmbReportType.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 6);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Rapor Türü:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarForeColor = Color.White;
            dtpEndDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpEndDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpEndDate.CalendarTitleForeColor = Color.White;
            dtpEndDate.CalendarTrailingForeColor = Color.Gray;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(324, 24);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(100, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(324, 6);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarForeColor = Color.White;
            dtpStartDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpStartDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpStartDate.CalendarTitleForeColor = Color.White;
            dtpStartDate.CalendarTrailingForeColor = Color.Gray;
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(218, 24);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(100, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.ColumnHeadersHeight = 40;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(45, 45, 45);
            dgvReport.Location = new Point(0, 60);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.RowTemplate.Height = 35;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(984, 442);
            dgvReport.TabIndex = 1;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(984, 562);
            Controls.Add(dgvReport);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Raporlar";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPrint;
        private Button btnExport;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvReport;
        private DateTimePicker dtpEndDate;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private ComboBox cmbReportType;
        private Label label3;
        private Label lblSummary;
    }
} 
namespace otelRezervasyonSistem.Forms
{
    partial class InvoiceAddEditForm
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            txtNotes = new TextBox();
            label7 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            numAmount = new NumericUpDown();
            label5 = new Label();
            dtpDueDate = new DateTimePicker();
            label4 = new Label();
            dtpInvoiceDate = new DateTimePicker();
            label3 = new Label();
            txtInvoiceNumber = new TextBox();
            label2 = new Label();
            btnSelectReservation = new Button();
            txtReservation = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 60);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(50, 50, 50);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(472, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(366, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numAmount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpInvoiceDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInvoiceNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSelectReservation);
            groupBox1.Controls.Add(txtReservation);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 484);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fatura Bilgileri";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(50, 50, 50);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.ForeColor = Color.White;
            txtNotes.Location = new Point(6, 334);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(548, 144);
            txtNotes.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 316);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Notlar:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(50, 50, 50);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(6, 280);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 262);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 12;
            label6.Text = "Durum:";
            // 
            // numAmount
            // 
            numAmount.BackColor = Color.FromArgb(50, 50, 50);
            numAmount.BorderStyle = BorderStyle.FixedSingle;
            numAmount.DecimalPlaces = 2;
            numAmount.ForeColor = Color.White;
            numAmount.Location = new Point(6, 226);
            numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(200, 23);
            numAmount.TabIndex = 5;
            numAmount.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 208);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Tutar:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarForeColor = Color.White;
            dtpDueDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpDueDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpDueDate.CalendarTitleForeColor = Color.White;
            dtpDueDate.CalendarTrailingForeColor = Color.Gray;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(6, 172);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 154);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 8;
            label4.Text = "Son Ödeme Tarihi:";
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.CalendarForeColor = Color.White;
            dtpInvoiceDate.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpInvoiceDate.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpInvoiceDate.CalendarTitleForeColor = Color.White;
            dtpInvoiceDate.CalendarTrailingForeColor = Color.Gray;
            dtpInvoiceDate.Format = DateTimePickerFormat.Short;
            dtpInvoiceDate.Location = new Point(6, 118);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(200, 23);
            dtpInvoiceDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Fatura Tarihi:";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInvoiceNumber.BackColor = Color.FromArgb(50, 50, 50);
            txtInvoiceNumber.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceNumber.ForeColor = Color.White;
            txtInvoiceNumber.Location = new Point(6, 64);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(548, 23);
            txtInvoiceNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Fatura Numarası:";
            // 
            // btnSelectReservation
            // 
            btnSelectReservation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectReservation.BackColor = Color.FromArgb(50, 50, 50);
            btnSelectReservation.FlatAppearance.BorderSize = 0;
            btnSelectReservation.FlatStyle = FlatStyle.Flat;
            btnSelectReservation.Location = new Point(514, 22);
            btnSelectReservation.Name = "btnSelectReservation";
            btnSelectReservation.Size = new Size(40, 23);
            btnSelectReservation.TabIndex = 1;
            btnSelectReservation.Text = "...";
            btnSelectReservation.UseVisualStyleBackColor = false;
            btnSelectReservation.Click += BtnSelectReservation_Click;
            // 
            // txtReservation
            // 
            txtReservation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReservation.BackColor = Color.FromArgb(50, 50, 50);
            txtReservation.BorderStyle = BorderStyle.FixedSingle;
            txtReservation.ForeColor = Color.White;
            txtReservation.Location = new Point(6, 22);
            txtReservation.Name = "txtReservation";
            txtReservation.ReadOnly = true;
            txtReservation.Size = new Size(502, 23);
            txtReservation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Rezervasyon:";
            // 
            // InvoiceAddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(584, 562);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 600);
            Name = "InvoiceAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Fatura";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtReservation;
        private Button btnSelectReservation;
        private TextBox txtInvoiceNumber;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpInvoiceDate;
        private DateTimePicker dtpDueDate;
        private Label label4;
        private NumericUpDown numAmount;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
        private TextBox txtNotes;
        private Label label7;
    }
} 
namespace otelRezervasyonSistem.Forms
{
    partial class ReservationAddEditForm
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
            lblTotalPrice = new Label();
            label8 = new Label();
            txtNotes = new TextBox();
            label7 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            numGuests = new NumericUpDown();
            label5 = new Label();
            dtpCheckOut = new DateTimePicker();
            label4 = new Label();
            dtpCheckIn = new DateTimePicker();
            label3 = new Label();
            btnSelectRoom = new Button();
            txtRoom = new TextBox();
            label2 = new Label();
            btnSelectCustomer = new Button();
            txtCustomer = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
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
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numGuests);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpCheckOut);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpCheckIn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSelectRoom);
            groupBox1.Controls.Add(txtRoom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSelectCustomer);
            groupBox1.Controls.Add(txtCustomer);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 484);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon Bilgileri";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalPrice.Location = new Point(366, 280);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(188, 23);
            lblTotalPrice.TabIndex = 17;
            lblTotalPrice.Text = "₺0.00";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 262);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 16;
            label8.Text = "Toplam Ücret:";
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
            txtNotes.TabIndex = 8;
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
            cmbStatus.TabIndex = 7;
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
            // numGuests
            // 
            numGuests.BackColor = Color.FromArgb(50, 50, 50);
            numGuests.BorderStyle = BorderStyle.FixedSingle;
            numGuests.ForeColor = Color.White;
            numGuests.Location = new Point(6, 226);
            numGuests.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(200, 23);
            numGuests.TabIndex = 6;
            numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 208);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Kişi Sayısı:";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarForeColor = Color.White;
            dtpCheckOut.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpCheckOut.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpCheckOut.CalendarTitleForeColor = Color.White;
            dtpCheckOut.CalendarTrailingForeColor = Color.Gray;
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            dtpCheckOut.Location = new Point(6, 172);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(200, 23);
            dtpCheckOut.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 154);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Çıkış Tarihi:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarForeColor = Color.White;
            dtpCheckIn.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dtpCheckIn.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
            dtpCheckIn.CalendarTitleForeColor = Color.White;
            dtpCheckIn.CalendarTrailingForeColor = Color.Gray;
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Location = new Point(6, 118);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(200, 23);
            dtpCheckIn.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Giriş Tarihi:";
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectRoom.BackColor = Color.FromArgb(50, 50, 50);
            btnSelectRoom.FlatAppearance.BorderSize = 0;
            btnSelectRoom.FlatStyle = FlatStyle.Flat;
            btnSelectRoom.Location = new Point(514, 64);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(40, 23);
            btnSelectRoom.TabIndex = 3;
            btnSelectRoom.Text = "...";
            btnSelectRoom.UseVisualStyleBackColor = false;
            btnSelectRoom.Click += BtnSelectRoom_Click;
            // 
            // txtRoom
            // 
            txtRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRoom.BackColor = Color.FromArgb(50, 50, 50);
            txtRoom.BorderStyle = BorderStyle.FixedSingle;
            txtRoom.ForeColor = Color.White;
            txtRoom.Location = new Point(6, 64);
            txtRoom.Name = "txtRoom";
            txtRoom.ReadOnly = true;
            txtRoom.Size = new Size(502, 23);
            txtRoom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Oda:";
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectCustomer.BackColor = Color.FromArgb(50, 50, 50);
            btnSelectCustomer.FlatAppearance.BorderSize = 0;
            btnSelectCustomer.FlatStyle = FlatStyle.Flat;
            btnSelectCustomer.Location = new Point(514, 22);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(40, 23);
            btnSelectCustomer.TabIndex = 1;
            btnSelectCustomer.Text = "...";
            btnSelectCustomer.UseVisualStyleBackColor = false;
            btnSelectCustomer.Click += BtnSelectCustomer_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomer.BackColor = Color.FromArgb(50, 50, 50);
            txtCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtCustomer.ForeColor = Color.White;
            txtCustomer.Location = new Point(6, 22);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(502, 23);
            txtCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Müşteri:";
            // 
            // ReservationAddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(584, 562);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 600);
            Name = "ReservationAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Rezervasyon";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCustomer;
        private Button btnSelectCustomer;
        private Button btnSelectRoom;
        private TextBox txtRoom;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Label label4;
        private NumericUpDown numGuests;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
        private TextBox txtNotes;
        private Label label7;
        private Label lblTotalPrice;
        private Label label8;
    }
} 
namespace otelRezervasyonSistem.Forms
{
    partial class InvoiceViewForm
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
            btnClose = new Button();
            btnPrint = new Button();
            groupBox1 = new GroupBox();
            txtNotes = new TextBox();
            label6 = new Label();
            txtStatus = new TextBox();
            label5 = new Label();
            txtAmount = new TextBox();
            label4 = new Label();
            txtDueDate = new TextBox();
            label3 = new Label();
            txtInvoiceDate = new TextBox();
            label2 = new Label();
            txtInvoiceNumber = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtCustomerEmail = new TextBox();
            label9 = new Label();
            txtCustomerPhone = new TextBox();
            label8 = new Label();
            txtCustomerName = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            txtReservationStatus = new TextBox();
            label15 = new Label();
            txtGuests = new TextBox();
            label14 = new Label();
            txtCheckOut = new TextBox();
            label13 = new Label();
            txtCheckIn = new TextBox();
            label12 = new Label();
            txtRoomType = new TextBox();
            label11 = new Label();
            txtRoomNumber = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnPrint);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 60);
            panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(50, 50, 50);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(672, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(0, 123, 255);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(566, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 35);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += BtnPrint_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInvoiceDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtInvoiceNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 200);
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
            txtNotes.Location = new Point(6, 118);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(748, 76);
            txtNotes.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 100);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Notlar:";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(50, 50, 50);
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.ForeColor = Color.White;
            txtStatus.Location = new Point(424, 64);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(200, 23);
            txtStatus.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 46);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Durum:";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(50, 50, 50);
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.ForeColor = Color.White;
            txtAmount.Location = new Point(215, 64);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 46);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Tutar:";
            // 
            // txtDueDate
            // 
            txtDueDate.BackColor = Color.FromArgb(50, 50, 50);
            txtDueDate.BorderStyle = BorderStyle.FixedSingle;
            txtDueDate.ForeColor = Color.White;
            txtDueDate.Location = new Point(6, 64);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.ReadOnly = true;
            txtDueDate.Size = new Size(200, 23);
            txtDueDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Son Ödeme Tarihi:";
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.BackColor = Color.FromArgb(50, 50, 50);
            txtInvoiceDate.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceDate.ForeColor = Color.White;
            txtInvoiceDate.Location = new Point(424, 22);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.ReadOnly = true;
            txtInvoiceDate.Size = new Size(200, 23);
            txtInvoiceDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "Fatura Tarihi:";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.BackColor = Color.FromArgb(50, 50, 50);
            txtInvoiceNumber.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceNumber.ForeColor = Color.White;
            txtInvoiceNumber.Location = new Point(6, 22);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.ReadOnly = true;
            txtInvoiceNumber.Size = new Size(409, 23);
            txtInvoiceNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Fatura Numarası:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtCustomerEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCustomerPhone);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCustomerName);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerEmail.BackColor = Color.FromArgb(50, 50, 50);
            txtCustomerEmail.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerEmail.ForeColor = Color.White;
            txtCustomerEmail.Location = new Point(424, 64);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.ReadOnly = true;
            txtCustomerEmail.Size = new Size(330, 23);
            txtCustomerEmail.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 46);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 4;
            label9.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BackColor = Color.FromArgb(50, 50, 50);
            txtCustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPhone.ForeColor = Color.White;
            txtCustomerPhone.Location = new Point(6, 64);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.ReadOnly = true;
            txtCustomerPhone.Size = new Size(409, 23);
            txtCustomerPhone.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 46);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 2;
            label8.Text = "Telefon:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.BackColor = Color.FromArgb(50, 50, 50);
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.ForeColor = Color.White;
            txtCustomerName.Location = new Point(6, 22);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(748, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 0;
            label7.Text = "Müşteri Adı:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtReservationStatus);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtGuests);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtCheckOut);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtCheckIn);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtRoomType);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtRoomNumber);
            groupBox3.Controls.Add(label10);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 324);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(760, 172);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rezervasyon Bilgileri";
            // 
            // txtReservationStatus
            // 
            txtReservationStatus.BackColor = Color.FromArgb(50, 50, 50);
            txtReservationStatus.BorderStyle = BorderStyle.FixedSingle;
            txtReservationStatus.ForeColor = Color.White;
            txtReservationStatus.Location = new Point(424, 118);
            txtReservationStatus.Name = "txtReservationStatus";
            txtReservationStatus.ReadOnly = true;
            txtReservationStatus.Size = new Size(200, 23);
            txtReservationStatus.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(424, 100);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 10;
            label15.Text = "Durum:";
            // 
            // txtGuests
            // 
            txtGuests.BackColor = Color.FromArgb(50, 50, 50);
            txtGuests.BorderStyle = BorderStyle.FixedSingle;
            txtGuests.ForeColor = Color.White;
            txtGuests.Location = new Point(6, 118);
            txtGuests.Name = "txtGuests";
            txtGuests.ReadOnly = true;
            txtGuests.Size = new Size(200, 23);
            txtGuests.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 100);
            label14.Name = "label14";
            label14.Size = new Size(71, 15);
            label14.TabIndex = 8;
            label14.Text = "Kişi Sayısı:";
            // 
            // txtCheckOut
            // 
            txtCheckOut.BackColor = Color.FromArgb(50, 50, 50);
            txtCheckOut.BorderStyle = BorderStyle.FixedSingle;
            txtCheckOut.ForeColor = Color.White;
            txtCheckOut.Location = new Point(424, 64);
            txtCheckOut.Name = "txtCheckOut";
            txtCheckOut.ReadOnly = true;
            txtCheckOut.Size = new Size(200, 23);
            txtCheckOut.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(424, 46);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 6;
            label13.Text = "Çıkış Tarihi:";
            // 
            // txtCheckIn
            // 
            txtCheckIn.BackColor = Color.FromArgb(50, 50, 50);
            txtCheckIn.BorderStyle = BorderStyle.FixedSingle;
            txtCheckIn.ForeColor = Color.White;
            txtCheckIn.Location = new Point(215, 64);
            txtCheckIn.Name = "txtCheckIn";
            txtCheckIn.ReadOnly = true;
            txtCheckIn.Size = new Size(200, 23);
            txtCheckIn.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(215, 46);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 4;
            label12.Text = "Giriş Tarihi:";
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.FromArgb(50, 50, 50);
            txtRoomType.BorderStyle = BorderStyle.FixedSingle;
            txtRoomType.ForeColor = Color.White;
            txtRoomType.Location = new Point(215, 22);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ReadOnly = true;
            txtRoomType.Size = new Size(409, 23);
            txtRoomType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(215, 19);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 2;
            label11.Text = "Oda Tipi:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BackColor = Color.FromArgb(50, 50, 50);
            txtRoomNumber.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNumber.ForeColor = Color.White;
            txtRoomNumber.Location = new Point(6, 22);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(200, 23);
            txtRoomNumber.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 0;
            label10.Text = "Oda:";
            // 
            // InvoiceViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(784, 562);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 600);
            Name = "InvoiceViewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fatura Detayları";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button btnPrint;
        private GroupBox groupBox1;
        private TextBox txtNotes;
        private Label label6;
        private TextBox txtStatus;
        private Label label5;
        private TextBox txtAmount;
        private Label label4;
        private TextBox txtDueDate;
        private Label label3;
        private TextBox txtInvoiceDate;
        private Label label2;
        private TextBox txtInvoiceNumber;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtCustomerEmail;
        private Label label9;
        private TextBox txtCustomerPhone;
        private Label label8;
        private TextBox txtCustomerName;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtReservationStatus;
        private Label label15;
        private TextBox txtGuests;
        private Label label14;
        private TextBox txtCheckOut;
        private Label label13;
        private TextBox txtCheckIn;
        private Label label12;
        private TextBox txtRoomType;
        private Label label11;
        private TextBox txtRoomNumber;
        private Label label10;
    }
} 
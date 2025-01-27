namespace otelRezervasyonSistem.Forms
{
    partial class CustomerAddEditForm
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
            txtAddress = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtIdentityNumber = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 62);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(264, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(364, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdentityNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(23, 271);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(412, 84);
            txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 248);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 10;
            label6.Text = "Adres";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(23, 217);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(412, 27);
            txtPhone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 194);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(412, 27);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 140);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.Location = new Point(23, 109);
            txtIdentityNumber.MaxLength = 11;
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.Size = new Size(412, 27);
            txtIdentityNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 86);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "TC Kimlik No";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(229, 47);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(206, 27);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(23, 47);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 27);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // CustomerAddEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(482, 453);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Müşteri";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtIdentityNumber;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
    }
} 
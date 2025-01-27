namespace otelRezervasyonSistem.Forms
{
    partial class RoomAddEditForm
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
            numPrice = new NumericUpDown();
            label6 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label4 = new Label();
            numFloor = new NumericUpDown();
            label3 = new Label();
            cmbRoomType = new ComboBox();
            label2 = new Label();
            txtRoomNumber = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).BeginInit();
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
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numFloor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbRoomType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRoomNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oda Bilgileri";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(23, 217);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(412, 27);
            numPrice.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 194);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 10;
            label6.Text = "Fiyat:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 271);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(412, 84);
            txtDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 248);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Açıklama:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(23, 163);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(412, 28);
            cmbStatus.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 140);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Durum:";
            // 
            // numFloor
            // 
            numFloor.Location = new Point(229, 47);
            numFloor.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numFloor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFloor.Name = "numFloor";
            numFloor.Size = new Size(206, 27);
            numFloor.TabIndex = 1;
            numFloor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 24);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 4;
            label3.Text = "Kat:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(23, 109);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(412, 28);
            cmbRoomType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Oda Tipi:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(23, 47);
            txtRoomNumber.MaxLength = 10;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(200, 27);
            txtRoomNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Oda Numarası:";
            // 
            // RoomAddEditForm
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
            Name = "RoomAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Oda";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFloor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private GroupBox groupBox1;
        private NumericUpDown numPrice;
        private Label label6;
        private TextBox txtDescription;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label4;
        private NumericUpDown numFloor;
        private Label label3;
        private ComboBox cmbRoomType;
        private Label label2;
        private TextBox txtRoomNumber;
        private Label label1;
    }
} 
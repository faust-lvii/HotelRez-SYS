namespace otelRezervasyonSistem.Forms
{
    partial class ReservationsForm
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
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            cmbStatus = new ComboBox();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvReservations = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 60);
            panel1.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(607, 17);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(125, 27);
            dtpEndDate.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(559, 20);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Bitiş:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(428, 17);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(125, 27);
            dtpStartDate.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(336, 20);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 8;
            label2.Text = "Başlangıç:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(738, 16);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(895, 15);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 29);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(995, 15);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(94, 29);
            btnCheckIn.TabIndex = 5;
            btnCheckIn.Text = "Check-in";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1095, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(795, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(695, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Ara:";
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(0, 60);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(1200, 590);
            dgvReservations.TabIndex = 1;
            // 
            // ReservationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(dgvReservations);
            Controls.Add(panel1);
            Name = "ReservationsForm";
            Text = "Rezervasyonlar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvReservations;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private ComboBox cmbStatus;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private Label label2;
    }
} 
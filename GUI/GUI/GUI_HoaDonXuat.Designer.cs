namespace GUI
{
    partial class GUI_HoaDonXuat
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoTKMNV = new System.Windows.Forms.RadioButton();
            this.rdoTKMHDB = new System.Windows.Forms.RadioButton();
            this.txtTKHDB = new System.Windows.Forms.TextBox();
            this.btnTKHDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChitietHDB = new System.Windows.Forms.Button();
            this.dateNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(963, 566);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 46);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoa.Location = new System.Drawing.Point(429, 566);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 46);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Info;
            this.btnSua.Location = new System.Drawing.Point(256, 566);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 46);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Info;
            this.btnThem.Location = new System.Drawing.Point(80, 566);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 46);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHDB
            // 
            this.dgvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Location = new System.Drawing.Point(14, 308);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 62;
            this.dgvHDB.RowTemplate.Height = 28;
            this.dgvHDB.Size = new System.Drawing.Size(1072, 242);
            this.dgvHDB.TabIndex = 27;
            this.dgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.rdoTKMNV);
            this.groupBox2.Controls.Add(this.rdoTKMHDB);
            this.groupBox2.Controls.Add(this.txtTKHDB);
            this.groupBox2.Controls.Add(this.btnTKHDB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(701, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 290);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm hóa đơn xuất";
            // 
            // rdoTKMNV
            // 
            this.rdoTKMNV.AutoSize = true;
            this.rdoTKMNV.Location = new System.Drawing.Point(212, 133);
            this.rdoTKMNV.Name = "rdoTKMNV";
            this.rdoTKMNV.Size = new System.Drawing.Size(128, 24);
            this.rdoTKMNV.TabIndex = 12;
            this.rdoTKMNV.TabStop = true;
            this.rdoTKMNV.Text = "Mã nhân viên";
            this.rdoTKMNV.UseVisualStyleBackColor = true;
            // 
            // rdoTKMHDB
            // 
            this.rdoTKMHDB.AutoSize = true;
            this.rdoTKMHDB.Location = new System.Drawing.Point(62, 132);
            this.rdoTKMHDB.Name = "rdoTKMHDB";
            this.rdoTKMHDB.Size = new System.Drawing.Size(95, 24);
            this.rdoTKMHDB.TabIndex = 11;
            this.rdoTKMHDB.TabStop = true;
            this.rdoTKMHDB.Text = "Mã HDX";
            this.rdoTKMHDB.UseVisualStyleBackColor = true;
            // 
            // txtTKHDB
            // 
            this.txtTKHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTKHDB.Location = new System.Drawing.Point(174, 55);
            this.txtTKHDB.Name = "txtTKHDB";
            this.txtTKHDB.Size = new System.Drawing.Size(183, 26);
            this.txtTKHDB.TabIndex = 10;
            // 
            // btnTKHDB
            // 
            this.btnTKHDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnTKHDB.ForeColor = System.Drawing.Color.White;
            this.btnTKHDB.Location = new System.Drawing.Point(134, 220);
            this.btnTKHDB.Name = "btnTKHDB";
            this.btnTKHDB.Size = new System.Drawing.Size(168, 50);
            this.btnTKHDB.TabIndex = 9;
            this.btnTKHDB.Text = "Tìm kiếm";
            this.btnTKHDB.UseVisualStyleBackColor = false;
            this.btnTKHDB.Click += new System.EventHandler(this.btnTKHDB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnChitietHDB);
            this.groupBox1.Controls.Add(this.dateNgayBan);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaHDB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 290);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn xuất";
            // 
            // btnChitietHDB
            // 
            this.btnChitietHDB.BackColor = System.Drawing.Color.MistyRose;
            this.btnChitietHDB.Location = new System.Drawing.Point(218, 220);
            this.btnChitietHDB.Name = "btnChitietHDB";
            this.btnChitietHDB.Size = new System.Drawing.Size(214, 50);
            this.btnChitietHDB.TabIndex = 8;
            this.btnChitietHDB.Text = "Chi tiết hóa đơn nhập";
            this.btnChitietHDB.UseVisualStyleBackColor = false;
            this.btnChitietHDB.Click += new System.EventHandler(this.btnChitietHDB_Click);
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBan.Location = new System.Drawing.Point(468, 145);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(200, 26);
            this.dateNgayBan.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Location = new System.Drawing.Point(468, 58);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 26);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Location = new System.Drawing.Point(138, 147);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(113, 26);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHDB.Location = new System.Drawing.Point(138, 58);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(113, 26);
            this.txtMaHDB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HDX";
            // 
            // GUI_HoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1108, 626);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHDB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_HoaDonXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HoaDonXuat";
            this.Load += new System.EventHandler(this.GUI_HoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTKMNV;
        private System.Windows.Forms.RadioButton rdoTKMHDB;
        private System.Windows.Forms.TextBox txtTKHDB;
        private System.Windows.Forms.Button btnTKHDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChitietHDB;
        private System.Windows.Forms.DateTimePicker dateNgayBan;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
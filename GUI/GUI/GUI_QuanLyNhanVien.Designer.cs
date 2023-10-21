namespace GUI
{
    partial class GUI_QuanLyNhanVien
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
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.rdoTenNV = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTKNV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGT = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.dtNSNV = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMKNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(876, 556);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 46);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaNV.Location = new System.Drawing.Point(429, 556);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(85, 46);
            this.btnXoaNV.TabIndex = 19;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.SystemColors.Info;
            this.btnSuanv.Location = new System.Drawing.Point(262, 556);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(76, 46);
            this.btnSuanv.TabIndex = 18;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.Info;
            this.btnThemNV.Location = new System.Drawing.Point(75, 556);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(91, 46);
            this.btnThemNV.TabIndex = 17;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(12, 293);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 62;
            this.dgvQLNV.RowTemplate.Height = 28;
            this.dgvQLNV.Size = new System.Drawing.Size(1014, 245);
            this.dgvQLNV.TabIndex = 16;
            this.dgvQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNV_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnTKNV);
            this.groupBox2.Controls.Add(this.rdoTenNV);
            this.groupBox2.Controls.Add(this.rdoMaNV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTKNV);
            this.groupBox2.Location = new System.Drawing.Point(642, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 275);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhân viên";
            // 
            // btnTKNV
            // 
            this.btnTKNV.BackColor = System.Drawing.Color.IndianRed;
            this.btnTKNV.ForeColor = System.Drawing.Color.White;
            this.btnTKNV.Location = new System.Drawing.Point(151, 214);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(121, 41);
            this.btnTKNV.TabIndex = 4;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.UseVisualStyleBackColor = false;
            this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
            // 
            // rdoTenNV
            // 
            this.rdoTenNV.AutoSize = true;
            this.rdoTenNV.Location = new System.Drawing.Point(217, 139);
            this.rdoTenNV.Name = "rdoTenNV";
            this.rdoTenNV.Size = new System.Drawing.Size(133, 24);
            this.rdoTenNV.TabIndex = 3;
            this.rdoTenNV.TabStop = true;
            this.rdoTenNV.Text = "Tên nhân viên";
            this.rdoTenNV.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Location = new System.Drawing.Point(27, 137);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(128, 24);
            this.rdoMaNV.TabIndex = 2;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã nhân viên";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtTKNV
            // 
            this.txtTKNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTKNV.Location = new System.Drawing.Point(173, 51);
            this.txtTKNV.Name = "txtTKNV";
            this.txtTKNV.Size = new System.Drawing.Size(158, 26);
            this.txtTKNV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.cboGT);
            this.groupBox1.Controls.Add(this.cboCV);
            this.groupBox1.Controls.Add(this.dtNSNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMKNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboGT
            // 
            this.cboGT.FormattingEnabled = true;
            this.cboGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGT.Location = new System.Drawing.Point(451, 193);
            this.cboGT.Name = "cboGT";
            this.cboGT.Size = new System.Drawing.Size(132, 28);
            this.cboGT.TabIndex = 14;
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cboCV.Location = new System.Drawing.Point(451, 35);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(132, 28);
            this.cboCV.TabIndex = 13;
            // 
            // dtNSNV
            // 
            this.dtNSNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNSNV.Location = new System.Drawing.Point(451, 106);
            this.dtNSNV.Name = "dtNSNV";
            this.dtNSNV.Size = new System.Drawing.Size(132, 26);
            this.dtNSNV.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày sinh";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDTNV.Location = new System.Drawing.Point(120, 221);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(167, 26);
            this.txtSDTNV.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "SĐT";
            // 
            // txtMKNV
            // 
            this.txtMKNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKNV.Location = new System.Drawing.Point(120, 161);
            this.txtMKNV.Name = "txtMKNV";
            this.txtMKNV.Size = new System.Drawing.Size(167, 26);
            this.txtMKNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Location = new System.Drawing.Point(120, 100);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(167, 26);
            this.txtTenNV.TabIndex = 6;
            // 
            // txtManv
            // 
            this.txtManv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManv.Location = new System.Drawing.Point(120, 45);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(167, 26);
            this.txtManv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // GUI_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1042, 614);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuanv);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLyNhanVien";
            this.Load += new System.EventHandler(this.GUI_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.RadioButton rdoTenNV;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGT;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.DateTimePicker dtNSNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMKNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
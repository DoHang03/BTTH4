namespace GUI
{
    partial class GUI_NhaCC
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
            this.btnThoatNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTKNCC = new System.Windows.Forms.Button();
            this.rdoTenNCC = new System.Windows.Forms.RadioButton();
            this.rdoMaNCC = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTKNCC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDCNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoatNCC
            // 
            this.btnThoatNCC.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoatNCC.ForeColor = System.Drawing.Color.White;
            this.btnThoatNCC.Location = new System.Drawing.Point(818, 534);
            this.btnThoatNCC.Name = "btnThoatNCC";
            this.btnThoatNCC.Size = new System.Drawing.Size(122, 51);
            this.btnThoatNCC.TabIndex = 34;
            this.btnThoatNCC.Text = "Thoát";
            this.btnThoatNCC.UseVisualStyleBackColor = false;
            this.btnThoatNCC.Click += new System.EventHandler(this.btnThoatNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaNCC.Location = new System.Drawing.Point(364, 528);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(85, 46);
            this.btnXoaNCC.TabIndex = 33;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.BackColor = System.Drawing.SystemColors.Info;
            this.btnSuaNCC.Location = new System.Drawing.Point(196, 528);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(76, 46);
            this.btnSuaNCC.TabIndex = 32;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = false;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.SystemColors.Info;
            this.btnThemNCC.Location = new System.Drawing.Point(37, 528);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(91, 46);
            this.btnThemNCC.TabIndex = 31;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(12, 304);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 62;
            this.dgvNCC.RowTemplate.Height = 28;
            this.dgvNCC.Size = new System.Drawing.Size(986, 218);
            this.dgvNCC.TabIndex = 30;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnTKNCC);
            this.groupBox2.Controls.Add(this.rdoTenNCC);
            this.groupBox2.Controls.Add(this.rdoMaNCC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTKNCC);
            this.groupBox2.Location = new System.Drawing.Point(641, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 275);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm sản phẩm";
            // 
            // btnTKNCC
            // 
            this.btnTKNCC.BackColor = System.Drawing.Color.IndianRed;
            this.btnTKNCC.ForeColor = System.Drawing.Color.White;
            this.btnTKNCC.Location = new System.Drawing.Point(157, 216);
            this.btnTKNCC.Name = "btnTKNCC";
            this.btnTKNCC.Size = new System.Drawing.Size(124, 42);
            this.btnTKNCC.TabIndex = 4;
            this.btnTKNCC.Text = "Tìm kiếm";
            this.btnTKNCC.UseVisualStyleBackColor = false;
            this.btnTKNCC.Click += new System.EventHandler(this.btnTKNCC_Click);
            // 
            // rdoTenNCC
            // 
            this.rdoTenNCC.AutoSize = true;
            this.rdoTenNCC.Location = new System.Drawing.Point(189, 137);
            this.rdoTenNCC.Name = "rdoTenNCC";
            this.rdoTenNCC.Size = new System.Drawing.Size(161, 24);
            this.rdoTenNCC.TabIndex = 3;
            this.rdoTenNCC.TabStop = true;
            this.rdoTenNCC.Text = "Tên nhà cung cấp";
            this.rdoTenNCC.UseVisualStyleBackColor = true;
            // 
            // rdoMaNCC
            // 
            this.rdoMaNCC.AutoSize = true;
            this.rdoMaNCC.Location = new System.Drawing.Point(27, 137);
            this.rdoMaNCC.Name = "rdoMaNCC";
            this.rdoMaNCC.Size = new System.Drawing.Size(156, 24);
            this.rdoMaNCC.TabIndex = 2;
            this.rdoMaNCC.TabStop = true;
            this.rdoMaNCC.Text = "Mã nhà cung cấp";
            this.rdoMaNCC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtTKNCC
            // 
            this.txtTKNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTKNCC.Location = new System.Drawing.Point(157, 49);
            this.txtTKNCC.Name = "txtTKNCC";
            this.txtTKNCC.Size = new System.Drawing.Size(158, 26);
            this.txtTKNCC.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txtSDTNCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDCNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 275);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDTNCC.Location = new System.Drawing.Point(221, 170);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(368, 26);
            this.txtSDTNCC.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số điện thoại";
            // 
            // txtDCNCC
            // 
            this.txtDCNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDCNCC.Location = new System.Drawing.Point(221, 232);
            this.txtDCNCC.Name = "txtDCNCC";
            this.txtDCNCC.Size = new System.Drawing.Size(368, 26);
            this.txtDCNCC.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNCC.Location = new System.Drawing.Point(221, 106);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(368, 26);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNCC.Location = new System.Drawing.Point(221, 51);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(368, 26);
            this.txtMaNCC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // GUI_NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1012, 610);
            this.Controls.Add(this.btnThoatNCC);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnSuaNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_NhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NhaCC";
            this.Load += new System.EventHandler(this.GUI_NhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoatNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTKNCC;
        private System.Windows.Forms.RadioButton rdoTenNCC;
        private System.Windows.Forms.RadioButton rdoMaNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTKNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDCNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
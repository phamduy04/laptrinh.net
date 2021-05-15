namespace qlysach
{
    partial class frmSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.cboTenNXB = new System.Windows.Forms.ComboBox();
            this.cboTenTG = new System.Windows.Forms.ComboBox();
            this.datimeNamxb = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm xb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.cboTenNXB);
            this.groupBox1.Controls.Add(this.cboTenTG);
            this.groupBox1.Controls.Add(this.datimeNamxb);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(647, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(638, 199);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(412, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(412, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(412, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(412, 39);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 5;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // cboTenNXB
            // 
            this.cboTenNXB.FormattingEnabled = true;
            this.cboTenNXB.Location = new System.Drawing.Point(161, 283);
            this.cboTenNXB.Name = "cboTenNXB";
            this.cboTenNXB.Size = new System.Drawing.Size(164, 21);
            this.cboTenNXB.TabIndex = 4;
            // 
            // cboTenTG
            // 
            this.cboTenTG.FormattingEnabled = true;
            this.cboTenTG.Location = new System.Drawing.Point(161, 243);
            this.cboTenTG.Name = "cboTenTG";
            this.cboTenTG.Size = new System.Drawing.Size(121, 21);
            this.cboTenTG.TabIndex = 4;
            // 
            // datimeNamxb
            // 
            this.datimeNamxb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datimeNamxb.Location = new System.Drawing.Point(161, 124);
            this.datimeNamxb.Name = "datimeNamxb";
            this.datimeNamxb.Size = new System.Drawing.Size(142, 20);
            this.datimeNamxb.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(161, 201);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(109, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(161, 162);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(72, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(161, 39);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(121, 20);
            this.txtMaSach.TabIndex = 2;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(161, 82);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(164, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(494, 201);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(109, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên nxb:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên tg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá:";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Namxb,
            this.Soluong,
            this.Dongia,
            this.Matg,
            this.Manxb});
            this.dgvSach.Location = new System.Drawing.Point(26, 397);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(752, 150);
            this.dgvSach.TabIndex = 3;
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "Masach";
            this.Masach.HeaderText = "ma sach";
            this.Masach.Name = "Masach";
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "ten sach";
            this.Tensach.Name = "Tensach";
            // 
            // Namxb
            // 
            this.Namxb.DataPropertyName = "Namxb";
            this.Namxb.HeaderText = "nam xb";
            this.Namxb.Name = "Namxb";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "so luong";
            this.Soluong.Name = "Soluong";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "don gia";
            this.Dongia.Name = "Dongia";
            // 
            // Matg
            // 
            this.Matg.DataPropertyName = "Matg";
            this.Matg.HeaderText = "matg";
            this.Matg.Name = "Matg";
            // 
            // Manxb
            // 
            this.Manxb.DataPropertyName = "Manxb";
            this.Manxb.HeaderText = "ma nxb";
            this.Manxb.Name = "Manxb";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSach";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.ComboBox cboTenNXB;
        private System.Windows.Forms.ComboBox cboTenTG;
        private System.Windows.Forms.DateTimePicker datimeNamxb;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manxb;
        private System.Windows.Forms.TextBox txtMaSach;
    }
}


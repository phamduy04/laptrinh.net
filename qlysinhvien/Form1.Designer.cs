namespace qlysinhvien
{
    partial class frmSinhVien
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
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search ID :";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(134, 68);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(120, 20);
            this.txtMalop.TabIndex = 2;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(134, 111);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(120, 20);
            this.txtTenlop.TabIndex = 2;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(134, 149);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(120, 20);
            this.txtPhong.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(347, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(347, 76);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 3;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(347, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(347, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(542, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(688, 73);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(688, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.Tenlop,
            this.Phong});
            this.dgvSinhVien.Location = new System.Drawing.Point(174, 234);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(488, 204);
            this.dgvSinhVien.TabIndex = 4;
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "malop";
            this.Malop.Name = "Malop";
            this.Malop.Width = 150;
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "tenlop";
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Width = 150;
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "Phong";
            this.Phong.HeaderText = "phong";
            this.Phong.Name = "Phong";
            this.Phong.Width = 150;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "quản lý";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
    }
}


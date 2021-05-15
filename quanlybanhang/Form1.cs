using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace quanlybanhang
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstring = "Data Source=PHAMDUY-PC;Initial Catalog=QLBH;Integrated Security=True";

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Focus();
            LayDuLieuDataGridView();
            LAYDuLieuTenHang();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select*from SanPham";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSanPham.DataSource = dt;
        }

        private void LAYDuLieuTenHang()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = " select MaHang, TenHang from HangSX";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenHang.DataSource = dt;
            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtMauSac.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            LAYDuLieuTenHang();
            txtMaSP.Focus();
        }
        // them moi //
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtGiaBan.Text ==""||txtMauSac.Text==""||
                txtSoLuong.Text=="" || txtTenSP.Text=="" ||cboTenHang.Text=="")
            {
                MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
            }

            else
            {
                ThemMoiSanPham();
                LayDuLieuDataGridView();
            }
        }

        private void ThemMoiSanPham()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strInsert = "insert into SanPham values('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtMauSac.Text + "','" + txtSoLuong.Text + "','" + txtGiaBan.Text + "',N'" +cboTenHang.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }


        }
        // sua //
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraMasp(Convert.ToString(txtMaSP.Text)) == false)
            {
                MessageBox.Show("không có mã sp này!", "thông báo");
            }
            else
            {
                if (txtMaSP.Text == "" || txtGiaBan.Text == "" || txtMauSac.Text == "" ||
                txtSoLuong.Text == "" || txtTenSP.Text == "" || cboTenHang.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
                }
                else
                {
                    SuaSanPham();
                    LayDuLieuDataGridView();
                }
            }  
        }

        private bool KiemTraMasp(string masp)
        {
            
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql="select * from SanPham where MaSP='{masp}'";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
              return true;
            else
                return false;
                          
        }

        private void SuaSanPham()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strUpdate = "Update SanPham set MaHang='" + cboTenHang.SelectedValue + "',TenSP=N'" + txtTenSP.Text + "' ,MaSac=N'" + txtMauSac.Text + "' ,Soluong= '" + txtSoLuong.Text + "' ,GiaBan='" + txtGiaBan.Text + "' where Masp='" + txtMaSP.Text + "'";
                SqlCommand cmd = new SqlCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }
        // xóa //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strDelete = "Delete from SanPham where MaSP='"+txtMaSP.Text+"'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }

    }
}

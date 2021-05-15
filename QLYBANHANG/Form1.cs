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
namespace QLYBANHANG
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connsrt = "Data Source=PHAMDUY-PC;Initial Catalog=quanlybanhang;Integrated Security=True";

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Focus();
            LayDuLieuDataGridView();
            LayDuLieuTenHang();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connsrt);
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

        private void LayDuLieuTenHang()
        {
            conn = new SqlConnection(connsrt);
            conn.Open();
           string sql = "select MaHang , TenHang from HangSX";
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
            txtGiaBan.Clear();
            txtMaSP.Clear();
            txtMauSac.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();
            txtMaSP.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text==""||txtGiaBan.Text==""||txtMauSac.Text==""||
                txtSoLuong.Text == "" || txtTenSP.Text == "" || cboTenHang.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu thông tin", "thông báo");
            }
            else
            {
                LayDuLieuDataGridView();
                ThemSanPham();
            }
        }

        private void ThemSanPham()
        {
            try
            {
                conn = new SqlConnection(connsrt);
                conn.Open();
                string strInsert =  $"insert into SanPham values('{txtMaSP.Text}',N'{txtTenSP.Text}',N'{txtMauSac.Text}',{txtSoLuong.Text},{txtGiaBan.Text},N'{cboTenHang.SelectedValue}')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu", "thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkMaSP(txtMaSP.Text) == false)
            {
                MessageBox.Show("không có tên hàng đấy", "thông báo");
            }
            else
            {
                if (txtMaSP.Text == "" || txtGiaBan.Text == "" || txtMauSac.Text == "" ||
                txtSoLuong.Text == "" || txtTenSP.Text == "" || cboTenHang.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin", "thông báo");
                }
                else
                {
                    LayDuLieuDataGridView();
                    SuaSanPham();
                }
            }

        }

        private bool checkMaSP(string masp)
        {
            bool ktra = false;
            conn = new SqlConnection(connsrt);
            conn.Open();
            string sql = $"select *from SanPham where MaSP='{masp}'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
                ktra = false;
            else
                ktra = true;
            return ktra;
        }

        private void SuaSanPham()
        {
            try
            {
                conn = new SqlConnection(connsrt);
                conn.Open();
                string strUpdate = $"update SanPham set TenSP=N'{txtTenSP.Text}',MauSac=N'{txtMauSac.Text}',SoLuong={txtSoLuong.Text},GiaBan='{txtGiaBan.Text}',MaHang='{cboTenHang.SelectedValue}'where MaSP='{txtMaSP.Text}'";
                SqlCommand cmd = new SqlCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
             catch
            {
                MessageBox.Show("có lỗi nhập liệu", "thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMaSP(txtMaSP.Text) == false)
            {
                MessageBox.Show("không có tên hàng đấy", "thông báo");
            }
            else
            {
                XoaSanPham();
                LayDuLieuDataGridView();
            }
        }
          
        private void XoaSanPham()
        {

            try
            {
                conn = new SqlConnection(connsrt);
                conn.Open();
                string strDelete = $"delete from SanPham where MaSP='{txtMaSP.Text}'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu", "thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát hay không?", "question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

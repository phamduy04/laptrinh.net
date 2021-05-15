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
namespace qly_BH
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstr = "Data Source=PHAMDUY-PC;Initial Catalog=qly_ban_hang;Integrated Security=True";

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSP.Focus();
            LayDuLieuDataGridView();
            LayDuLieuTenHang();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = " select*from SanPham";
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
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = "select MaSP,TenSP from SanPham";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenHang.DataSource = dt;
            cboTenHang.DisplayMember = "TenSP";
            cboTenHang.ValueMember = "MaSP";
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtGiaBan.Clear();
            txtMaSP.Clear();
            txtMauSac.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtGiaBan.Text==""|| txtMaSP.Text==""|| txtMauSac.Text==""||
                txtSoLuong.Text == "" || txtTenSP.Text == "" || cboTenHang.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu thông tin", "thông báo");
            }
            else
            {
                ThemSanPham();
                LayDuLieuDataGridView();
            }    
        }

        private void ThemSanPham()
        {
            //try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strInsert = "insert into SanPham values('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtMauSac.Text + "','" + txtSoLuong.Text + "','" + txtGiaBan.Text + "',N'" + cboTenHang.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            //catch
            {
            //    MessageBox.Show("có lỗi nhập liệu", "thông báo");
            }
        }
    }
}

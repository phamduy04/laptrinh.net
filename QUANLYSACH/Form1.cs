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
namespace QUANLYSACH
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstr = "Data Source=PHAMDUY-PC;Initial Catalog=quanlysach;Integrated Security=True";
        private void frmSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Focus();
            LayDuLieuDataGridView();
            LayDuLieuTenTG();
            LayDuLieuTenNXB();
            
        }

         private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstr);
            conn.Open(); ;
            string sql = "select*from Sach";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSach.DataSource = dt;
        }

        private void LayDuLieuTenTG()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = "select MaTG,TenTG from tacgia";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenTG.DataSource = dt;
            cboTenTG.DisplayMember = "TenTG";
            cboTenTG.ValueMember = "MaTG";
        }

        private void LayDuLieuTenNXB()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = "select MaNXB,TenNXB from nhaxuatban";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenNXB.DataSource = dt;
            cboTenNXB.DisplayMember = "TenNXB";
           cboTenNXB.ValueMember = "MaNXB";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtMaSach.Clear();
            txtSoLuong.Clear();
            txtTenSach.Clear();
            txtMaSach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text==""||txtMaSach.Text==""||txtSoLuong.Text==""||txtTenSach.Text==""||
                cboTenNXB.Text == "" || cboTenTG.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
            }
            else
            {
                ThemSach();
                LayDuLieuDataGridView();
            }
        }

        private void ThemSach()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strInsert = $"insert into Sach values('{txtMaSach.Text}',N'{txtTenSach.Text}','{dateTimeNamXB.Value}',{txtSoLuong.Text},{txtDonGia.Text},N'{cboTenTG.SelectedValue}',N'{cboTenNXB.SelectedValue}')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery(); ;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu.", "thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkMaSach(txtMaSach.Text) == false)
            {
                MessageBox.Show("không có tên sách đó.", "thông báo");
            }
            else
            {
                if (txtDonGia.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "" || txtTenSach.Text == "" ||
                cboTenNXB.Text == "" || cboTenTG.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
                }
                else
                {
                    SuaSach();
                    LayDuLieuDataGridView();
                }
            }
        }

        private bool checkMaSach(string masach)
        {
            bool ktra = false;
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $"select*from Sach where MaSach='{masach}'";
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

        private void SuaSach()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strUpdate = $"update Sach set TenSach=N'{txtTenSach.Text}',NamXB='{dateTimeNamXB.Value}',SoLuong='{txtSoLuong.Text}',DonGia='{txtDonGia.Text}',MaTG=N'{cboTenTG.SelectedValue}',MaNXB=N'{cboTenNXB.SelectedValue}' where MaSach='{txtMaSach.Text}'";
                SqlCommand cmd = new SqlCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu.", "thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMaSach(txtMaSach.Text) == false)
            {
                MessageBox.Show("không có tên sách đó.", "thông báo");
            }
            else
            {
                XoaSach();
                LayDuLieuDataGridView();
            }
        }

        private void XoaSach()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strDelete = $"Delete from Sach  where MaSach='{txtMaSach.Text}'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                     
            }
           catch
            {
                MessageBox.Show("có lỗi nhập liệu.", "thông báo");
            }
        }
    }
}

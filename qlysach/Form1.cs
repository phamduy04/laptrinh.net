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

namespace qlysach
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstr = "Data Source=PHAMDUY-PC;Initial Catalog=qlysach;Integrated Security=True";

        private void frmSach_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            txtMaSach.Focus();
            LayDuLieuTenTG();
            LayDuLieuTenNXB();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = "select*from sach";
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
            string sql_tentg = "select Matg,TenTG from  tacgia";
            SqlCommand com = new SqlCommand(sql_tentg, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenTG.DataSource = dt;
            cboTenTG.DisplayMember = "Tentg";
            cboTenTG.ValueMember = "Matg";
        }

        private void LayDuLieuTenNXB()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql_tennxb = "select Manxb,Tennxb from  nhaxuatban";
            SqlCommand com = new SqlCommand(sql_tennxb, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenNXB.DataSource = dt;
            cboTenNXB.DisplayMember = "Tennxb";
            cboTenNXB.ValueMember = "Manxb";
        }
        // nhập lại //
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtMaSach.Clear();
            txtSoLuong.Clear();
            txtTenSach.Clear();
          
            txtMaSach.Focus();
        }
        // thêm //
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "" ||
                txtTenSach.Text == "" || cboTenNXB.Text == "" || datimeNamxb.Text == "" || cboTenTG.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
            }
            else
            {
                ThemMoiSach();
                LayDuLieuDataGridView();
            }
        }

        private void ThemMoiSach()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strInsert = $"insert into sach values('{txtMaSach.Text}',N'{txtTenSach.Text}','{datimeNamxb.Value}',{txtSoLuong.Text},{txtDonGia.Text},'{cboTenTG.SelectedValue}','{cboTenNXB.SelectedValue}')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }
        // sửa //

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkMaSach(txtMaSach.Text) == false)
            {
                MessageBox.Show("không có  sách này ", "thông  báo");
            }
            else
            {
                if (txtDonGia.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "" ||
               txtTenSach.Text == "" || cboTenNXB.Text == "" || datimeNamxb.Text == "" || cboTenTG.Text == "")
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
            string sql = $"select*from sach where Masach='{masach}'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            com.Clone();
            if (dt.Rows.Count ==0)
                ktra = false;
            else 
                ktra= true;
            return ktra;
        }

        private void SuaSach()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strUpdate = $"update sach set  Tensach=N'{txtTenSach.Text}',Namxb='{datimeNamxb.Value}',Soluong='{txtSoLuong.Text}',Dongia='{txtDonGia.Text}',Matg='{cboTenTG.SelectedValue}',Manxb='{cboTenNXB.SelectedValue}' where Masach='{txtMaSach.Text}'";
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
            if (checkMaSach(txtMaSach.Text) == false)
            {
                MessageBox.Show(" không có sách này!", "thông báo");
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
                string strDelete = $"delete from sach where Masach='{txtMaSach.Text}'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }
        // tìm kiếm //
        private void btnTim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $"select*from sach where Masach='{txtSearch.Text}'";// tìm kiếm theo mã sách //
            //string sql = $"select*from sach where Tensach='{txtSearch.Text}'"; tìm kiếm theo tên sách//
            SqlCommand com= new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
                MessageBox.Show("không tìm thấy mã sách !", "thông báo");
            else
                dgvSach.DataSource = dt;
                 
        }
        // thoát //
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi=new DialogResult();
            traloi = MessageBox.Show("bạn muốn thoát hay không?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }
    }
}

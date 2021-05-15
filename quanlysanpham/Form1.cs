using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysanpham
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstring = "Data Source=PHAMDUY-PC;Initial Catalog=qlsp;Integrated Security=True";

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            LayDuLieuTensp();
            this.txtMasp.Focus();
        }
        
        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select*from sanpham";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSanPham.DataSource = dt;
        }

        private void LayDuLieuTensp()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select Masp,Tensp from sanpham";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTensp.DataSource = dt;
            cboTensp.DisplayMember = "Tensp";
            cboTensp.ValueMember = "Masp";
        }
        // click thêm mới//
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            if(txtMasp.Text==""|| cboTensp.Text==""||
                txtSoluong.Text == "" || txtSodienthoai.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu thông tin", "thông báo");
            }

            else
            {
                ThemMoiSanPham();
                LayDuLieuDataGridView();
            }
        }
        // thêm mới sản phẩm//
        private void ThemMoiSanPham()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strInsert ="insert into sanpham values('"+txtMasp.Text+"','"+cboTensp.Text+"','"
                    +txtSoluong.Text+"','"+txtSodienthoai.Text+"')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
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

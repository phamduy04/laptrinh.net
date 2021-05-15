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

namespace quanlydiem
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string constring = "Data Source=PHAMDUY-PC;Initial Catalog=qlydiem;Integrated Security=True";

        private void frmDiem_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            LayDuLieuTensv();
            LayDuLieuTenmon();
            this.txtMadki.Focus();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string sql = "select*from dangki";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvDiem.DataSource = dt;
        }

        private void LayDuLieuTensv()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string sql = "select Masv,Hoten from sinhvien";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboHoten.DataSource = dt;
            cboHoten.DisplayMember = "Hoten";
            cboHoten.ValueMember = "Masv";
        }

        private void LayDuLieuTenmon()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string sql = "select Mamon,Tenmon from monhoc";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenmon.DataSource = dt;
            cboTenmon.DisplayMember = "Tenmon";
            cboTenmon.ValueMember = "Mamon";

        }
        //nhập lại //
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMadki.Clear();
            txtMadki.Focus();
        }
       
        //thêm //                            
        private void btnThem_Click(object sender, EventArgs e)
        {
               if(txtMadki.Text==""|| cboHoten.Text==""||cboTenmon.Text=="" )
            {
                MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
            }
            else
            {
                ThemDiem();
                LayDuLieuDataGridView();
            }

        }

        private void ThemDiem()
        {
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                string strInsert = $"insert into dangki values('{txtMadki.Text}',N'{cboHoten.SelectedValue}',N'{cboTenmon.SelectedValue}','{datetimeNgaydki.Value}')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkMadk(txtMadki.Text) == false)
            {
                MessageBox.Show("không có điểm đấy!", "thông báo");
            }
            else
            {
                if (txtMadki.Text == "" || cboHoten.Text == "" || cboTenmon.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
                }
                else
                {
                    SuaDiem();
                    LayDuLieuDataGridView();
                }
            }
        }

        private bool checkMadk(string madki)
        {
            bool ktra = false;
            conn = new SqlConnection(constring);
            conn.Open();
            string sql = $"select*from dangki where Madk='{madki}'";
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

        private void SuaDiem()
        {
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                string strUpdate = $"update  dangki set Masv=N'{cboHoten.SelectedValue}',Mamon=N'{cboTenmon.SelectedValue}',Ngaydangki='{datetimeNgaydki.Value}'where Madk='{txtMadki.Text}'";
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
            if (checkMadk(txtMadki.Text) == false)
            {
                MessageBox.Show("không có điểm đấy!", "thông báo");
            }
            else
            {
                XoaDiem();
                LayDuLieuDataGridView();
            }
        }

        private void XoaDiem()
        {
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                string strDelete = $"delete from dangki where Madk='{txtMadki.Text}'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }


        // tìm //
        private void btnTim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string sql = $"select*from dangki where Madk='{txtSearchID.Text}'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
                MessageBox.Show("không có mã dki đó!", "thông báo");
            else
                dgvDiem.DataSource = dt;
        }

        // thoát //
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = new DialogResult();
            traloi = MessageBox.Show("bạn có muốn thoát hay không ?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }
    } 
}

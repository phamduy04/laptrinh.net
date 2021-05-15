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

namespace qlysinhvien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string constr = "Data Source=PHAMDUY-PC;Initial Catalog=qlsv;Integrated Security=True";
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            txtMalop.Focus();
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(constr);
            conn.Open();
            string sql = "select*from Lop";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvSinhVien.DataSource = dt;
        }

        //nhập lại //
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMalop.Clear();
            txtPhong.Clear();
            txtTenlop.Clear();
            txtMalop.Focus();
        }
        //thêm mới ///
        private void btnThem_Click(object sender, EventArgs e)
        {
              if(txtMalop.Text==""|| txtMalop.TextLength>=10||
                txtPhong.Text==""|| txtTenlop.Text=="")
            {
                MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
            }
            else
            {
                ThemMoiSinhVien();
                LayDuLieuDataGridView();
            }
        }

        private void ThemMoiSinhVien()
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string strInsert = "insert into Lop values ('" + txtMalop.Text + "' , '" + txtTenlop.Text + "' , '" + txtPhong.Text + "')";
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
            if (checkMalop(txtMalop.Text) == false)
            {
                MessageBox.Show("Không có mã lớp này!", "thông báo");
            }
            else
            {
                if (txtMalop.Text == "" || txtMalop.TextLength >= 10 ||
                txtPhong.Text == "" || txtTenlop.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
                }
                else
                {
                    SuaSinhVien();
                    LayDuLieuDataGridView();
                }
            }
        }

        private bool checkMalop(string malop)
        {
            bool ktra = false;
            conn = new SqlConnection(constr);
            conn.Open();
            string sql = "select *from Lop where Malop='"+txtMalop.Text+"'";
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

        private void SuaSinhVien()
        {
                conn = new SqlConnection(constr);
                conn.Open();
            string strUpdate = "Update Lop set Tenlop=N'" +txtTenlop.Text+"', Phong=N'" + txtPhong.Text + "' where Malop='"+txtMalop.Text+"'";
                                
                SqlCommand cmd = new SqlCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
        }
         //xóa //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMalop(Convert.ToString(txtMalop.Text)) == false)
            {
                MessageBox.Show("Không có mã lớp này!", "thông báo");
            }
            else
            {
                if (txtMalop.Text == "" || txtMalop.TextLength >= 10 ||
                txtPhong.Text == "" || txtTenlop.Text == "")
                {
                    MessageBox.Show("bạn nhập thiếu thông tin!", "thông báo");
                }
                else
                {
                    XoaSinhVien();
                    LayDuLieuDataGridView();
                }
            }
        }

        private void XoaSinhVien()
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string strDelete="delete from  lop where Malop='"+txtMalop.Text+"'";
                SqlCommand cmd = new SqlCommand(strDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("có lỗi nhập liệu!", "thông báo");
            }
        }
        // tìm  kiếm//
        private void btnTim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            string sqlStr_ma_lop = $"select * from Lop where Malop = '{txtSearch.Text}'";   // search theo mã lớp
            string sqlStr_ten_lop = $"select * from Lop where Tenlop like N'%{txtSearch.Text}%'";   //search theo tên lớp
            SqlCommand com = new SqlCommand(sqlStr_ten_lop, conn);  //thay 1 trong 2 biến sql ở đây
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            if (dt.Rows.Count == 0)
                MessageBox.Show("không thấy mã lớp đó!", "thông báo");
            else
                dgvSinhVien.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = new DialogResult();
                traloi = MessageBox.Show("bạn có muốn thoát hay không? ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }
    }
}

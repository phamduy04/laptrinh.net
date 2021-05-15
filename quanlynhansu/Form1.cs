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

namespace quanlynhansu
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstring = "Data Source=PHAMDUY-PC;Initial Catalog=qlyns;Integrated Security=True";

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGriDview();
            LayDuLieuTenPB();
            radNam.Checked = true;
            radNu.Checked = false;
            txtMaNV.Focus();
            
        }

        private void LayDuLieuDataGriDview()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            // truy van//
            string sql = "select*from Employees";
            // bat dau truy van//
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvEmnployee.DataSource = dt;
        }

        private void LayDuLieuTenPB()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            // truy van//
            string sql = "select DepartmentID,DepartmentName from Departments";
            //bat dau truy van//
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            //gan du lie tenpb//
            cboTenpb.DataSource = dt;
            cboTenpb.DisplayMember = "DepartmentName";
            cboTenpb.ValueMember = "DepartmentID";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text=="" || txtFirstName.Text=="" || txtFullName.Text==""||
                txtLastName.Text=="" || txtAddress.Text=="" || cboTenpb.Text==""
                )
            {
                MessageBox.Show("bạn nhập thiếu thông tin", "thông báo");
            }
            else
            {
                ThemmoiNhanvien();
                LayDuLieuDataGriDview();
            }    
        }

        private void ThemmoiNhanvien()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                // truy vấn//
                string strInsert = " insert into Employee values('" + txtMaNV.Text + "','" + cboTenpb.SelectedValue + "',N'";
                strInsert += txtFirstName.Text + "',N'" + txtLastName.Text + "',N'"
                  + txtFullName.Text + "','";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                strInsert+= gt + "','" + dateTimePicker1.Value + "',N'" + txtAddress.Text + "')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                   
            }
            catch
            {
                MessageBox.Show("có lỗi nhạp liệu!", "thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }  
}

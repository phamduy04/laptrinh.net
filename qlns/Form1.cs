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

namespace qlns
{
    public partial class frmEmplyee : Form
    {
        public frmEmplyee()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connstring = "Data Source=PHAMDUY-PC;Initial Catalog=QLNS;Integrated Security=True";
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmEmplyee_Load(object sender, EventArgs e)
        {
            LaydDuLieuDataGridView();
           // LayDuLieuTenPB();
            radNam.Checked = true;
            radNu.Checked = false;
            txtMaNV.Focus();
        }
       private void LaydDuLieuDataGridView()
        {
            conn =  new SqlConnection(connstring);
            conn.Open();
            string sql = "select*from Employees";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvEmployee.DataSource = dt;
        }
        private void LayDuLieuTenPB()
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select DepartmentID,DepartmentName from Departments";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenPB.DataSource = dt;
            cboTenPB.DisplayMember = "DepartmentName";
            cboTenPB.ValueMember = "DepartmentID";
        }
    }
}

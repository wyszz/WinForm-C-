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

namespace StudentManagement
{
    public partial class QueryStudent_1 : Form
    {
        public QueryStudent_1()
        {
            InitializeComponent();
        }

        private void QuerytStudent_1_Load(object sender, EventArgs e)
        {
            dgvStudentDB();
        }
        private void dgvStudentDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = "select * from student";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds,"student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql =string.Format("select * from student where age between '{0}' and '{1}'",txtAge1.Text.Trim (),txtAge2.Text.Trim());
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from student order by age desc");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from student order by age asc");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

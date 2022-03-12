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
    public partial class QueryStudent_2 : Form
    {
        public QueryStudent_2()
        {
            InitializeComponent();
        }

        private void QueryStudent_2_Load(object sender, EventArgs e)
        {
            cbDeptDB();
            lblStudentCount();
        }
        private void cbDeptDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select distinct dept from student ");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "student");
            //ds.Tables["student"].Rows.InsertAt(ds.Tables["student"].NewRow(), 0);
            //cbDept.DataSource = ds.Tables["student"];
            //cbDept.DisplayMember = "dept";
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(),0);
            cbDept.DataSource = dt;
            cbDept.DisplayMember = "dept";

        }
        private void lblStudentCount()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select count(*) from student ");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            lblCount.Text = lblCount.Text + i + "人";
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select count(*) from student where dept='{0}'",cbDept.Text);
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            lblDeptCount.Text = cbDept.Text + "学生人数为：" + i.ToString() + "人";
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select count(*) from student where dept='{0}'", txtDept.Text.Trim());
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            lblDeptCount.Text = txtDept.Text.Trim() + "学生人数为：" + i.ToString() + "人";
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            lblTotalCount.Text = "";
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select dept,count(*) from student group by dept");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lblTotalCount.Text = lblTotalCount.Text + sdr[0].ToString() + " " + sdr[1].ToString() + "人\n";
            }
            sdr.Close();
            myConn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class SCForm : Form
    {
        string sno;
        string cno;
        public SCForm()
        {
            InitializeComponent();
        }

        private void SCForm_Load(object sender, EventArgs e)
        {
            cbCnameDB();
            cbSnameDB();
        }
        private void cbSnameDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from student");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "student");
            //ds.Tables["student"].Rows.InsertAt(ds.Tables["student"].NewRow(), 0);
            //cbSname.DataSource = ds.Tables["student"];
            //cbSname.DisplayMember = "sname";
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);
            cbSname.DataSource = dt;
            cbSname.DisplayMember = "sname";
        }
        private void cbCnameDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from course");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "course");
            //ds.Tables["course"].Rows.InsertAt(ds.Tables["course"].NewRow(), 0);
            //cbCname.DataSource = ds.Tables["course"];
            //cbCname.DisplayMember = "cname";
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);
            cbCname.DataSource = dt;
            cbCname.DisplayMember = "cname";
        }
        private void dgvSCDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select sc.sno,sc.cno,sname,cname,grade from student,sc,course where student.sno=sc.sno and course.cno=sc.cno");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            dgvSC.DataSource = dt;
            dgvSC.ClearSelection();
        }

        private void SCForm_Activated(object sender, EventArgs e)
        {
            dgvSCDB();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandType = CommandType.Text;
            if (cbSname.Text == "" && cbCname.Text == "")
            {
                cmd.CommandText = "select sc.sno,sc.cno,sname,cname,grade from student,sc,course where student.sno=sc.sno and course.cno=sc.cno";
            }
            else if (cbSname.Text != "" && cbCname.Text == "")
            {
                cmd.CommandText = string.Format("select sc.sno,sc.cno,sname,cname,grade from student,sc,course where student.sno=sc.sno and course.cno=sc.cno and sname='{0}'", cbSname.Text);
            }
            else if (cbSname.Text == "" && cbCname.Text != "")
            {
                cmd.CommandText = string.Format("select sc.sno,sc.cno,sname,cname,grade from student,sc,course where student.sno=sc.sno and course.cno=sc.cno and cname='{0}'", cbCname.Text);
            }
            else
            {
                cmd.CommandText = string.Format("select sc.sno,sc.cno,sname,cname,grade from student,sc,course where student.sno=sc.sno and course.cno=sc.cno and cname='{0}' and sname='{1}'", cbCname.Text, cbSname.Text);
            }
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvSC.DataSource = dt;
            dgvSC.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSCForm asc = new AddSCForm();
            asc.Show();
        }

        private void dgvSC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSCForm asc = new AddSCForm(dgvSC.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvSC.Rows[e.RowIndex].Cells[1].Value.ToString());
            asc.Show();
        }

        private void dgvSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            sno = dgvSC.Rows[e.RowIndex].Cells[0].Value.ToString();
            cno = dgvSC.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
                string sql = string.Format("delete from sc where sno='{0}' and cno='{1}'", sno, cno);
                SqlCommand cmd = new SqlCommand(sql, myConn);
                myConn.Open();
                int i = cmd.ExecuteNonQuery();
                myConn.Close();
                if (i > 0)
                {
                    MessageBox.Show("删除成功", "提示");
                }
                else
                {
                    MessageBox.Show("删除失败", "提示");
                }
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                dgvSC.ClearSelection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            dgvSC.ClearSelection();
        }
    }
}

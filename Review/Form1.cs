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

namespace Review
{
    public partial class Form1 : Form
    {
        string cno;
        string cname;
        string tname;
        string credit;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            dgvCourseDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCourseDB();
        }
        private void dgvCourseDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from course");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            dgvCourse.DataSource = dt;
            dgvCourse.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("确认要删除吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
                string sql = string.Format("delete from course where cno='{0}'", cno);
                SqlCommand cmd = new SqlCommand(sql, myConn);
                myConn.Open();
                int res = cmd.ExecuteNonQuery();
                myConn.Close();
                if (res > 0)
                {
                    MessageBox.Show("删除成功！", "提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                }
            }
            else
            {

            }

        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            cno = dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            cname = dgvCourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            tname = dgvCourse.Rows[e.RowIndex].Cells[2].Value.ToString();
            credit = dgvCourse.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCno.ReadOnly = true;
            txtCno.Text = cno;
            txtCname.Text = cname;
            txtCredit.Text = credit;
            txtTname.Text = tname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvCourse.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("update course set cname='{0}',credit='{1}',tname='{2}' where cno='{3}'",txtCname.Text.Trim(),txtCredit.Text.Trim(),txtTname.Text.Trim(),cno);
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int res = cmd.ExecuteNonQuery();
            myConn.Close();
            if (res > 0)
            {
                MessageBox.Show("更新成功！", "提示");
            }
            else
            {
                MessageBox.Show("更新失败！", "提示");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class CourseForm : Form
    {
        string cno;
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Activated(object sender, EventArgs e)
        {
            dgvCourseDB();
        }
        private void dgvCourseDB()
        {
            SqlConnection Myconn = new SqlConnection();
            Myconn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = "select * from course";
            SqlCommand cmd = new SqlCommand(sql, Myconn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");
            dgvCourse.DataSource = ds.Tables["course"];
            dgvCourse.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection Myconn = new SqlConnection();
            Myconn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string s = "%" + txtCname.Text.Trim() + "%";
            string CourseSql = string.Format("select * from course where cname like '{0}'",s);
            SqlCommand cmd = new SqlCommand(CourseSql, Myconn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "course");
            dgvCourse.DataSource = ds.Tables["course"];
            dgvCourse.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm acf = new AddCourseForm();
            acf.Show();
        }

        private void dgvCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCourseForm acf = new AddCourseForm(dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString());
            acf.Show();

        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            cno = dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除吗？","提示",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                SqlConnection Mycoon = new SqlConnection();
                Mycoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;Integrated Security=true;";
                string sql = string.Format("select count(*) from sc where cno='{0}'", cno);
                SqlCommand cmd = new SqlCommand(sql, Mycoon);
                Mycoon.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                Mycoon.Close();
                if (i == 0)
                {
                    Mycoon.Open();
                    cmd.CommandText = string.Format("delete from course where cno='{0}'",cno);
                    int j = cmd.ExecuteNonQuery();
                    Mycoon.Close();
                    if (j > 0)
                    {
                        MessageBox.Show("删除成功","提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("该用户已经被选中，不能被删除","提示");
                }
            }
            else
            { 
            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            dgvCourse.ClearSelection();
        }
    }
}

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
    public partial class StudentForm : Form
    {
        string sno;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Activated(object sender, EventArgs e)
        {
            dgvStudentDB();
        }
        private void dgvStudentDB()
        {
            SqlConnection Myconn = new SqlConnection();
            Myconn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = "select * from student";
            SqlCommand cmd = new SqlCommand(sql, Myconn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection Mycoon = new SqlConnection();
            Mycoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string a = "%" + txtSname.Text.Trim()+ "%";
            string sql = string.Format("select * from student where sname like '{0}'",a);
            SqlCommand cmd = new SqlCommand(sql, Mycoon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            dgvStudent.DataSource = ds.Tables["student"];
            dgvStudent.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm();
            asf.Show();
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddStudentForm asf = new AddStudentForm(dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
            asf.Show();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnChanel.Enabled = true;
            sno = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除\"" + sno + "\"吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection Mycoon = new SqlConnection();
                Mycoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
                string sql = string.Format("select count(*) from sc where sno='{0}'",sno);
                SqlCommand cmd = new SqlCommand(sql,Mycoon);
                Mycoon.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                Mycoon.Close();
                if (i == 0)
                {
                    cmd.CommandText = "delete from student where sno='" + sno + "'";
                    Mycoon.Open();
                    i = cmd.ExecuteNonQuery();
                    Mycoon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("删除成功！", "提示");
                        dgvStudentDB();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("该同学已选课，不能删除！", "提示");
                }
            }
        }

        private void btnChanel_Click(object sender, EventArgs e)
        {
            
                btnDelete.Enabled = false;
                btnChanel.Enabled = false;
                dgvStudent.ClearSelection();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

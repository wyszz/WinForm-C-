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
    public partial class AddStudentForm : Form
    {
        string sno;
        public AddStudentForm()
        {
            InitializeComponent();
        }
        public AddStudentForm(string _sno)
        {
            InitializeComponent();
            sno = _sno;
            btnAdd.Text = "更新";
            txtSno.Text = sno;
            txtSno.Enabled = false;
            SqlConnection MyConn = new SqlConnection();
            MyConn.ConnectionString = "server =DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = string.Format("select * from student where sno='{0}'", sno);
            SqlCommand cmd = new SqlCommand(sql, MyConn);
            MyConn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txtSname.Text = sdr["sname"].ToString().Trim();
                if (sdr["sex"].ToString().Trim() == "男")
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
                txtAge.Text = sdr["age"].ToString();
                txtDept.Text = sdr["dept"].ToString();
            }
            sdr.Close();
            MyConn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "添加")
            {
                SqlConnection MyConn = new SqlConnection();
                MyConn.ConnectionString = "server =DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
                string sql = string.Format("select * from student where sno='{0}'",txtSno.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, MyConn);
                MyConn.Open();
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if (r > 0)
                {
                    MessageBox.Show("已有该学号信息,请确认！","提示");
                    return;
                }
                string sex;
                if (rbtnMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                string sqlInsert = string.Format("insert into student values('{0}','{1}','{2}','{3}','{4}')",txtSno.Text.Trim(),txtSname.Text.Trim(),sex,txtAge.Text.Trim(),txtDept.Text.Trim());
                cmd = new SqlCommand(sqlInsert, MyConn);
                int i = cmd.ExecuteNonQuery();
                MyConn.Close();
                if (i > 0)
                {
                    MessageBox.Show("学生信息添加成功！", "提示");
                }
                else
                {
                    MessageBox.Show("添加失败！","提示");
                }

            }
            else
            {
                string sex;
                if (rbtnMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                SqlConnection MyConn = new SqlConnection();
                MyConn.ConnectionString = "server =DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
                string sql = string.Format("update student set sname='{0}' ,sex='{1}' , age='{2}' ,dept='{3}' where sno='{4}'",txtSname.Text.Trim(),sex,txtAge.Text.Trim(),txtDept.Text.Trim(),sno);
                SqlCommand cmd = new SqlCommand(sql, MyConn);
                MyConn.Open();
                int i = cmd.ExecuteNonQuery();
                MyConn.Close();
                if (i > 0)
                {
                    MessageBox.Show("学生信息更新成功！", "提示");
                }
                else
                {
                    MessageBox.Show("学生信息更新失败！", "提示");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

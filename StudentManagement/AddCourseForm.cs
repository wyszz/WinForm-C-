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
    public partial class AddCourseForm : Form
    {
        string cno;
        public AddCourseForm()
        {
            InitializeComponent();
        }
        public AddCourseForm(string _cno)
        {
            InitializeComponent();
            btnAdd.Text = "更新";
            txtCno.Enabled = false;
            cno = _cno;
            txtCno.Text = cno;
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
            myConn.Open();
            string sql = string.Format("select * from  course  where cno='{0}'",cno);
            SqlCommand cmd = new SqlCommand(sql,myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtCname.Text = sdr["cname"].ToString();
                txtTname.Text = sdr["tname"].ToString();
                txtCredit.Text = sdr["credit"].ToString();
            }
            sdr.Close();
            myConn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text=="添加")
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
                string sql = string.Format("select count(*) from course where cno='{0}'",txtCno.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql,myConn);
                myConn.Open();
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if (r>0)
                {
                    MessageBox.Show("已有该课程信息，请确认！","提示");
                    return;
                }
                cmd.CommandText = string.Format("insert into course values('{0}','{1}','{2}','{3}')",txtCno.Text.Trim(),txtCname
                   .Text.Trim(), txtTname.Text.Trim(), txtCredit.Text.Trim());
                int i = cmd.ExecuteNonQuery();
                myConn.Close();
                if (i>0)
                {
                    MessageBox.Show("添加成功","提示");
                }
                else
                {
                    MessageBox.Show("添加失败", "提示");
                }
            }
            else
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true";
                myConn.Open();
                string sql = string.Format("update course set cname='{0}',tname='{1}',credit='{2}' where cno='{3}'",txtCname.Text.Trim(),txtTname.Text.Trim(),txtCredit.Text.Trim(),cno);
                SqlCommand cmd = new SqlCommand(sql, myConn);
                int i = cmd.ExecuteNonQuery();
                myConn.Close();
                if (i>0)
                {
                    MessageBox.Show("更新成功", "提示");
                }
                else
                {
                    MessageBox.Show("更新失败", "提示");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

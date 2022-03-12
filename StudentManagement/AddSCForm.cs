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
    public partial class AddSCForm : Form
    {
        string sno;
        string cno;
        public AddSCForm()
        {
            InitializeComponent();
        }
        public AddSCForm(string _sno, string _cno)
        {
            InitializeComponent();
            sno = _sno;
            cno = _cno;
            btnAdd.Text = "更新";
            cbSname.Enabled = false;
            cbCname.Enabled = false;
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            myConn.Open();
            string sql = string.Format("select grade from sc where sno='{0}' and cno='{1}'", sno, cno);
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtGragde.Text = sdr["grade"].ToString();
            }
            sdr.Close();
            myConn.Close();
        }

        private void AddSCForm_Load(object sender, EventArgs e)
        {
            cbSnameDB();
            cbCnameDB();
        }
        private void cbSnameDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = string.Format("select * from student");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cbSname.DataSource = dt;
            cbSname.DisplayMember = "sname";
            cbSname.ValueMember = "sno";
            if (sno != null)
            {
                cbSname.SelectedValue = sno;
            }
        }
        private void cbCnameDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = string.Format("select * from course");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cbCname.DataSource = dt;
            cbCname.DisplayMember = "cname";
            cbCname.ValueMember = "cno";
            if (cno != null)
            {
                cbCname.SelectedValue = cno;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "添加")
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
                string sql = string.Format("select count(*) from sc where sno='{0}'and cno='{1}'", cbSname.SelectedValue.ToString(), cbCname.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand(sql, myConn);
                myConn.Open();
                int r = Convert.ToInt32(cmd.ExecuteScalar());
                if (r > 0)
                {
                    MessageBox.Show("已有该成绩信息，请确认!", "提示");
                    return;
                }
                cmd.CommandText = string.Format("insert into sc values('{0}','{1}','{2}')", cbSname.SelectedValue.ToString(), cbCname.SelectedValue.ToString(), txtGragde.Text.Trim());
                int i = cmd.ExecuteNonQuery();
                myConn.Close();
                if (i > 0)
                {
                    MessageBox.Show("添加成功", "提示");
                }
                else
                {
                    MessageBox.Show("添加失败", "提示");
                }

            }
            else
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
                myConn.Open();
                string sql = string.Format("update sc set grade='{0}' where sno='{1}' and cno='{2}'",txtGragde.Text.Trim(),cbSname.SelectedValue.ToString(),cbCname.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand(sql, myConn);
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    MessageBox.Show("更新成功","提示");
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

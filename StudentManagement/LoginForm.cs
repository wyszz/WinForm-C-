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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection myCoon = new SqlConnection();
            myCoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;integrated security=true";
            string sql = string.Format("select count(*) from tb_user where username='{0}' and  password='{1}'", txtUserName.Text.Trim(), txtPassword.Text.Trim());
            SqlCommand cmd = new SqlCommand(sql, myCoon);
            myCoon.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myCoon.Close();
            if (i > 0)
            {
                Program.username = txtUserName.Text.Trim();
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要退出吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

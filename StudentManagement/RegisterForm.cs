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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")

            {
                SqlConnection myCoon = new SqlConnection();
                myCoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;integrated security=true";
                string sql = string.Format("select count(*) from tb_user where username='{0}'", txtUserName.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, myCoon);
                myCoon.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    MessageBox.Show("该用户已注册", "提示");
                    return;
                }
                else
                {
                    cmd.CommandText = string.Format("insert into tb_user values('{0}','{1}')", txtUserName.Text.Trim(), txtPassword.Text.Trim());
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("用户信息注册成功，请登录！", "提示");
                        LoginForm lf = new LoginForm();
                        lf.Show();
                    }
                    else
                    { 
                        MessageBox.Show("注册失败！", "提示");
                    }
                }
            }
            else
            { 
                MessageBox.Show("请输入完整注册信息！", "警告");
                return;
            }
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

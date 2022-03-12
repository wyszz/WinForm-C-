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
    public partial class PWDForm : Form
    {
        public PWDForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOldPWD.Text.Trim() != "" && txtNewPWD.Text.Trim() != "" && txtConfirmPWD.Text.Trim() != "")
            {
                SqlConnection myCoon = new SqlConnection();
                myCoon.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;integrated security=true";
                string sql = string.Format("select count(*) from tb_user where username='{0}' and  password='{1}'", Program.username, txtOldPWD.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, myCoon);
                myCoon.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                myCoon.Close();
                if (i > 0)
                {
                    if (txtOldPWD.Text.Trim() != txtNewPWD.Text.Trim())
                    {
                        if (txtNewPWD.Text.Trim() == txtConfirmPWD.Text.Trim())
                        {
                            myCoon.Open();
                            cmd.CommandText = string.Format("update tb_user set password='{0}' where username='{1}'", txtNewPWD.Text.Trim(), Program.username);
                            int j = cmd.ExecuteNonQuery();
                            myCoon.Close();
                            if (j > 0)
                            {
                                MessageBox.Show("更新成功！", "提示");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("更新失败！", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("新密码和确认密码不一致!", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("新密码和与旧密码一致!", "提示");
                    }
                   
                }
                else
                {
                    MessageBox.Show("旧密码输入错误！", "提示");
                }
            }
            else 
            {
                MessageBox.Show("所有项都必须填写！","提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

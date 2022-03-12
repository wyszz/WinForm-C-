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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=true";
            string sql = string.Format("select count(*) from course where cno='{0}'", cnoBox.Text);
            //string sql = string.Format("insert into course values('{0}','{1}','{2}',{3})",cnoBox.Text,cnameBox.Text,tnameBox.Text,creditBox.Text);
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            if (res > 0)
                MessageBox.Show("该课程号信息已存在！", "警告");
            else
            {
                cmd.CommandText = string.Format("insert into course values('{0}','{1}','{2}',{3})", cnoBox.Text, cnameBox.Text, tnameBox.Text, creditBox.Text);
                res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("添加成功！", "提示");
                else
                    MessageBox.Show("添加失败！", "提示");
            }
            myConn.Close();
        }
    
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=true";
            string sql = string.Format("delete from course where cno='{0}'", textBox1.Text);
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("删除成功！", "提示");
            else
                MessageBox.Show("删除失败！", "提示");
            myConn.Close();
        }
    }
}

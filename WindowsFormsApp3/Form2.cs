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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=true";
            string sql = "select * from student where sno='"+snoBox.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
               snameBox.Text = sdr["sname"].ToString();
               sexBox.Text = sdr["sex"].ToString();
                ageBox.Text = sdr["age"].ToString();
                deptBox.Text = sdr["dept"].ToString();
            }
            sdr.Close();
            sqlConnection.Close();
        }
    }
}

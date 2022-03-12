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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=true";
            string sql = "select * from course";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //string cno = sdr[0].ToString();
                //string cname = sdr[1].ToString();
                string cno = sdr["cno"].ToString();
                string cname = sdr["cname"].ToString();
                label1.Text += cno + " " + cname + "\n";
            }
            sdr.Close();
            sqlConnection.Close();
        }
    }
}

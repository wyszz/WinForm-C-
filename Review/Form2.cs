using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //在下拉选框里绑定数据库系别信息
        private void cbDeptDB()
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-CGH2L4G;database=Winform2.0;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select distinct dept from student", myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            ds.Tables["student"].Rows.InsertAt(ds.Tables["student"].NewRow(), 0);//插入空白行
            cbDept.DataSource = ds.Tables["student"];
            cbDept.DisplayMember = "dept";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDeptDB();
            labelStudentCont();
        }

        private void labelStudentCont()
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-CGH2L4G;database=Winform2.0;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select count(*) from student", myConn);//查学生表人数
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            labelCount.Text = labelCount.Text + i + "人";
        }

        private void btnDept1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-CGH2L4G;database=Winform2.0;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select count(*) from student where dept='" + cbDept.Text.Trim() + "'", myConn);
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            labelDept.Text = cbDept.Text + "学生人数为:" + i.ToString() + "人";
        }

        private void btnDept2_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-CGH2L4G;database=Winform2.0;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select count(*) from student where dept='" + textDept.Text.Trim() + "'", myConn);
            myConn.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            myConn.Close();
            labelDept.Text = textDept.Text + "学生人数为:" + i.ToString() + "人";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            labelTotalCount.Text = "";//在执行之前进行清空！！
            SqlConnection myConn = new SqlConnection("server=DESKTOP-CGH2L4G;database=Winform2.0;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select dept,count(*) from student group by dept", myConn);
            myConn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                labelTotalCount.Text = labelTotalCount.Text + sdr[0].ToString() + " " + sdr[1].ToString() + "人\n";
            }
            sdr.Close();
            myConn.Close();
        }
    }
}

    }
}

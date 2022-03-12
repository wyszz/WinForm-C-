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

namespace Review
{

    public partial class StudentUpdate : Form
    {
        public string sno;
        public string sname;
        public string sex;
        public string age;
        public string dept;
        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            dgvStudentDB();
            cbStudentDB();
        }

        private void StudentUpdate_Activated(object sender, EventArgs e)
        {
            dgvStudentDB();
        }
        private void cbStudentDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=yes";
            string sql = string.Format("select * from student");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);
            cbSname.DataSource = dt;
            cbSname.ValueMember = "sno";
        }

        private void dgvStudentDB()
        {
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=yes";
            string sql = string.Format("select * from student");
            SqlCommand cmd = new SqlCommand(sql, myConn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvStudent.DataSource = dt;
            dgvStudent.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection MyConn = new SqlConnection();
            MyConn.ConnectionString = "server =DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=true;";
            string sql = string.Format("select * from student where sno='{0}'", txtSno.Text.Trim());
            SqlCommand cmd = new SqlCommand(sql, MyConn);
            MyConn.Open();
            string sex;
            if (rdbMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            cmd.CommandText = string.Format("update student set sname='{0}',sex='{1}',age='{2}',dept='{3}' where sno='{4}'", txtSname.Text.Trim(), sex, txtAge.Text.Trim(), txtDept.Text.Trim(), sno );
            int i = cmd.ExecuteNonQuery();
            MyConn.Close();
            if (i > 0)
            {
                MessageBox.Show("学生信息更新成功！", "提示");
            }
            else
            {
                MessageBox.Show("更新失败！", "提示");
            }

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sno = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "server=.;database=demo;uid=sa;pwd=123;Integrated Security=true";
            string sql = string.Format("select * from student where sno='{0}'",sno);
            SqlCommand cmd = new SqlCommand(sql,myConn);
            myConn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtSno.Text = sdr["sno"].ToString().Trim();
                txtSno.ReadOnly = true;
                txtSname.Text = sdr["sname"].ToString().Trim();
                if (sdr["sex"].ToString().Trim() == "男")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }
                txtDept.Text = sdr["dept"].ToString().Trim();
                txtAge.Text = sdr["age"].ToString().Trim();
            }
            sdr.Close();
            myConn.Close();
            //sno = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            //sname = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            //sex = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            //age = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            //dept = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();

            //SqlConnection myConn = new SqlConnection();
            //myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=yes";
            //string sql = string.Format("select * from student where sno='{0}'", sno);
            //SqlCommand cmd = new SqlCommand(sql, myConn);
            //myConn.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{
            //    txtSno.Text = sno;
            //    txtSno.ReadOnly = true;
            //    txtSname.Text = sdr["sname"].ToString().Trim();
            //    if (sdr["sex"].ToString().Trim() == "男")
            //    {
            //        rdbMale.Checked = true;
            //    }
            //    else
            //    {
            //        rdbFemale.Checked = true;
            //    }
            //    txtAge.Text = sdr["age"].ToString();
            //    txtDept.Text = sdr["dept"].ToString();
            //}
            //sdr.Close();
            //myConn.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sno = cbSname.SelectedValue.ToString();
            if (MessageBox.Show("确定要删除" + sno + "？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection myConn = new SqlConnection();
                myConn.ConnectionString = "server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=123;Integrated Security=yes";
                string sql = string.Format("select count(*) from sc where sno='{0}'",sno);
                SqlCommand cmd = new SqlCommand(sql, myConn);
                myConn.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                myConn.Close();
                if (i == 0)
                {
                    myConn.Open();
                    cmd.CommandText = string.Format("delete from student where sno='{0}'",sno);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("删除成功!", "提示！");
                    }
                    else 
                    {
                        MessageBox.Show("删除失败！","提示！");
                    }
                }
                else
                {
                    MessageBox.Show("该学生已选课，不能删除","提示");
                }
            }
        }

    }
}

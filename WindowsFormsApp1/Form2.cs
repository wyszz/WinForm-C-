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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=yes;");
            string sql = "select count(*) from student";
            SqlCommand cmd = new SqlCommand(sql,myConn);
            myConn.Open();
            int res = Convert.ToInt16(cmd.ExecuteScalar());
            myConn.Close();
            label1.Text = "student表有" + res + "条记录!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("server=DESKTOP-VDERB5N;database=demo;uid=sa;pwd=ppnn13%dkstFeb.1st;integrated security=yes;");
            string sql = "select max(grade) from sc";
            SqlCommand cmd = new SqlCommand(sql, myConn);
            myConn.Open();
            int max = Convert.ToInt16(cmd.ExecuteScalar());
            myConn.Close();
            label2.Text = "sc表最高分为" + max ;
        }     }
}
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        bool flag = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i])
            {
                flag = true;
                break;
            }
        }
        return flag;
    }
}

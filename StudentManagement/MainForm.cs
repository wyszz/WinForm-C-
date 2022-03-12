using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void 学生管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //课程管理
            CourseForm cf = new CourseForm();
            cf.Show();
        }

        private void 学生管理ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //查询学生1
            QueryStudent_1 qs1 = new QueryStudent_1();
            qs1.Show();
        }

        private void 查询学生2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询学生2
            QueryStudent_2 qs2 = new QueryStudent_2();
            qs2.Show();
        }

        private void 学生管理ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //选课管理
            SCForm sc = new SCForm();
            sc.Show();
        }
    }
}

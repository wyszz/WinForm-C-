
namespace StudentManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.信息管理ToolStripMenuItem,
            this.密码修改ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.学生管理ToolStripMenuItem1,
            this.学生管理ToolStripMenuItem2,
            this.学生管理ToolStripMenuItem3,
            this.查询学生2ToolStripMenuItem});
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 学生管理ToolStripMenuItem1
            // 
            this.学生管理ToolStripMenuItem1.Name = "学生管理ToolStripMenuItem1";
            this.学生管理ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.学生管理ToolStripMenuItem1.Text = "课程管理";
            this.学生管理ToolStripMenuItem1.Click += new System.EventHandler(this.学生管理ToolStripMenuItem1_Click);
            // 
            // 学生管理ToolStripMenuItem2
            // 
            this.学生管理ToolStripMenuItem2.Name = "学生管理ToolStripMenuItem2";
            this.学生管理ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.学生管理ToolStripMenuItem2.Text = "选课管理";
            this.学生管理ToolStripMenuItem2.Click += new System.EventHandler(this.学生管理ToolStripMenuItem2_Click);
            // 
            // 学生管理ToolStripMenuItem3
            // 
            this.学生管理ToolStripMenuItem3.Name = "学生管理ToolStripMenuItem3";
            this.学生管理ToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.学生管理ToolStripMenuItem3.Text = "查询学生-1";
            this.学生管理ToolStripMenuItem3.Click += new System.EventHandler(this.学生管理ToolStripMenuItem3_Click);
            // 
            // 查询学生2ToolStripMenuItem
            // 
            this.查询学生2ToolStripMenuItem.Name = "查询学生2ToolStripMenuItem";
            this.查询学生2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询学生2ToolStripMenuItem.Text = "查询学生-2";
            this.查询学生2ToolStripMenuItem.Click += new System.EventHandler(this.查询学生2ToolStripMenuItem_Click);
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 349);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 查询学生2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}


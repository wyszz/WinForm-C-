
namespace WindowsFormsApp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sno = new System.Windows.Forms.Label();
            this.snoBox = new System.Windows.Forms.TextBox();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.Label();
            this.deptBox = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Location = new System.Drawing.Point(167, 56);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(52, 15);
            this.sno.TabIndex = 0;
            this.sno.Text = "学号：";
            // 
            // snoBox
            // 
            this.snoBox.Location = new System.Drawing.Point(249, 53);
            this.snoBox.Name = "snoBox";
            this.snoBox.Size = new System.Drawing.Size(100, 25);
            this.snoBox.TabIndex = 1;
            // 
            // snameBox
            // 
            this.snameBox.Location = new System.Drawing.Point(249, 115);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(100, 25);
            this.snameBox.TabIndex = 3;
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(167, 118);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(52, 15);
            this.sname.TabIndex = 2;
            this.sname.Text = "姓名：";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(249, 243);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 25);
            this.ageBox.TabIndex = 7;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(167, 253);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(52, 15);
            this.age.TabIndex = 6;
            this.age.Text = "年龄：";
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(249, 181);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(100, 25);
            this.sexBox.TabIndex = 5;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(167, 191);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(52, 15);
            this.sex.TabIndex = 4;
            this.sex.Text = "性别：";
            // 
            // deptBox
            // 
            this.deptBox.Location = new System.Drawing.Point(249, 307);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(100, 25);
            this.deptBox.TabIndex = 9;
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(167, 310);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(52, 15);
            this.dept.TabIndex = 8;
            this.dept.Text = "系别：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deptBox);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.snameBox);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.snoBox);
            this.Controls.Add(this.sno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.TextBox snoBox;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.TextBox deptBox;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Button button1;
    }
}
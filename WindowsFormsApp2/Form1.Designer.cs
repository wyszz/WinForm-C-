﻿
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cnoBox = new System.Windows.Forms.TextBox();
            this.tnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creditBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号：";
            // 
            // cnoBox
            // 
            this.cnoBox.Location = new System.Drawing.Point(186, 44);
            this.cnoBox.Name = "cnoBox";
            this.cnoBox.Size = new System.Drawing.Size(100, 25);
            this.cnoBox.TabIndex = 1;
            // 
            // tnameBox
            // 
            this.tnameBox.Location = new System.Drawing.Point(186, 161);
            this.tnameBox.Name = "tnameBox";
            this.tnameBox.Size = new System.Drawing.Size(100, 25);
            this.tnameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "授课教师：";
            // 
            // cnameBox
            // 
            this.cnameBox.Location = new System.Drawing.Point(186, 99);
            this.cnameBox.Name = "cnameBox";
            this.cnameBox.Size = new System.Drawing.Size(100, 25);
            this.cnameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "课程名称：";
            // 
            // creditBox
            // 
            this.creditBox.Location = new System.Drawing.Point(186, 221);
            this.creditBox.Name = "creditBox";
            this.creditBox.Size = new System.Drawing.Size(100, 25);
            this.creditBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "学分：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creditBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cnoBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cnoBox;
        private System.Windows.Forms.TextBox tnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox creditBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}



namespace StudentManagement
{
    partial class QueryStudent_2
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
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDeptCount = new System.Windows.Forms.Label();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(50, 60);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(142, 15);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "全校学生总人数为：";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(53, 113);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(139, 29);
            this.btnSearch1.TabIndex = 1;
            this.btnSearch1.Text = "查询某系别的人数";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(240, 118);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 23);
            this.cbDept.TabIndex = 2;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(53, 179);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(139, 24);
            this.btnSearch2.TabIndex = 3;
            this.btnSearch2.Text = "查询某系别的人数";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(240, 181);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(121, 25);
            this.txtDept.TabIndex = 4;
            // 
            // lblDeptCount
            // 
            this.lblDeptCount.AutoSize = true;
            this.lblDeptCount.Location = new System.Drawing.Point(53, 252);
            this.lblDeptCount.Name = "lblDeptCount";
            this.lblDeptCount.Size = new System.Drawing.Size(142, 15);
            this.lblDeptCount.TabIndex = 5;
            this.lblDeptCount.Text = "该系别学生人数为：";
            // 
            // btnSearch3
            // 
            this.btnSearch3.Location = new System.Drawing.Point(53, 300);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(139, 24);
            this.btnSearch3.TabIndex = 6;
            this.btnSearch3.Text = "查每个系别的人数";
            this.btnSearch3.UseVisualStyleBackColor = true;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(53, 363);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 15);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "?";
            // 
            // QueryStudent_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 419);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch3);
            this.Controls.Add(this.lblDeptCount);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.lblCount);
            this.Name = "QueryStudent_2";
            this.Text = "QueryStudent_2";
            this.Load += new System.EventHandler(this.QueryStudent_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDeptCount;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalCount;
    }
}
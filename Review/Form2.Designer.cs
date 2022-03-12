
namespace Review
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
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.btnDept1 = new System.Windows.Forms.Button();
            this.btnDept2 = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.textDept = new System.Windows.Forms.TextBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(104, 88);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(112, 15);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "全校总人数为：";
            // 
            // btnDept1
            // 
            this.btnDept1.Location = new System.Drawing.Point(107, 130);
            this.btnDept1.Name = "btnDept1";
            this.btnDept1.Size = new System.Drawing.Size(135, 23);
            this.btnDept1.TabIndex = 1;
            this.btnDept1.Text = "查询某系别人数";
            this.btnDept1.UseVisualStyleBackColor = true;
            this.btnDept1.Click += new System.EventHandler(this.btnDept1_Click);
            // 
            // btnDept2
            // 
            this.btnDept2.Location = new System.Drawing.Point(107, 189);
            this.btnDept2.Name = "btnDept2";
            this.btnDept2.Size = new System.Drawing.Size(135, 23);
            this.btnDept2.TabIndex = 2;
            this.btnDept2.Text = "查询某系别人数";
            this.btnDept2.UseVisualStyleBackColor = true;
            this.btnDept2.Click += new System.EventHandler(this.btnDept2_Click);
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(289, 129);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 23);
            this.cbDept.TabIndex = 3;
            // 
            // textDept
            // 
            this.textDept.Location = new System.Drawing.Point(289, 189);
            this.textDept.Name = "textDept";
            this.textDept.Size = new System.Drawing.Size(100, 25);
            this.textDept.TabIndex = 4;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(107, 243);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(112, 15);
            this.labelDept.TabIndex = 5;
            this.labelDept.Text = "该系别人数为：";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Location = new System.Drawing.Point(95, 333);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(15, 15);
            this.labelTotalCount.TabIndex = 6;
            this.labelTotalCount.Text = "?";
            this.labelTotalCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(98, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询每个系别的人数";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 486);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelTotalCount);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.textDept);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.btnDept2);
            this.Controls.Add(this.btnDept1);
            this.Controls.Add(this.labelCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnDept1;
        private System.Windows.Forms.Button btnDept2;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.TextBox textDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;


    }
}
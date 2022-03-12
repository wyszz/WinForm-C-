
namespace StudentManagement
{
    partial class SCForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCname = new System.Windows.Forms.ComboBox();
            this.课程名称 = new System.Windows.Forms.Label();
            this.cbSname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.结果 = new System.Windows.Forms.GroupBox();
            this.dgvSC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.结果.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbCname);
            this.groupBox1.Controls.Add(this.课程名称);
            this.groupBox1.Controls.Add(this.cbSname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(451, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCname
            // 
            this.cbCname.FormattingEnabled = true;
            this.cbCname.Location = new System.Drawing.Point(293, 38);
            this.cbCname.Name = "cbCname";
            this.cbCname.Size = new System.Drawing.Size(121, 23);
            this.cbCname.TabIndex = 3;
            // 
            // 课程名称
            // 
            this.课程名称.AutoSize = true;
            this.课程名称.Location = new System.Drawing.Point(220, 41);
            this.课程名称.Name = "课程名称";
            this.课程名称.Size = new System.Drawing.Size(67, 15);
            this.课程名称.TabIndex = 2;
            this.课程名称.Text = "课程名称";
            // 
            // cbSname
            // 
            this.cbSname.FormattingEnabled = true;
            this.cbSname.Location = new System.Drawing.Point(72, 38);
            this.cbSname.Name = "cbSname";
            this.cbSname.Size = new System.Drawing.Size(121, 23);
            this.cbSname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // 结果
            // 
            this.结果.Controls.Add(this.dgvSC);
            this.结果.Location = new System.Drawing.Point(23, 124);
            this.结果.Name = "结果";
            this.结果.Size = new System.Drawing.Size(632, 273);
            this.结果.TabIndex = 1;
            this.结果.TabStop = false;
            this.结果.Text = "结果";
            // 
            // dgvSC
            // 
            this.dgvSC.AllowUserToAddRows = false;
            this.dgvSC.AllowUserToDeleteRows = false;
            this.dgvSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSC.Location = new System.Drawing.Point(3, 21);
            this.dgvSC.Name = "dgvSC";
            this.dgvSC.RowHeadersVisible = false;
            this.dgvSC.RowHeadersWidth = 51;
            this.dgvSC.RowTemplate.Height = 27;
            this.dgvSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSC.Size = new System.Drawing.Size(626, 249);
            this.dgvSC.TabIndex = 0;
            this.dgvSC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSC_CellClick);
            this.dgvSC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSC_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sno";
            this.Column1.HeaderText = "学号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cno";
            this.Column2.HeaderText = "课程号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sname";
            this.Column3.HeaderText = "姓名";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cname";
            this.Column4.HeaderText = "课程名称";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "grade";
            this.Column5.HeaderText = "成绩";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(23, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(354, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(248, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(143, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.结果);
            this.Controls.Add(this.groupBox1);
            this.Name = "SCForm";
            this.Text = "SCForm";
            this.Activated += new System.EventHandler(this.SCForm_Activated);
            this.Load += new System.EventHandler(this.SCForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.结果.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCname;
        private System.Windows.Forms.Label 课程名称;
        private System.Windows.Forms.ComboBox cbSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox 结果;
        private System.Windows.Forms.DataGridView dgvSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}
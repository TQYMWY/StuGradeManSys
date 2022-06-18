namespace StuGradeManSys.SubForm
{
    partial class FormAdminSel
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
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonpost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(817, 733);
            this.textBoxGrade.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(276, 42);
            this.textBoxGrade.TabIndex = 53;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(817, 650);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(276, 42);
            this.textBoxStudentID.TabIndex = 52;
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(241, 736);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(276, 42);
            this.textBoxCourseID.TabIndex = 51;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(241, 650);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(276, 42);
            this.textBoxID.TabIndex = 50;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(628, 736);
            this.labelGrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(96, 35);
            this.labelGrade.TabIndex = 49;
            this.labelGrade.Text = "成绩：";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Location = new System.Drawing.Point(91, 736);
            this.labelCourseID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(125, 35);
            this.labelCourseID.TabIndex = 48;
            this.labelCourseID.Text = "课程ID：";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(628, 653);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(125, 35);
            this.labelStudentID.TabIndex = 47;
            this.labelStudentID.Text = "学生ID：";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(91, 653);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(71, 35);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "ID：";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(91, 138);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(971, 463);
            this.dataGridView.TabIndex = 45;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(314, 43);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(475, 59);
            this.labelInfo.TabIndex = 44;
            this.labelInfo.Text = "学生选课信息管理模块";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1165, 323);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(276, 51);
            this.buttonQuery.TabIndex = 54;
            this.buttonQuery.Text = "刷新";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonpost
            // 
            this.buttonpost.Location = new System.Drawing.Point(1165, 645);
            this.buttonpost.Margin = new System.Windows.Forms.Padding(5);
            this.buttonpost.Name = "buttonpost";
            this.buttonpost.Size = new System.Drawing.Size(276, 51);
            this.buttonpost.TabIndex = 55;
            this.buttonpost.Text = "添加/更新选课信息";
            this.buttonpost.UseVisualStyleBackColor = true;
            this.buttonpost.Click += new System.EventHandler(this.buttonpost_Click);
            // 
            // FormAdminSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 868);
            this.Controls.Add(this.buttonpost);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAdminSel";
            this.Text = "FormAdminSel";
            this.Load += new System.EventHandler(this.FormAdminSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGrade;
        private TextBox textBoxStudentID;
        private TextBox textBoxCourseID;
        private TextBox textBoxID;
        private Label labelGrade;
        private Label labelCourseID;
        private Label labelStudentID;
        private Label labelID;
        private DataGridView dataGridView;
        private Label labelInfo;
        private Button buttonQuery;
        private Button buttonpost;
    }
}
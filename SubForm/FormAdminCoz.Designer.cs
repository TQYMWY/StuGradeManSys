namespace StuGradeManSys.SubForm
{
    partial class FormAdminCoz
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTeacherID = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.buttonpost = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonGiveup = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(391, 37);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(385, 59);
            this.labelInfo.TabIndex = 45;
            this.labelInfo.Text = "课程信息管理模块";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(88, 124);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(971, 463);
            this.dataGridView.TabIndex = 46;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Location = new System.Drawing.Point(87, 630);
            this.labelCourseID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(125, 35);
            this.labelCourseID.TabIndex = 47;
            this.labelCourseID.Text = "课程ID：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(506, 630);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 35);
            this.labelName.TabIndex = 48;
            this.labelName.Text = "课程名：";
            // 
            // labelTeacherID
            // 
            this.labelTeacherID.AutoSize = true;
            this.labelTeacherID.Location = new System.Drawing.Point(968, 630);
            this.labelTeacherID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTeacherID.Name = "labelTeacherID";
            this.labelTeacherID.Size = new System.Drawing.Size(179, 35);
            this.labelTeacherID.TabIndex = 49;
            this.labelTeacherID.Text = "授课教师ID：";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(87, 731);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(96, 35);
            this.labelCredit.TabIndex = 50;
            this.labelCredit.Text = "学分：";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(506, 731);
            this.labelTerm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(96, 35);
            this.labelTerm.TabIndex = 51;
            this.labelTerm.Text = "学期：";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(968, 731);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(150, 35);
            this.labelType.TabIndex = 52;
            this.labelType.Text = "课程类型：";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(210, 627);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.ReadOnly = true;
            this.textBoxCourseID.Size = new System.Drawing.Size(276, 42);
            this.textBoxCourseID.TabIndex = 53;
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(210, 724);
            this.textBoxCredit.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.ReadOnly = true;
            this.textBoxCredit.Size = new System.Drawing.Size(276, 42);
            this.textBoxCredit.TabIndex = 54;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(639, 630);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(276, 42);
            this.textBoxName.TabIndex = 55;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(639, 724);
            this.textBoxTerm.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.ReadOnly = true;
            this.textBoxTerm.Size = new System.Drawing.Size(276, 42);
            this.textBoxTerm.TabIndex = 56;
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(1157, 627);
            this.textBoxTeacherID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.ReadOnly = true;
            this.textBoxTeacherID.Size = new System.Drawing.Size(276, 42);
            this.textBoxTeacherID.TabIndex = 57;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(1157, 731);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(276, 42);
            this.textBoxType.TabIndex = 58;
            // 
            // buttonpost
            // 
            this.buttonpost.Location = new System.Drawing.Point(1157, 435);
            this.buttonpost.Margin = new System.Windows.Forms.Padding(5);
            this.buttonpost.Name = "buttonpost";
            this.buttonpost.Size = new System.Drawing.Size(276, 51);
            this.buttonpost.TabIndex = 59;
            this.buttonpost.Text = "确认";
            this.buttonpost.UseVisualStyleBackColor = true;
            this.buttonpost.Visible = false;
            this.buttonpost.Click += new System.EventHandler(this.buttonpost_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1157, 124);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(276, 51);
            this.buttonQuery.TabIndex = 60;
            this.buttonQuery.Text = "刷新";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonGiveup
            // 
            this.buttonGiveup.Location = new System.Drawing.Point(1157, 524);
            this.buttonGiveup.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGiveup.Name = "buttonGiveup";
            this.buttonGiveup.Size = new System.Drawing.Size(276, 51);
            this.buttonGiveup.TabIndex = 61;
            this.buttonGiveup.Text = "放弃";
            this.buttonGiveup.UseVisualStyleBackColor = true;
            this.buttonGiveup.Visible = false;
            this.buttonGiveup.Click += new System.EventHandler(this.buttonGiveup_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(1157, 285);
            this.buttonAddCourse.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(276, 51);
            this.buttonAddCourse.TabIndex = 62;
            this.buttonAddCourse.Text = "添加新课程";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // FormAdminCoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 866);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.buttonGiveup);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonpost);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxTeacherID);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelTeacherID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAdminCoz";
            this.Text = "FormAdminCoz";
            this.Load += new System.EventHandler(this.FormAdminCoz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private DataGridView dataGridView;
        private Label labelCourseID;
        private Label labelName;
        private Label labelTeacherID;
        private Label labelCredit;
        private Label labelTerm;
        private Label labelType;
        private TextBox textBoxCourseID;
        private TextBox textBoxCredit;
        private TextBox textBoxName;
        private TextBox textBoxTerm;
        private TextBox textBoxTeacherID;
        private TextBox textBoxType;
        private Button buttonpost;
        private Button buttonQuery;
        private Button buttonGiveup;
        private Button buttonAddCourse;
    }
}
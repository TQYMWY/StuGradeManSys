namespace StuGradeManSys.SubForm
{
    partial class FormAdminUser
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
            this.buttonQuery = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUserPwd = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonpost = new System.Windows.Forms.Button();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(440, 23);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(385, 59);
            this.labelInfo.TabIndex = 25;
            this.labelInfo.Text = "用户信息管理模块";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(182, 108);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(920, 529);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1222, 344);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(270, 51);
            this.buttonQuery.TabIndex = 27;
            this.buttonQuery.Text = "刷新";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(170, 696);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(120, 35);
            this.labelID.TabIndex = 28;
            this.labelID.Text = "用户id：";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(170, 786);
            this.labelPwd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(150, 35);
            this.labelPwd.TabIndex = 29;
            this.labelPwd.Text = "用户密码：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(680, 696);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 35);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "用户名：";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(680, 786);
            this.labelRole.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(150, 35);
            this.labelRole.TabIndex = 31;
            this.labelRole.Text = "用户身份：";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(343, 693);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(276, 42);
            this.textBoxUserID.TabIndex = 37;
            // 
            // textBoxUserPwd
            // 
            this.textBoxUserPwd.Location = new System.Drawing.Point(343, 783);
            this.textBoxUserPwd.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserPwd.Name = "textBoxUserPwd";
            this.textBoxUserPwd.PasswordChar = '*';
            this.textBoxUserPwd.Size = new System.Drawing.Size(276, 42);
            this.textBoxUserPwd.TabIndex = 38;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(835, 696);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(276, 42);
            this.textBoxUserName.TabIndex = 39;
            // 
            // buttonpost
            // 
            this.buttonpost.Location = new System.Drawing.Point(1222, 693);
            this.buttonpost.Margin = new System.Windows.Forms.Padding(5);
            this.buttonpost.Name = "buttonpost";
            this.buttonpost.Size = new System.Drawing.Size(270, 51);
            this.buttonpost.TabIndex = 41;
            this.buttonpost.Text = "添加/更新用户信息";
            this.buttonpost.UseVisualStyleBackColor = true;
            this.buttonpost.Click += new System.EventHandler(this.buttonpost_Click);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(838, 784);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(100, 39);
            this.radioButtonStudent.TabIndex = 42;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "学生";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Location = new System.Drawing.Point(966, 784);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(100, 39);
            this.radioButtonTeacher.TabIndex = 43;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "老师";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(1095, 784);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(127, 39);
            this.radioButtonAdmin.TabIndex = 44;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "管理员";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // FormAdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 981);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonTeacher);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.buttonpost);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxUserPwd);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAdminUser";
            this.Text = "FormAdminUser";
            this.Load += new System.EventHandler(this.FormAdminUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private DataGridView dataGridView;
        private Button buttonQuery;
        private Label labelID;
        private Label labelPwd;
        private Label labelName;
        private Label labelRole;
        private TextBox textBoxUserID;
        private TextBox textBoxUserPwd;
        private TextBox textBoxUserName;
        private Button buttonpost;
        private RadioButton radioButtonStudent;
        private RadioButton radioButtonTeacher;
        private RadioButton radioButtonAdmin;
    }
}
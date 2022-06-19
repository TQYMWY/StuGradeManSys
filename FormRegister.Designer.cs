namespace StuGradeManSys
{
    partial class FormRegister
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelReUserPwd = new System.Windows.Forms.Label();
            this.textBoxRePwd = new System.Windows.Forms.TextBox();
            this.labelOwn = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelUserPwd = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelName);
            this.panelLogin.Controls.Add(this.textBoxName);
            this.panelLogin.Controls.Add(this.labelHint);
            this.panelLogin.Controls.Add(this.radioButtonTeacher);
            this.panelLogin.Controls.Add(this.radioButtonStudent);
            this.panelLogin.Controls.Add(this.labelRole);
            this.panelLogin.Controls.Add(this.labelReUserPwd);
            this.panelLogin.Controls.Add(this.textBoxRePwd);
            this.panelLogin.Controls.Add(this.labelOwn);
            this.panelLogin.Controls.Add(this.labelRegister);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.labelUserPwd);
            this.panelLogin.Controls.Add(this.textBoxPwd);
            this.panelLogin.Controls.Add(this.labelUserID);
            this.panelLogin.Controls.Add(this.textBoxID);
            this.panelLogin.Location = new System.Drawing.Point(120, 30);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(392, 329);
            this.panelLogin.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "姓名：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 27);
            this.textBoxName.TabIndex = 23;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHint.Location = new System.Drawing.Point(46, 248);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(309, 20);
            this.labelHint.TabIndex = 22;
            this.labelHint.Text = "为保证唯一，账号为自动分配，不可自己设置";
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Location = new System.Drawing.Point(186, 221);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(60, 24);
            this.radioButtonTeacher.TabIndex = 20;
            this.radioButtonTeacher.Text = "老师";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            this.radioButtonTeacher.CheckedChanged += new System.EventHandler(this.radioButtonTeacher_CheckedChanged);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Checked = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(115, 221);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(60, 24);
            this.radioButtonStudent.TabIndex = 19;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "学生";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(46, 223);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(54, 20);
            this.labelRole.TabIndex = 18;
            this.labelRole.Text = "角色：";
            // 
            // labelReUserPwd
            // 
            this.labelReUserPwd.AutoSize = true;
            this.labelReUserPwd.Location = new System.Drawing.Point(25, 191);
            this.labelReUserPwd.Name = "labelReUserPwd";
            this.labelReUserPwd.Size = new System.Drawing.Size(84, 20);
            this.labelReUserPwd.TabIndex = 16;
            this.labelReUserPwd.Text = "确认密码：";
            // 
            // textBoxRePwd
            // 
            this.textBoxRePwd.Location = new System.Drawing.Point(115, 188);
            this.textBoxRePwd.Name = "textBoxRePwd";
            this.textBoxRePwd.PasswordChar = '*';
            this.textBoxRePwd.Size = new System.Drawing.Size(197, 27);
            this.textBoxRePwd.TabIndex = 15;
            this.textBoxRePwd.Leave += new System.EventHandler(this.textBoxRePwd_Leave);
            // 
            // labelOwn
            // 
            this.labelOwn.AutoSize = true;
            this.labelOwn.Font = new System.Drawing.Font("Microsoft YaHei UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOwn.Location = new System.Drawing.Point(315, 73);
            this.labelOwn.Name = "labelOwn";
            this.labelOwn.Size = new System.Drawing.Size(61, 14);
            this.labelOwn.TabIndex = 14;
            this.labelOwn.Text = "by wangyao";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegister.Location = new System.Drawing.Point(16, 28);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(360, 45);
            this.labelRegister.TabIndex = 13;
            this.labelRegister.Text = "学生成绩管理登录系统";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Location = new System.Drawing.Point(152, 280);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(94, 29);
            this.buttonRegister.TabIndex = 12;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelUserPwd
            // 
            this.labelUserPwd.AutoSize = true;
            this.labelUserPwd.Location = new System.Drawing.Point(46, 158);
            this.labelUserPwd.Name = "labelUserPwd";
            this.labelUserPwd.Size = new System.Drawing.Size(54, 20);
            this.labelUserPwd.TabIndex = 11;
            this.labelUserPwd.Text = "密码：";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(115, 155);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(197, 27);
            this.textBoxPwd.TabIndex = 10;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(46, 93);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(54, 20);
            this.labelUserID.TabIndex = 9;
            this.labelUserID.Text = "账号：";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(115, 90);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(197, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 379);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormRegister";
            this.Text = "注册";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogin;
        private Label labelRole;
        private Label labelReUserPwd;
        private TextBox textBoxRePwd;
        private Label labelOwn;
        private Label labelRegister;
        private Button buttonRegister;
        private Label labelUserPwd;
        private TextBox textBoxPwd;
        private Label labelUserID;
        private TextBox textBoxID;
        private Label labelHint;
        private RadioButton radioButtonTeacher;
        private RadioButton radioButtonStudent;
        private Label labelName;
        private TextBox textBoxName;
    }
}
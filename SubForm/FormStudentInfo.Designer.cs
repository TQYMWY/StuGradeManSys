namespace StuGradeManSys.SubForm
{
    partial class FormStudentInfo
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
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelChangePwd = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.textBoxRePwd = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonGiveUp = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRole
            // 
            this.textBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRole.Location = new System.Drawing.Point(225, 168);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(177, 20);
            this.textBoxRole.TabIndex = 16;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(165, 168);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(54, 20);
            this.labelRole.TabIndex = 15;
            this.labelRole.Text = "角色：";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPwd.Enabled = false;
            this.textBoxPwd.Location = new System.Drawing.Point(225, 142);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.ReadOnly = true;
            this.textBoxPwd.Size = new System.Drawing.Size(177, 20);
            this.textBoxPwd.TabIndex = 14;
            this.textBoxPwd.Leave += new System.EventHandler(this.textBoxPwd_Leave);
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(165, 142);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(54, 20);
            this.labelPwd.TabIndex = 13;
            this.labelPwd.Text = "密码：";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(225, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(165, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "姓名：";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Location = new System.Drawing.Point(225, 90);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(177, 20);
            this.textBoxID.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(165, 90);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 20);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "账号：";
            // 
            // labelChangePwd
            // 
            this.labelChangePwd.AutoSize = true;
            this.labelChangePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangePwd.ForeColor = System.Drawing.Color.Blue;
            this.labelChangePwd.Location = new System.Drawing.Point(408, 142);
            this.labelChangePwd.Name = "labelChangePwd";
            this.labelChangePwd.Size = new System.Drawing.Size(69, 20);
            this.labelChangePwd.TabIndex = 18;
            this.labelChangePwd.Text = "修改密码";
            this.labelChangePwd.Click += new System.EventHandler(this.labelChangePwd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeInfo.Location = new System.Drawing.Point(611, 25);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(94, 29);
            this.buttonChangeInfo.TabIndex = 20;
            this.buttonChangeInfo.Text = "修改信息";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // textBoxRePwd
            // 
            this.textBoxRePwd.Location = new System.Drawing.Point(516, 139);
            this.textBoxRePwd.Name = "textBoxRePwd";
            this.textBoxRePwd.PasswordChar = '*';
            this.textBoxRePwd.Size = new System.Drawing.Size(177, 27);
            this.textBoxRePwd.TabIndex = 21;
            this.textBoxRePwd.Visible = false;
            this.textBoxRePwd.Leave += new System.EventHandler(this.textBoxRePwd_Leave);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.ForeColor = System.Drawing.Color.Red;
            this.labelHint.Location = new System.Drawing.Point(516, 169);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(144, 20);
            this.labelHint.TabIndex = 22;
            this.labelHint.Text = "两次密码输入不一致";
            this.labelHint.Visible = false;
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Location = new System.Drawing.Point(12, 47);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(94, 29);
            this.buttonGiveUp.TabIndex = 23;
            this.buttonGiveUp.Text = "放弃";
            this.buttonGiveUp.UseVisualStyleBackColor = true;
            this.buttonGiveUp.Visible = false;
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(241, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(215, 33);
            this.labelInfo.TabIndex = 24;
            this.labelInfo.Text = "个人信息管理模块";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Location = new System.Drawing.Point(225, 291);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(177, 20);
            this.textBoxMail.TabIndex = 32;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(165, 291);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 20);
            this.labelMail.TabIndex = 31;
            this.labelMail.Text = "邮箱：";
            // 
            // textBoxDept
            // 
            this.textBoxDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDept.Location = new System.Drawing.Point(225, 265);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.ReadOnly = true;
            this.textBoxDept.Size = new System.Drawing.Size(177, 20);
            this.textBoxDept.TabIndex = 30;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(165, 265);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(54, 20);
            this.labelDept.TabIndex = 29;
            this.labelDept.Text = "系别：";
            // 
            // textBoxClass
            // 
            this.textBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClass.Location = new System.Drawing.Point(225, 239);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(177, 20);
            this.textBoxClass.TabIndex = 28;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(165, 239);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(54, 20);
            this.labelClass.TabIndex = 27;
            this.labelClass.Text = "班级：";
            // 
            // textBoxGender
            // 
            this.textBoxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGender.Location = new System.Drawing.Point(225, 213);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(177, 20);
            this.textBoxGender.TabIndex = 26;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(165, 213);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(54, 20);
            this.labelGender.TabIndex = 25;
            this.labelGender.Text = "性别：";
            // 
            // textBoxTime
            // 
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.Location = new System.Drawing.Point(225, 317);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(177, 20);
            this.textBoxTime.TabIndex = 34;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(135, 317);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(84, 20);
            this.labelTime.TabIndex = 33;
            this.labelTime.Text = "入学时间：";
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonGiveUp);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxRePwd);
            this.Controls.Add(this.buttonChangeInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelChangePwd);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "FormStudentInfo";
            this.Text = "FormStudentInfo";
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxRole;
        private Label labelRole;
        private TextBox textBoxPwd;
        private Label labelPwd;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxID;
        private Label labelID;
        private Label labelChangePwd;
        private Button buttonSave;
        private Button buttonChangeInfo;
        private TextBox textBoxRePwd;
        private Label labelHint;
        private Button buttonGiveUp;
        private Label labelInfo;
        private TextBox textBoxMail;
        private Label labelMail;
        private TextBox textBoxDept;
        private Label labelDept;
        private TextBox textBoxClass;
        private Label labelClass;
        private TextBox textBoxGender;
        private Label labelGender;
        private TextBox textBoxTime;
        private Label labelTime;
    }
}
namespace StuGradeManSys.SubForm
{
    partial class FormAdminInfo
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
            this.buttonGiveUp = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.textBoxRePwd = new System.Windows.Forms.TextBox();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelChangePwd = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(251, 26);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(215, 33);
            this.labelInfo.TabIndex = 39;
            this.labelInfo.Text = "个人信息管理模块";
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Location = new System.Drawing.Point(22, 54);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(94, 29);
            this.buttonGiveUp.TabIndex = 38;
            this.buttonGiveUp.Text = "放弃";
            this.buttonGiveUp.UseVisualStyleBackColor = true;
            this.buttonGiveUp.Visible = false;
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.ForeColor = System.Drawing.Color.Red;
            this.labelHint.Location = new System.Drawing.Point(526, 176);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(144, 20);
            this.labelHint.TabIndex = 37;
            this.labelHint.Text = "两次密码输入不一致";
            this.labelHint.Visible = false;
            // 
            // textBoxRePwd
            // 
            this.textBoxRePwd.Location = new System.Drawing.Point(526, 146);
            this.textBoxRePwd.Name = "textBoxRePwd";
            this.textBoxRePwd.PasswordChar = '*';
            this.textBoxRePwd.Size = new System.Drawing.Size(177, 27);
            this.textBoxRePwd.TabIndex = 36;
            this.textBoxRePwd.Visible = false;
            this.textBoxRePwd.Leave += new System.EventHandler(this.textBoxRePwd_Leave);
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeInfo.Location = new System.Drawing.Point(621, 32);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(94, 29);
            this.buttonChangeInfo.TabIndex = 35;
            this.buttonChangeInfo.Text = "修改信息";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelChangePwd
            // 
            this.labelChangePwd.AutoSize = true;
            this.labelChangePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangePwd.ForeColor = System.Drawing.Color.Blue;
            this.labelChangePwd.Location = new System.Drawing.Point(418, 149);
            this.labelChangePwd.Name = "labelChangePwd";
            this.labelChangePwd.Size = new System.Drawing.Size(69, 20);
            this.labelChangePwd.TabIndex = 33;
            this.labelChangePwd.Text = "修改密码";
            this.labelChangePwd.Click += new System.EventHandler(this.labelChangePwd_Click);
            // 
            // textBoxRole
            // 
            this.textBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRole.Location = new System.Drawing.Point(235, 175);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(177, 20);
            this.textBoxRole.TabIndex = 32;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(175, 175);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(54, 20);
            this.labelRole.TabIndex = 31;
            this.labelRole.Text = "角色：";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPwd.Location = new System.Drawing.Point(235, 149);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.ReadOnly = true;
            this.textBoxPwd.Size = new System.Drawing.Size(177, 20);
            this.textBoxPwd.TabIndex = 30;
            this.textBoxPwd.Leave += new System.EventHandler(this.textBoxPwd_Leave);
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(175, 149);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(54, 20);
            this.labelPwd.TabIndex = 29;
            this.labelPwd.Text = "密码：";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(235, 123);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 28;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(175, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "姓名：";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Location = new System.Drawing.Point(235, 97);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(177, 20);
            this.textBoxID.TabIndex = 26;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(175, 97);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 20);
            this.labelID.TabIndex = 25;
            this.labelID.Text = "账号：";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Location = new System.Drawing.Point(235, 201);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(177, 20);
            this.textBoxMail.TabIndex = 41;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(175, 201);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(54, 20);
            this.labelMail.TabIndex = 40;
            this.labelMail.Text = "邮箱：";
            // 
            // FormAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
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
            this.Name = "FormAdminInfo";
            this.Text = "FormAdminInfo";
            this.Load += new System.EventHandler(this.FormAdminInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private Button buttonGiveUp;
        private Label labelHint;
        private TextBox textBoxRePwd;
        private Button buttonChangeInfo;
        private Button buttonSave;
        private Label labelChangePwd;
        private TextBox textBoxRole;
        private Label labelRole;
        private TextBox textBoxPwd;
        private Label labelPwd;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxMail;
        private Label labelMail;
    }
}
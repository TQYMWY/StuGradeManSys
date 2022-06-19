namespace StuGradeManSys
{
    partial class FormLogin
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
            this.labelCheck = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelOwn = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserPwd = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelCheck);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.labelOwn);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelUserPwd);
            this.panelLogin.Controls.Add(this.textBoxPwd);
            this.panelLogin.Controls.Add(this.labelUserID);
            this.panelLogin.Controls.Add(this.textBoxID);
            this.panelLogin.Location = new System.Drawing.Point(124, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(392, 352);
            this.panelLogin.TabIndex = 8;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheck.Location = new System.Drawing.Point(129, 280);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(144, 20);
            this.labelCheck.TabIndex = 16;
            this.labelCheck.Text = "账号或密码不正确！";
            this.labelCheck.Visible = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.Blue;
            this.buttonRegister.Location = new System.Drawing.Point(226, 213);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(129, 29);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "没有账号？注册";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
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
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(16, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(360, 45);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "学生成绩管理登录系统";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Location = new System.Drawing.Point(149, 248);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUserPwd
            // 
            this.labelUserPwd.AutoSize = true;
            this.labelUserPwd.Location = new System.Drawing.Point(43, 183);
            this.labelUserPwd.Name = "labelUserPwd";
            this.labelUserPwd.Size = new System.Drawing.Size(54, 20);
            this.labelUserPwd.TabIndex = 11;
            this.labelUserPwd.Text = "密码：";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(112, 180);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(197, 27);
            this.textBoxPwd.TabIndex = 10;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(43, 127);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(54, 20);
            this.labelUserID.TabIndex = 9;
            this.labelUserID.Text = "账号：";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(112, 124);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(197, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 376);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.Text = "登录";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogin;
        private Button buttonRegister;
        private Label labelOwn;
        private Label labelLogin;
        private Button buttonLogin;
        private Label labelUserPwd;
        private TextBox textBoxPwd;
        private Label labelUserID;
        private TextBox textBoxID;
        private Label labelCheck;
    }
}
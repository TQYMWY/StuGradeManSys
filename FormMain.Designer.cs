namespace StuGradeManSys
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.buttonLoginOrLogout = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelOwn = new System.Windows.Forms.Label();
            this.groupBoxUserInfo.SuspendLayout();
            this.panelSubForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.labelOwn);
            this.groupBoxUserInfo.Controls.Add(this.buttonLoginOrLogout);
            this.groupBoxUserInfo.Controls.Add(this.labelRole);
            this.groupBoxUserInfo.Controls.Add(this.labelName);
            this.groupBoxUserInfo.Controls.Add(this.labelID);
            this.groupBoxUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUserInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(1049, 54);
            this.groupBoxUserInfo.TabIndex = 0;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "基本信息";
            // 
            // buttonLoginOrLogout
            // 
            this.buttonLoginOrLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginOrLogout.FlatAppearance.BorderSize = 0;
            this.buttonLoginOrLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginOrLogout.Location = new System.Drawing.Point(943, 19);
            this.buttonLoginOrLogout.Name = "buttonLoginOrLogout";
            this.buttonLoginOrLogout.Size = new System.Drawing.Size(94, 29);
            this.buttonLoginOrLogout.TabIndex = 3;
            this.buttonLoginOrLogout.Text = "登录";
            this.buttonLoginOrLogout.UseVisualStyleBackColor = true;
            this.buttonLoginOrLogout.Click += new System.EventHandler(this.buttonLoginOrLogout_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(527, 23);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(54, 20);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "角色：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(256, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "姓名：";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(39, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID：";
            // 
            // panelSubForm
            // 
            this.panelSubForm.Controls.Add(this.pictureBoxLogo);
            this.panelSubForm.Location = new System.Drawing.Point(12, 60);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(1025, 550);
            this.panelSubForm.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(436, 177);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(194, 193);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelOwn
            // 
            this.labelOwn.AutoSize = true;
            this.labelOwn.Font = new System.Drawing.Font("Microsoft YaHei UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOwn.Location = new System.Drawing.Point(982, 2);
            this.labelOwn.Name = "labelOwn";
            this.labelOwn.Size = new System.Drawing.Size(67, 14);
            this.labelOwn.TabIndex = 1;
            this.labelOwn.Text = "by wy,wzh,lyb";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Name = "FormMain";
            this.Text = "学生成绩管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.panelSubForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxUserInfo;
        private Button buttonLoginOrLogout;
        private Label labelRole;
        private Label labelName;
        private Label labelID;
        private Panel panelSubForm;
        private PictureBox pictureBoxLogo;
        private Label labelOwn;
    }
}
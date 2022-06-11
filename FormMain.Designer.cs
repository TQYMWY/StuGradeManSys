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
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonLoginOrLogout = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.groupBoxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.buttonTest3);
            this.groupBoxUserInfo.Controls.Add(this.buttonTest2);
            this.groupBoxUserInfo.Controls.Add(this.buttonTest);
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
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(711, 19);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(51, 29);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "stu";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
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
            this.panelSubForm.Location = new System.Drawing.Point(12, 60);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(1025, 550);
            this.panelSubForm.TabIndex = 5;
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(777, 19);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(51, 29);
            this.buttonTest2.TabIndex = 4;
            this.buttonTest2.Text = "tch";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // buttonTest3
            // 
            this.buttonTest3.Location = new System.Drawing.Point(845, 19);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(51, 29);
            this.buttonTest3.TabIndex = 5;
            this.buttonTest3.Text = "adm";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxUserInfo;
        private Button buttonLoginOrLogout;
        private Label labelRole;
        private Label labelName;
        private Label labelID;
        private Button buttonTest;
        private Panel panelSubForm;
        private Button buttonTest3;
        private Button buttonTest2;
    }
}
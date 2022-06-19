namespace StuGradeManSys.SubForm
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InfoManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StuInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TchInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CozInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoManageToolStripMenuItem,
            this.StuInfoToolStripMenuItem,
            this.TchInfoToolStripMenuItem,
            this.CozInfoToolStripMenuItem,
            this.SelInfoToolStripMenuItem,
            this.UserInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InfoManageToolStripMenuItem
            // 
            this.InfoManageToolStripMenuItem.Name = "InfoManageToolStripMenuItem";
            this.InfoManageToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.InfoManageToolStripMenuItem.Text = "个人信息管理";
            this.InfoManageToolStripMenuItem.Click += new System.EventHandler(this.InfoManageToolStripMenuItem_Click);
            // 
            // StuInfoToolStripMenuItem
            // 
            this.StuInfoToolStripMenuItem.Name = "StuInfoToolStripMenuItem";
            this.StuInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.StuInfoToolStripMenuItem.Text = "学生信息管理";
            this.StuInfoToolStripMenuItem.Click += new System.EventHandler(this.StuInfoToolStripMenuItem_Click);
            // 
            // TchInfoToolStripMenuItem
            // 
            this.TchInfoToolStripMenuItem.Name = "TchInfoToolStripMenuItem";
            this.TchInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.TchInfoToolStripMenuItem.Text = "教师信息管理";
            this.TchInfoToolStripMenuItem.Click += new System.EventHandler(this.TchInfoToolStripMenuItem_Click);
            // 
            // CozInfoToolStripMenuItem
            // 
            this.CozInfoToolStripMenuItem.Name = "CozInfoToolStripMenuItem";
            this.CozInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.CozInfoToolStripMenuItem.Text = "课程信息管理";
            this.CozInfoToolStripMenuItem.Click += new System.EventHandler(this.CozInfoToolStripMenuItem_Click);
            // 
            // SelInfoToolStripMenuItem
            // 
            this.SelInfoToolStripMenuItem.Name = "SelInfoToolStripMenuItem";
            this.SelInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.SelInfoToolStripMenuItem.Text = "选课信息管理";
            this.SelInfoToolStripMenuItem.Click += new System.EventHandler(this.SelInfoToolStripMenuItem_Click);
            // 
            // UserInfoToolStripMenuItem
            // 
            this.UserInfoToolStripMenuItem.Name = "UserInfoToolStripMenuItem";
            this.UserInfoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.UserInfoToolStripMenuItem.Text = "用户信息管理";
            this.UserInfoToolStripMenuItem.Click += new System.EventHandler(this.UserInfoToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(973, 485);
            this.panel.TabIndex = 2;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 528);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem InfoManageToolStripMenuItem;
        private ToolStripMenuItem StuInfoToolStripMenuItem;
        private ToolStripMenuItem TchInfoToolStripMenuItem;
        private ToolStripMenuItem CozInfoToolStripMenuItem;
        private ToolStripMenuItem SelInfoToolStripMenuItem;
        private ToolStripMenuItem UserInfoToolStripMenuItem;
        private Panel panel;
    }
}
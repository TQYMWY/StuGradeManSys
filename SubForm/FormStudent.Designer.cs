namespace StuGradeManSys.SubForm
{
    partial class FormStudent
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
            this.GradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlreadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoManageToolStripMenuItem,
            this.GradeToolStripMenuItem,
            this.CCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InfoManageToolStripMenuItem
            // 
            this.InfoManageToolStripMenuItem.Name = "InfoManageToolStripMenuItem";
            this.InfoManageToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.InfoManageToolStripMenuItem.Text = "个人信息管理";
            this.InfoManageToolStripMenuItem.Click += new System.EventHandler(this.InfoManageToolStripMenuItem_Click);
            // 
            // GradeToolStripMenuItem
            // 
            this.GradeToolStripMenuItem.Name = "GradeToolStripMenuItem";
            this.GradeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.GradeToolStripMenuItem.Text = "个人成绩查询";
            this.GradeToolStripMenuItem.Click += new System.EventHandler(this.GradeToolStripMenuItem_Click);
            // 
            // CCToolStripMenuItem
            // 
            this.CCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlreadyToolStripMenuItem,
            this.AvailableToolStripMenuItem});
            this.CCToolStripMenuItem.Name = "CCToolStripMenuItem";
            this.CCToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.CCToolStripMenuItem.Text = "选课模块";
            // 
            // AlreadyToolStripMenuItem
            // 
            this.AlreadyToolStripMenuItem.Name = "AlreadyToolStripMenuItem";
            this.AlreadyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AlreadyToolStripMenuItem.Text = "已选课程";
            this.AlreadyToolStripMenuItem.Click += new System.EventHandler(this.AlreadyToolStripMenuItem_Click);
            // 
            // AvailableToolStripMenuItem
            // 
            this.AvailableToolStripMenuItem.Name = "AvailableToolStripMenuItem";
            this.AvailableToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AvailableToolStripMenuItem.Text = "可选课程";
            this.AvailableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(935, 456);
            this.panel.TabIndex = 1;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 499);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem InfoManageToolStripMenuItem;
        private ToolStripMenuItem GradeToolStripMenuItem;
        private ToolStripMenuItem CCToolStripMenuItem;
        private ToolStripMenuItem AlreadyToolStripMenuItem;
        private ToolStripMenuItem AvailableToolStripMenuItem;
        private Panel panel;
    }
}
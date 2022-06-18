namespace StuGradeManSys.SubForm
{
    partial class FormTeacher
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.InfoManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoManageToolStripMenuItem,
            this.OpenCozToolStripMenuItem,
            this.GradeToolStripMenuItem,
            this.StuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(945, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // InfoManageToolStripMenuItem
            // 
            this.InfoManageToolStripMenuItem.Name = "InfoManageToolStripMenuItem";
            this.InfoManageToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.InfoManageToolStripMenuItem.Text = "个人信息管理";
            this.InfoManageToolStripMenuItem.Click += new System.EventHandler(this.InfoManageToolStripMenuItem_Click);
            // 
            // OpenCozToolStripMenuItem
            // 
            this.OpenCozToolStripMenuItem.Name = "OpenCozToolStripMenuItem";
            this.OpenCozToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.OpenCozToolStripMenuItem.Text = "课程开设";
            this.OpenCozToolStripMenuItem.Click += new System.EventHandler(this.OpenCozToolStripMenuItem_Click);
            // 
            // GradeToolStripMenuItem
            // 
            this.GradeToolStripMenuItem.Name = "GradeToolStripMenuItem";
            this.GradeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.GradeToolStripMenuItem.Text = "成绩录入";
            this.GradeToolStripMenuItem.Click += new System.EventHandler(this.GradeToolStripMenuItem_Click);
            // 
            // StuToolStripMenuItem
            // 
            this.StuToolStripMenuItem.Name = "StuToolStripMenuItem";
            this.StuToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.StuToolStripMenuItem.Text = "学生信息";
            this.StuToolStripMenuItem.Click += new System.EventHandler(this.StuToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(921, 477);
            this.panel.TabIndex = 2;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 520);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem InfoManageToolStripMenuItem;
        private ToolStripMenuItem GradeToolStripMenuItem;
        private ToolStripMenuItem StuToolStripMenuItem;
        private Panel panel;
        private ToolStripMenuItem OpenCozToolStripMenuItem;
    }
}
namespace StuGradeManSys.SubForm
{
    partial class FormStudentGrade
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
            this.labelTerm = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelComCourse = new System.Windows.Forms.Label();
            this.labelComCredit = new System.Windows.Forms.Label();
            this.labelOptCredit = new System.Windows.Forms.Label();
            this.labelOptCourse = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(12, 89);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(84, 20);
            this.labelTerm.TabIndex = 0;
            this.labelTerm.Text = "包含学期：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "第一学期";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(199, 88);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "第二学期";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(296, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "第三学期";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(393, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "第四学期";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(393, 118);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(91, 24);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "第八学期";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(296, 118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(91, 24);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "第七学期";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(199, 118);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(91, 24);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "第六学期";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(102, 118);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(91, 24);
            this.checkBox8.TabIndex = 5;
            this.checkBox8.Text = "第五学期";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(655, 101);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(94, 29);
            this.buttonQuery.TabIndex = 9;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(490, 104);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(112, 24);
            this.checkBoxAll.TabIndex = 11;
            this.checkBoxAll.Text = "全选/全不选";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(608, 196);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(84, 20);
            this.labelCourse.TabIndex = 12;
            this.labelCourse.Text = "课程门数：";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(608, 238);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(84, 20);
            this.labelCredit.TabIndex = 13;
            this.labelCredit.Text = "合计学分：";
            // 
            // labelComCourse
            // 
            this.labelComCourse.AutoSize = true;
            this.labelComCourse.Location = new System.Drawing.Point(608, 279);
            this.labelComCourse.Name = "labelComCourse";
            this.labelComCourse.Size = new System.Drawing.Size(84, 20);
            this.labelComCourse.TabIndex = 14;
            this.labelComCourse.Text = "必修门数：";
            // 
            // labelComCredit
            // 
            this.labelComCredit.AutoSize = true;
            this.labelComCredit.Location = new System.Drawing.Point(608, 321);
            this.labelComCredit.Name = "labelComCredit";
            this.labelComCredit.Size = new System.Drawing.Size(84, 20);
            this.labelComCredit.TabIndex = 15;
            this.labelComCredit.Text = "必修学分：";
            // 
            // labelOptCredit
            // 
            this.labelOptCredit.AutoSize = true;
            this.labelOptCredit.Location = new System.Drawing.Point(608, 405);
            this.labelOptCredit.Name = "labelOptCredit";
            this.labelOptCredit.Size = new System.Drawing.Size(84, 20);
            this.labelOptCredit.TabIndex = 17;
            this.labelOptCredit.Text = "选修学分：";
            // 
            // labelOptCourse
            // 
            this.labelOptCourse.AutoSize = true;
            this.labelOptCourse.Location = new System.Drawing.Point(608, 363);
            this.labelOptCourse.Name = "labelOptCourse";
            this.labelOptCourse.Size = new System.Drawing.Size(84, 20);
            this.labelOptCourse.TabIndex = 16;
            this.labelOptCourse.Text = "选修门数：";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(296, 25);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(165, 33);
            this.labelInfo.TabIndex = 23;
            this.labelInfo.Text = "成绩查询模块";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 153);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(590, 382);
            this.dataGridView.TabIndex = 24;
            // 
            // FormStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelOptCredit);
            this.Controls.Add(this.labelOptCourse);
            this.Controls.Add(this.labelComCredit);
            this.Controls.Add(this.labelComCourse);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTerm);
            this.Name = "FormStudentGrade";
            this.Text = "FormStudentGrade";
            this.Load += new System.EventHandler(this.FormStudentGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTerm;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Button buttonQuery;
        private CheckBox checkBoxAll;
        private Label labelCourse;
        private Label labelCredit;
        private Label labelComCourse;
        private Label labelComCredit;
        private Label labelOptCredit;
        private Label labelOptCourse;
        private Label labelInfo;
        private DataGridView dataGridView;
    }
}
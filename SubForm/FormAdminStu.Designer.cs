namespace StuGradeManSys.SubForm
{
    partial class FormAdminStu
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxEnrolltime = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxMailbox = new System.Windows.Forms.TextBox();
            this.labelenrolltime = new System.Windows.Forms.Label();
            this.labelmailbox = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonpost = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonGiveup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(204, 15);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(215, 33);
            this.labelInfo.TabIndex = 26;
            this.labelInfo.Text = "学生信息管理模块";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(586, 302);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(226, 445);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(45, 24);
            this.radioButtonFemale.TabIndex = 62;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "女";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(127, 446);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(45, 24);
            this.radioButtonMale.TabIndex = 61;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "男";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxEnrolltime
            // 
            this.textBoxEnrolltime.Location = new System.Drawing.Point(700, 447);
            this.textBoxEnrolltime.Name = "textBoxEnrolltime";
            this.textBoxEnrolltime.ReadOnly = true;
            this.textBoxEnrolltime.Size = new System.Drawing.Size(157, 27);
            this.textBoxEnrolltime.TabIndex = 60;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(700, 394);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.ReadOnly = true;
            this.textBoxDepartment.Size = new System.Drawing.Size(157, 27);
            this.textBoxDepartment.TabIndex = 59;
            // 
            // textBoxMailbox
            // 
            this.textBoxMailbox.Location = new System.Drawing.Point(413, 445);
            this.textBoxMailbox.Name = "textBoxMailbox";
            this.textBoxMailbox.ReadOnly = true;
            this.textBoxMailbox.Size = new System.Drawing.Size(157, 27);
            this.textBoxMailbox.TabIndex = 58;
            // 
            // labelenrolltime
            // 
            this.labelenrolltime.AutoSize = true;
            this.labelenrolltime.Location = new System.Drawing.Point(614, 447);
            this.labelenrolltime.Name = "labelenrolltime";
            this.labelenrolltime.Size = new System.Drawing.Size(84, 20);
            this.labelenrolltime.TabIndex = 57;
            this.labelenrolltime.Text = "入学日期：";
            // 
            // labelmailbox
            // 
            this.labelmailbox.AutoSize = true;
            this.labelmailbox.Location = new System.Drawing.Point(325, 447);
            this.labelmailbox.Name = "labelmailbox";
            this.labelmailbox.Size = new System.Drawing.Size(54, 20);
            this.labelmailbox.TabIndex = 56;
            this.labelmailbox.Text = "邮箱：";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(42, 447);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(54, 20);
            this.labelgender.TabIndex = 55;
            this.labelgender.Text = "性别：";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(614, 394);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(54, 20);
            this.labelDepartment.TabIndex = 54;
            this.labelDepartment.Text = "系别：";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(413, 394);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(157, 27);
            this.textBoxName.TabIndex = 53;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(325, 394);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 20);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "姓名：";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(127, 392);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(157, 27);
            this.textBoxID.TabIndex = 51;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(42, 394);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 20);
            this.labelID.TabIndex = 50;
            this.labelID.Text = "学号：";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(700, 332);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(157, 27);
            this.textBoxClass.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "班级：";
            // 
            // buttonpost
            // 
            this.buttonpost.Location = new System.Drawing.Point(700, 156);
            this.buttonpost.Name = "buttonpost";
            this.buttonpost.Size = new System.Drawing.Size(155, 29);
            this.buttonpost.TabIndex = 66;
            this.buttonpost.Text = "确认";
            this.buttonpost.UseVisualStyleBackColor = true;
            this.buttonpost.Visible = false;
            this.buttonpost.Click += new System.EventHandler(this.buttonpost_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(700, 63);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(155, 29);
            this.buttonQuery.TabIndex = 65;
            this.buttonQuery.Text = "刷新";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonGiveup
            // 
            this.buttonGiveup.Location = new System.Drawing.Point(700, 245);
            this.buttonGiveup.Name = "buttonGiveup";
            this.buttonGiveup.Size = new System.Drawing.Size(155, 29);
            this.buttonGiveup.TabIndex = 67;
            this.buttonGiveup.Text = "放弃";
            this.buttonGiveup.UseVisualStyleBackColor = true;
            this.buttonGiveup.Visible = false;
            this.buttonGiveup.Click += new System.EventHandler(this.buttonGiveup_Click);
            // 
            // FormAdminStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 490);
            this.Controls.Add(this.buttonGiveup);
            this.Controls.Add(this.buttonpost);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxEnrolltime);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxMailbox);
            this.Controls.Add(this.labelenrolltime);
            this.Controls.Add(this.labelmailbox);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdminStu";
            this.Text = "FormAdminStu";
            this.Load += new System.EventHandler(this.FormAdminStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private DataGridView dataGridView;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox textBoxEnrolltime;
        private TextBox textBoxDepartment;
        private TextBox textBoxMailbox;
        private Label labelenrolltime;
        private Label labelmailbox;
        private Label labelgender;
        private Label labelDepartment;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxClass;
        private Label label1;
        private Button buttonpost;
        private Button buttonQuery;
        private Button buttonGiveup;
    }
}
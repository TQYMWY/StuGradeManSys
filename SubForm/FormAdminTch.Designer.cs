namespace StuGradeManSys.SubForm
{
    partial class FormAdminTch
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
            this.buttonQuery = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.labelmailbox = new System.Windows.Forms.Label();
            this.labelenrolltime = new System.Windows.Forms.Label();
            this.textBoxMailbox = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxEnrolltime = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.buttonpost = new System.Windows.Forms.Button();
            this.buttonGiveup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(447, 20);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(385, 59);
            this.labelInfo.TabIndex = 24;
            this.labelInfo.Text = "教师信息管理模块";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(98, 98);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1127, 547);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(1268, 238);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(276, 51);
            this.buttonQuery.TabIndex = 26;
            this.buttonQuery.Text = "刷新";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(98, 699);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(123, 35);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "教工号：";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(249, 696);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(276, 42);
            this.textBoxUserID.TabIndex = 38;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(758, 699);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(276, 42);
            this.textBoxName.TabIndex = 40;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(601, 699);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 35);
            this.labelName.TabIndex = 39;
            this.labelName.Text = "姓名：";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(1115, 699);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(96, 35);
            this.labelDepartment.TabIndex = 41;
            this.labelDepartment.Text = "系别：";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(98, 792);
            this.labelgender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(96, 35);
            this.labelgender.TabIndex = 42;
            this.labelgender.Text = "性别：";
            // 
            // labelmailbox
            // 
            this.labelmailbox.AutoSize = true;
            this.labelmailbox.Location = new System.Drawing.Point(601, 792);
            this.labelmailbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelmailbox.Name = "labelmailbox";
            this.labelmailbox.Size = new System.Drawing.Size(96, 35);
            this.labelmailbox.TabIndex = 43;
            this.labelmailbox.Text = "邮箱：";
            // 
            // labelenrolltime
            // 
            this.labelenrolltime.AutoSize = true;
            this.labelenrolltime.Location = new System.Drawing.Point(1115, 792);
            this.labelenrolltime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelenrolltime.Name = "labelenrolltime";
            this.labelenrolltime.Size = new System.Drawing.Size(150, 35);
            this.labelenrolltime.TabIndex = 44;
            this.labelenrolltime.Text = "入职日期：";
            // 
            // textBoxMailbox
            // 
            this.textBoxMailbox.Location = new System.Drawing.Point(758, 789);
            this.textBoxMailbox.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMailbox.Name = "textBoxMailbox";
            this.textBoxMailbox.ReadOnly = true;
            this.textBoxMailbox.Size = new System.Drawing.Size(276, 42);
            this.textBoxMailbox.TabIndex = 45;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(1268, 699);
            this.textBoxDepartment.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.ReadOnly = true;
            this.textBoxDepartment.Size = new System.Drawing.Size(276, 42);
            this.textBoxDepartment.TabIndex = 46;
            // 
            // textBoxEnrolltime
            // 
            this.textBoxEnrolltime.Location = new System.Drawing.Point(1268, 792);
            this.textBoxEnrolltime.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEnrolltime.Name = "textBoxEnrolltime";
            this.textBoxEnrolltime.ReadOnly = true;
            this.textBoxEnrolltime.Size = new System.Drawing.Size(276, 42);
            this.textBoxEnrolltime.TabIndex = 47;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(249, 790);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(73, 39);
            this.radioButtonMale.TabIndex = 48;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "男";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(425, 788);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(73, 39);
            this.radioButtonFemale.TabIndex = 49;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "女";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonpost
            // 
            this.buttonpost.Location = new System.Drawing.Point(1268, 474);
            this.buttonpost.Margin = new System.Windows.Forms.Padding(5);
            this.buttonpost.Name = "buttonpost";
            this.buttonpost.Size = new System.Drawing.Size(276, 51);
            this.buttonpost.TabIndex = 50;
            this.buttonpost.Text = "确认";
            this.buttonpost.UseVisualStyleBackColor = true;
            this.buttonpost.Visible = false;
            this.buttonpost.Click += new System.EventHandler(this.buttonpost_Click);
            // 
            // buttonGiveup
            // 
            this.buttonGiveup.Location = new System.Drawing.Point(1268, 594);
            this.buttonGiveup.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGiveup.Name = "buttonGiveup";
            this.buttonGiveup.Size = new System.Drawing.Size(276, 51);
            this.buttonGiveup.TabIndex = 51;
            this.buttonGiveup.Text = "放弃";
            this.buttonGiveup.UseVisualStyleBackColor = true;
            this.buttonGiveup.Visible = false;
            this.buttonGiveup.Click += new System.EventHandler(this.buttonGiveup_Click);
            // 
            // FormAdminTch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 867);
            this.Controls.Add(this.buttonGiveup);
            this.Controls.Add(this.buttonpost);
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
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAdminTch";
            this.Text = "FormAdminTch";
            this.Load += new System.EventHandler(this.FormAdminTch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private DataGridView dataGridView;
        private Button buttonQuery;
        private Label labelID;
        private TextBox textBoxUserID;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelDepartment;
        private Label labelgender;
        private Label labelmailbox;
        private Label labelenrolltime;
        private TextBox textBoxMailbox;
        private TextBox textBoxDepartment;
        private TextBox textBoxEnrolltime;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button buttonpost;
        private Button buttonGiveup;
    }
}
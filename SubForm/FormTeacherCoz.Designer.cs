namespace StuGradeManSys.SubForm
{
    partial class FormTeacherCoz
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.comboBoxCredit = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(575, 371);
            this.dataGridView.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelInfo.Location = new System.Drawing.Point(337, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(165, 33);
            this.labelInfo.TabIndex = 41;
            this.labelInfo.Text = "课程开设模块";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHint.Location = new System.Drawing.Point(12, 44);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(259, 20);
            this.labelHint.TabIndex = 42;
            this.labelHint.Text = "已开设课程：(如需删除请联系管理员)";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(593, 95);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(84, 20);
            this.labelId.TabIndex = 43;
            this.labelId.Text = "课程编号：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(593, 148);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 20);
            this.labelName.TabIndex = 44;
            this.labelName.Text = "课程名称：";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(593, 201);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(84, 20);
            this.labelTerm.TabIndex = 45;
            this.labelTerm.Text = "开课学期：";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(593, 254);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(84, 20);
            this.labelCredit.TabIndex = 46;
            this.labelCredit.Text = "课程学分：";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(593, 307);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(84, 20);
            this.labelType.TabIndex = 47;
            this.labelType.Text = "课程类型：";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(654, 377);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 48;
            this.buttonAdd.Text = "添加课程";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxId.Location = new System.Drawing.Point(683, 92);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(125, 27);
            this.textBoxId.TabIndex = 49;
            this.textBoxId.Text = "自动生成";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(683, 145);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 50;
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxTerm.Location = new System.Drawing.Point(683, 198);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(125, 28);
            this.comboBoxTerm.TabIndex = 51;
            // 
            // comboBoxCredit
            // 
            this.comboBoxCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCredit.FormattingEnabled = true;
            this.comboBoxCredit.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCredit.Location = new System.Drawing.Point(683, 251);
            this.comboBoxCredit.Name = "comboBoxCredit";
            this.comboBoxCredit.Size = new System.Drawing.Size(125, 28);
            this.comboBoxCredit.TabIndex = 52;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "",
            "compulsory",
            "elective"});
            this.comboBoxType.Location = new System.Drawing.Point(683, 307);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(125, 28);
            this.comboBoxType.TabIndex = 53;
            // 
            // FormTeacherCoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCredit);
            this.Controls.Add(this.comboBoxTerm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormTeacherCoz";
            this.Text = "FormTeacherStuGrade";
            this.Load += new System.EventHandler(this.FormTeacherCoz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private Label labelInfo;
        private Label labelHint;
        private Label labelId;
        private Label labelName;
        private Label labelTerm;
        private Label labelCredit;
        private Label labelType;
        private Button buttonAdd;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private ComboBox comboBoxTerm;
        private ComboBox comboBoxCredit;
        private ComboBox comboBoxType;
    }
}
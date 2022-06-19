using StuGradeManSys.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuGradeManSys.SubForm
{
    public partial class FormAdminTch : Form
    {
        DataTable dt;
        public FormAdminTch()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        //flushData刷新界面展示数据
        private void flushData()
        {
            dt.Rows.Clear();

            var teacherTable = FormMain.TeacherService.GetEntities();
            if (teacherTable == null || teacherTable.Rows.Count == 0) return;

            for (int i = 0; i < teacherTable.Rows.Count; i++)
            {
                var teaID = teacherTable.Rows[i]["ID"];
                var teaName = teacherTable.Rows[i]["Name"];
                var teaDepartment = teacherTable.Rows[i]["Department"];
                var teaGender = teacherTable.Rows[i]["Gender"];
                var teaMailbox = teacherTable.Rows[i]["Mailbox"];
                var teaEnrollTime = teacherTable.Rows[i]["EnrollTime"];
                dt.Rows.Add(teaID, teaName, teaDepartment, teaGender, teaMailbox, teaEnrollTime);
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        //load函数刷新界面和提供删除的那一列
            private void FormAdminTch_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("教工号");
            dt.Columns.Add("教师姓名");
            dt.Columns.Add("系别");
            dt.Columns.Add("性别");
            dt.Columns.Add("邮箱");
            dt.Columns.Add("入职时间");
            dataGridView.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelectDelete";
            btn.HeaderText = "  ";
            btn.DefaultCellStyle.NullValue = "删除";
            dataGridView.Columns.Add(btn);
            dataGridView.AllowUserToAddRows = false;
            //btn2为更新按钮
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Name = "btnSelectUpdate";
            btn2.HeaderText = "  ";
            btn2.DefaultCellStyle.NullValue = "更新";
            dataGridView.Columns.Add(btn2);
            dataGridView.AllowUserToAddRows = false;
            flushData();
        }

        //刷新展示数据
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            flushData();
        }

        //删除教师信息
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectDelete" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var tch = new Teacher();
                tch.ID = Convert.ToInt64(row["教工号"].ToString());
                tch.Name = row["教师姓名"].ToString();
                tch.Department = row["系别"].ToString();
                tch.Gender = row["性别"].ToString();
                tch.Mailbox = row["邮箱"].ToString();

                var tmp_user = new User();
                tmp_user.ID = tch.ID;
                //同时删除User表中的教师信息
                if (FormMain.TeacherService.DeleteEntity(tch) && FormMain.UserService.DeleteEntity(tmp_user))
                    MessageBox.Show("教师离职，成功删除信息");
                flushData();
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectUpdate" && e.RowIndex >= 0)
            {
                MessageBox.Show("请在下方表单里更新新的教师信息并确认！");
                var row = dt.Rows[e.RowIndex];
                textBoxUserID.Text = row["教工号"].ToString();
                textBoxName.Text = row["教师姓名"].ToString();
                textBoxDepartment.Text = row["系别"].ToString();
                textBoxMailbox.Text = row["邮箱"].ToString();
                textBoxEnrolltime.Text = row["入职时间"].ToString();
                if(row["性别"].ToString() == "male")
                {
                    radioButtonMale.Checked = true;
                }
                if (row["性别"].ToString() == "female")
                {
                    radioButtonFemale.Checked = true;
                }
                textBoxName.ReadOnly = false;
                textBoxDepartment.ReadOnly = false;
                textBoxMailbox.ReadOnly = false;
                textBoxEnrolltime.ReadOnly = false;
                buttonpost.Visible = true;
                buttonGiveup.Visible = true;
            }
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxUserID.Text;
            string getName = textBoxName.Text;
            string getDpt = textBoxDepartment.Text;
            string getMail = textBoxMailbox.Text;
            string getEnrolltime = textBoxEnrolltime.Text;
            if ((getID.Length == 0) || (getName.Length == 0))
            {
                MessageBox.Show("请检查教工号和姓名栏是否为空");
                //TTeacher表中只有ID和姓名不能为null，我们只需要确保这两项不为空即可push
            }
            else
            { 
                    var temp_Newteacher = new Teacher();
                    temp_Newteacher.ID = Convert.ToInt64(getID);
                    temp_Newteacher.Name = getName;
                    temp_Newteacher.Department = getDpt;
                    if (radioButtonMale.Checked)
                        temp_Newteacher.Gender = "male";
                    if (radioButtonFemale.Checked)
                        temp_Newteacher.Gender = "female";
                    temp_Newteacher.Mailbox = getMail;
                    try
                    {
                        temp_Newteacher.EnrollTime = Convert.ToDateTime(getEnrolltime);
                    }
                    catch
                    {
                        MessageBox.Show("日期输入格式不正确，请检查并修正！");
                        return;
                    }
                    //try catch目的是将string转换为日期格式，对于不合法的日期弹窗警告
                    if (FormMain.TeacherService.PostEntity(temp_Newteacher))
                        MessageBox.Show("成功更新教师信息！");
                    textBoxUserID.Text = "";
                    textBoxName.Text = "";
                    textBoxDepartment.Text = "";
                    textBoxMailbox.Text = "";
                    textBoxEnrolltime.Text = "";
                    radioButtonMale.Checked = radioButtonFemale.Checked = false;
                    textBoxName.ReadOnly = true;
                    textBoxDepartment.ReadOnly = true;
                    textBoxMailbox.ReadOnly = true;
                    textBoxEnrolltime.ReadOnly = true;
                    buttonpost.Visible = false;
                    buttonGiveup.Visible = false;
            }
            flushData();
        }

        private void buttonGiveup_Click(object sender, EventArgs e)
        {
            textBoxUserID.Text = "";
            textBoxName.Text = "";
            textBoxDepartment.Text = "";
            textBoxMailbox.Text = "";
            textBoxEnrolltime.Text = "";
            radioButtonMale.Checked = radioButtonFemale.Checked = false;
            textBoxName.ReadOnly = true;
            textBoxDepartment.ReadOnly = true;
            textBoxMailbox.ReadOnly = true;
            textBoxEnrolltime.ReadOnly = true;
            buttonpost.Visible = false;
            buttonGiveup.Visible = false;
        }
    }
}

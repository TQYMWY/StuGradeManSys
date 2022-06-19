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
    public partial class FormAdminStu : Form
    {
        DataTable dt;
        public FormAdminStu()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void flushData()
        {
            dt.Rows.Clear();

            var stuTable = FormMain.StudentService.GetEntities();
            if (stuTable == null || stuTable.Rows.Count == 0) return;

            for (int i = 0; i < stuTable.Rows.Count; i++)
            {
                var stuID = stuTable.Rows[i]["ID"];
                var stuName = stuTable.Rows[i]["Name"];
                var stuClass = stuTable.Rows[i]["Class"];
                var stuDepartment = stuTable.Rows[i]["Department"];
                var stuGender = stuTable.Rows[i]["Gender"];
                var stuMailbox = stuTable.Rows[i]["Mailbox"];
                var stuEnrollTime = stuTable.Rows[i]["EnrollTime"];
                dt.Rows.Add(stuID, stuName, stuClass, stuDepartment, stuGender, stuMailbox, stuEnrollTime);
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void FormAdminStu_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("学号");
            dt.Columns.Add("姓名");
            dt.Columns.Add("班级");
            dt.Columns.Add("系别");
            dt.Columns.Add("性别");
            dt.Columns.Add("邮箱");
            dt.Columns.Add("入学时间");
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

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            flushData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectDelete" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];

                var sth = new Student();
                sth.ID = Convert.ToInt64(row["学号"].ToString());
                sth.Name = row["姓名"].ToString();
                sth.Class = row["班级"].ToString();
                sth.Department = row["系别"].ToString();
                sth.Gender = row["性别"].ToString();
                sth.Mailbox = row["邮箱"].ToString();

                var tmp_user = new User();
                tmp_user.ID = sth.ID;
                //此处一并删除User表中的信息
                if (FormMain.StudentService.DeleteEntity(sth) && FormMain.UserService.DeleteEntity(tmp_user))
                    MessageBox.Show("学生毕业，成功删除信息");
                flushData();
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectUpdate" && e.RowIndex >= 0)
            {
                MessageBox.Show("请在下方表单里更新新的学生信息并确认！");
                var row = dt.Rows[e.RowIndex];
                textBoxID.Text = row["学号"].ToString();
                textBoxName.Text = row["姓名"].ToString();
                textBoxClass.Text = row["班级"].ToString();
                textBoxDepartment.Text = row["系别"].ToString();
                textBoxMailbox.Text = row["邮箱"].ToString();
                textBoxEnrolltime.Text = row["入学时间"].ToString();
                if (row["性别"].ToString() == "male")
                {
                    radioButtonMale.Checked = true;
                }
                if (row["性别"].ToString() == "female")
                {
                    radioButtonFemale.Checked = true;
                }
                textBoxName.ReadOnly = false;
                textBoxClass.ReadOnly = false;
                textBoxDepartment.ReadOnly = false;
                textBoxMailbox.ReadOnly = false;
                textBoxEnrolltime.ReadOnly = false;
                buttonpost.Visible = true;
                buttonGiveup.Visible = true;
            }
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxID.Text;
            string getName = textBoxName.Text;
            string getClass = textBoxClass.Text;
            string getDpt = textBoxDepartment.Text;
            string getMail = textBoxMailbox.Text;
            string getEnrolltime = textBoxEnrolltime.Text;
            if ((getID.Length == 0) || (getName.Length == 0))
            {
                MessageBox.Show("请检查学号和姓名栏是否为空");
                //TStudent表中只有ID和姓名不能为null，我们只需要确保这两项不为空即可push
            }
            else
            {
                var temp_Newstudent = new Student();
                temp_Newstudent.ID = Convert.ToInt64(getID);
                temp_Newstudent.Name = getName;
                temp_Newstudent.Class = getClass;
                temp_Newstudent.Department = getDpt;
                if (radioButtonMale.Checked)
                    temp_Newstudent.Gender = "male";
                if (radioButtonFemale.Checked)
                    temp_Newstudent.Gender = "female";
                temp_Newstudent.Mailbox = getMail;
                try
                {
                    temp_Newstudent.EnrollTime = Convert.ToDateTime(getEnrolltime);
                }
                catch
                {
                    MessageBox.Show("日期输入格式不正确，请检查并修正！");
                    return;
                }
                //try catch目的是将string转换为日期格式，对于不合法的日期弹窗警告
                if (FormMain.StudentService.PostEntity(temp_Newstudent))
                    MessageBox.Show("成功更新学生信息！");
                textBoxID.Text = "";
                textBoxName.Text = "";
                textBoxClass.Text = "";
                textBoxDepartment.Text = "";
                textBoxMailbox.Text = "";
                textBoxEnrolltime.Text = "";
                radioButtonMale.Checked = radioButtonFemale.Checked = false;
                textBoxName.ReadOnly = true;
                textBoxClass.ReadOnly = true;
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
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxClass.Text = "";
            textBoxDepartment.Text = "";
            textBoxMailbox.Text = "";
            textBoxEnrolltime.Text = "";
            radioButtonMale.Checked = radioButtonFemale.Checked = false;
            textBoxName.ReadOnly = true;
            textBoxClass.ReadOnly = true;
            textBoxDepartment.ReadOnly = true;
            textBoxMailbox.ReadOnly = true;
            textBoxEnrolltime.ReadOnly = true;
            buttonpost.Visible = false;
            buttonGiveup.Visible = false;
        }
    }
}

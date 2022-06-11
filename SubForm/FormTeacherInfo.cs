using StuGradeManSys.Entities;
using StuGradeManSys.Utils;

namespace StuGradeManSys.SubForm
{
    public partial class FormTeacherInfo : Form
    {
        User user;
        Teacher teacher;
        public FormTeacherInfo()
        {
            InitializeComponent();
            user = FormMain.User.Copy<User>();

            teacher = FormTeacher.Teacher.Copy<Teacher>();
        }
        private void FormTeacherInfo_Load(object sender, EventArgs e)
        {
            this.textBoxID.Text = FormMain.User.ID.ToString();
            this.textBoxName.Text = FormMain.User.Name.ToString();
            this.textBoxPwd.Text = "********";
            this.textBoxRole.Text = FormMain.User.Role.ToString();

            this.textBoxDept.Text = FormTeacher.Teacher.Department.ToString();
            this.textBoxGender.Text = FormTeacher.Teacher.Gender.ToString();
            this.textBoxMail.Text = FormTeacher.Teacher.Mailbox.ToString();
            this.textBoxTime.Text = FormTeacher.Teacher.EnrollTime.ToString("yyyy/MM/dd");

        }

        private void labelChangePwd_Click(object sender, EventArgs e)
        {
            labelChangePwd.Text = "再次输入密码：";
            labelChangePwd.ForeColor = Color.Black;
            textBoxPwd.ReadOnly = false;
            textBoxPwd.Text = "";
            textBoxPwd.Enabled = true;
            textBoxRePwd.Visible = true;
            buttonChangeInfo.Visible = false;
            buttonSave.Visible = true;
            buttonGiveUp.Visible = true;
        }
        private void checkPwd()
        {
            if (textBoxPwd.Text != textBoxRePwd.Text)
            {
                labelHint.Visible = true;
            }
            else
            {
                labelHint.Visible = false;
                user.Pwd = textBoxRePwd.Text.Trim();
            }
        }
        private void textBoxRePwd_Leave(object sender, EventArgs e)
        {
            checkPwd();
        }
        private void textBoxPwd_Leave(object sender, EventArgs e)
        {
            checkPwd();
        }
        private void getUserInfoBack()
        {
            labelChangePwd.Text = "修改密码";
            labelChangePwd.ForeColor = Color.Blue;
            textBoxPwd.ReadOnly = true;
            textBoxPwd.Text = "********";
            textBoxPwd.Enabled = false;
            textBoxRePwd.Visible = false;
            buttonChangeInfo.Visible = true;
            buttonSave.Visible = false;
            buttonGiveUp.Visible = false;

            textBoxRePwd.Text = "";
            labelHint.Visible = false;

            this.textBoxDept.Text = FormTeacher.Teacher.Department.ToString();
            this.textBoxGender.Text = FormTeacher.Teacher.Gender.ToString();
            this.textBoxMail.Text = FormTeacher.Teacher.Mailbox.ToString();
            textBoxDept.ReadOnly = true;
            textBoxGender.ReadOnly = true;
            textBoxMail.ReadOnly = true;
        }
        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            user = FormMain.User.Copy<User>();
            teacher = FormMain.User.Copy<Teacher>();
            getUserInfoBack();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (user.Pwd != FormMain.User.Pwd)
            {
                if (FormMain.UserService.PostEntity(user))
                    FormMain.User.Pwd = user.Pwd;
            }
            teacher.Department = textBoxDept.Text.Trim();
            teacher.Gender = textBoxGender.Text.Trim();
            teacher.Mailbox = textBoxMail.Text.Trim();
            if (FormMain.TeacherService.PostEntity(teacher))
            {
                FormTeacher.Teacher.Department = textBoxDept.Text.Trim();
                FormTeacher.Teacher.Gender = textBoxGender.Text.Trim();
                FormTeacher.Teacher.Mailbox = textBoxMail.Text.Trim();
            }
            getUserInfoBack();
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            textBoxDept.ReadOnly = false;
            textBoxGender.ReadOnly = false;
            textBoxMail.ReadOnly = false;
            buttonSave.Visible = true;
            buttonGiveUp.Visible = true;
        }


    }
}

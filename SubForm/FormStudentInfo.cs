using StuGradeManSys.Entities;
using StuGradeManSys.Utils;

namespace StuGradeManSys.SubForm
{
    public partial class FormStudentInfo : Form
    {
        User user;
        Student student;
        public FormStudentInfo()
        {
            InitializeComponent();
            user = FormMain.User.Copy<User>();
            student = FormStudent.Student.Copy<Student>();
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            this.textBoxID.Text = FormMain.User.ID.ToString();
            this.textBoxName.Text = FormMain.User.Name.ToString();
            this.textBoxPwd.Text = "********";
            this.textBoxRole.Text = FormMain.User.Role.ToString();

            this.textBoxClass.Text = FormStudent.Student.Class.ToString();
            this.textBoxDept.Text = FormStudent.Student.Department.ToString();
            this.textBoxGender.Text = FormStudent.Student.Gender.ToString();
            this.textBoxMail.Text = FormStudent.Student.Mailbox.ToString();
            this.textBoxTime.Text = FormStudent.Student.EnrollTime.ToString("yyyy/MM/dd");
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

            this.textBoxClass.Text = FormStudent.Student.Class.ToString();
            this.textBoxDept.Text = FormStudent.Student.Department.ToString();
            this.textBoxGender.Text = FormStudent.Student.Gender.ToString();
            this.textBoxMail.Text = FormStudent.Student.Mailbox.ToString();
            textBoxClass.ReadOnly = true;
            textBoxDept.ReadOnly = true;
            textBoxGender.ReadOnly = true;
            textBoxMail.ReadOnly = true;
        }
        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            user = FormMain.User.Copy<User>();
            student = FormStudent.Student.Copy<Student>();
            getUserInfoBack();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (user.Pwd != FormMain.User.Pwd)
            {
                if (FormMain.UserService.PostEntity(user))
                    FormMain.User.Pwd = user.Pwd;
            }
            student.Department = textBoxDept.Text.Trim();
            student.Gender = textBoxGender.Text.Trim();
            student.Class = textBoxClass.Text.Trim();
            student.Mailbox = textBoxMail.Text.Trim();
            if (FormMain.StudentService.PostEntity(student))
            {
                FormStudent.Student.Department = textBoxDept.Text.Trim();
                FormStudent.Student.Gender = textBoxGender.Text.Trim();
                FormStudent.Student.Class = textBoxClass.Text.Trim();
                FormStudent.Student.Mailbox = textBoxMail.Text.Trim();
            }
            getUserInfoBack();
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            textBoxClass.ReadOnly = false;
            textBoxDept.ReadOnly = false;
            textBoxGender.ReadOnly = false;
            textBoxMail.ReadOnly = false;
            buttonSave.Visible = true;
            buttonGiveUp.Visible = true;
        }
    }
}

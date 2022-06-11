using StuGradeManSys.Databases;
using StuGradeManSys.Entities;
using StuGradeManSys.Services;
using StuGradeManSys.SubForm;
using StuGradeManSys.Utils;
namespace StuGradeManSys
{
    public partial class FormMain : Form
    {
        public static User User = new User();
        public static UserService UserService = new UserService();
        public static AdminService AdminService = new AdminService();
        public static StudentService StudentService = new StudentService();
        public static TeacherService TeacherService = new TeacherService();
        public static CourseService CourseService = new CourseService();
        public static StuCozService StuCozService = new StuCozService();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (DataBase.Connect() != true)
            {
                MessageBox.Show("数据库连接失败！");
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.Disconnect();
        }

        private void buttonLoginOrLogout_Click(object sender, EventArgs e)
        {
            if (User.ID > 0)
            {
                User.ID = -1;
                flushInfo();
                return;
            }
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();
        }
        
        public void flushInfo()
        {
            if (User.ID > 0)
            {
                labelID.Text = "ID：" + User.ID.ToString();
                labelName.Text = "姓名：" + User.Name.ToString();
                labelRole.Text = "角色：" + User.Role.ToString();
                buttonLoginOrLogout.Text = "登出";
                buttonLoginOrLogout.ForeColor = Color.Blue;
                switch (User.Role)
                {
                    case "administrator":
                        panelSubForm.OpenForm(new FormAdmin());
                        break;
                    case "student":
                        panelSubForm.OpenForm(new FormStudent());
                        break;
                    case "teacher":
                        panelSubForm.OpenForm(new FormTeacher());
                        break;
                    default:
                        break;
                }
            }
            else
            {
                labelID.Text = "ID：";
                labelName.Text = "姓名：";
                labelRole.Text = "角色：";
                buttonLoginOrLogout.Text = "登录";
                buttonLoginOrLogout.ForeColor = Color.Black;
                panelSubForm.CloseForm();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            User = new User();
            User.ID = 10000002;
            User.Name = "stuTest";
            User.Role = "student";
            User.Pwd = "123456";
            flushInfo();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            User = new User();
            User.ID = 10000003;
            User.Name = "teacherTest";
            User.Role = "teacher";
            User.Pwd = "123456";
            flushInfo();
        }

        private void buttonTest3_Click(object sender, EventArgs e)
        {
            User = new User();
            User.ID = 10000001;
            User.Name = "admin";
            User.Role = "administrator";
            User.Pwd = "123456";
            flushInfo();
        }
    }
}

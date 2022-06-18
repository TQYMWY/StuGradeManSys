using StuGradeManSys.Entities;
using StuGradeManSys.Utils;

namespace StuGradeManSys.SubForm
{
    public partial class FormTeacher : Form
    {
        public static Teacher Teacher = new Teacher();
        public FormTeacher()
        {
            InitializeComponent();
        }

        private bool CheckInfo()
        {
            if (Teacher.Gender == string.Empty || Teacher.Mailbox == string.Empty || Teacher.Department == string.Empty)
                return false;
            return true;
        }
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            var tch = FormMain.TeacherService.GetEntity(FormMain.User.ID);
            if (tch == null)
            {
                MessageBox.Show("数据库出错");
                this.Close();
                return;
            }
            Teacher = tch;
            panel.OpenForm(new FormTeacherInfo());
        }

        private void InfoManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormTeacherInfo());
        }

        private void GradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormTeacherGrade());
        }

        private void OpenCozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormTeacherCoz());
        }

        private void StuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormTeacherStuInfo());
        }
    }
}

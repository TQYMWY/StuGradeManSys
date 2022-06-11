using StuGradeManSys.Entities;
using StuGradeManSys.Services;
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

        private void FormTeacher_Load(object sender, EventArgs e)
        {

            panel.OpenForm(new FormTeacherInfo());
        }

        private void InfoManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormTeacherInfo());
        }

        private void GradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormTeacherGrade());
        }

        private void StuInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormTeacherStuInfo());
        }

        private void StuGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormTeacherStuGrade());
        }
    }
}

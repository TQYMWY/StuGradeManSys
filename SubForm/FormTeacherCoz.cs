using StuGradeManSys.Entities;
using System.Data;

namespace StuGradeManSys.SubForm
{
    public partial class FormTeacherCoz : Form
    {
        DataTable cozDt;
        public FormTeacherCoz()
        {
            InitializeComponent();
            cozDt = new DataTable();
        }

        private void FormTeacherCoz_Load(object sender, EventArgs e)
        {
            cozDt.Columns.Add("课程编号");
            cozDt.Columns.Add("课程名称");
            cozDt.Columns.Add("开课学期");
            cozDt.Columns.Add("课程学分");
            cozDt.Columns.Add("课程类型");
            dataGridView.DataSource = cozDt;
            dataGridView.AllowUserToAddRows = false;
            showCourses();
        }
        private void showCourses()
        {
            cozDt.Rows.Clear();
            var courseTable = FormMain.CourseService.GetEntities();
            if (courseTable == null || courseTable.Rows.Count == 0) return;
            for (int i = 0; i < courseTable.Rows.Count; i++)
            {
                var tchId = Convert.ToInt64(courseTable.Rows[i]["TeacherId"]);
                if (tchId != FormTeacher.Teacher.ID) continue;
                var cozId = courseTable.Rows[i]["ID"];
                var cozName = courseTable.Rows[i]["Name"];
                var cozTerm = courseTable.Rows[i]["Term"];
                var cozCredit = courseTable.Rows[i]["Credit"];
                var cozType = courseTable.Rows[i]["Type"];
                cozDt.Rows.Add(cozId, cozName, cozTerm, cozCredit, cozType);
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var cozId = FormMain.CourseService.GetNextId();
            var cozName = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(cozName)) return;
            var cozTerm = Convert.ToInt32(comboBoxTerm.Text.Trim());
            if (cozTerm == 0) return;
            var cozCredit = Convert.ToInt32(comboBoxCredit.Text.Trim());
            if (cozCredit == 0) return;
            var cozType = comboBoxType.Text.Trim();
            if (string.IsNullOrEmpty(cozType)) return;
            if (FormMain.CourseService.PostEntity(new Course(cozId, cozName, FormTeacher.Teacher.ID, cozCredit, cozTerm, cozType)))
            {
                MessageBox.Show("成功添加课程");
                textBoxName.Text = "";
                comboBoxTerm.Text = "";
                comboBoxCredit.Text = "";
                comboBoxType.Text = "";
            }
            showCourses();
        }
    }
}

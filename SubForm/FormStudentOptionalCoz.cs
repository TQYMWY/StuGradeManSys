using StuGradeManSys.Entities;
using System.Data;

namespace StuGradeManSys.SubForm
{
    public partial class FormStudentOptionalCoz : Form
    {
        DataTable dt;
        public FormStudentOptionalCoz()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        private void flushData()
        {
            dt.Rows.Clear();
            var courseTable = FormMain.CourseService.GetEntities();
            if (courseTable == null || courseTable.Rows.Count == 0) return;
            var teacherTable = FormMain.TeacherService.GetEntities();
            if (teacherTable == null || teacherTable.Rows.Count == 0) return;
            var stuCozTable = FormMain.StuCozService.GetEntitiesBylimits("StudentId=" + FormStudent.Student.ID);
            if (stuCozTable == null || stuCozTable.Rows.Count == 0) return;
            for (int i = 0; i < courseTable.Rows.Count; i++)
            {
                var cozId = courseTable.Rows[i]["ID"];

                if (stuCozTable.Select("CourseId=" + cozId).Length > 0) continue;

                var cozName = courseTable.Rows[i]["Name"];
                var tchId = courseTable.Rows[i]["TeacherId"];
                var tchName = teacherTable.Select("ID=" + tchId)[0]["Name"];
                var cozTerm = courseTable.Rows[i]["Term"];
                var cozCredit = courseTable.Rows[i]["Credit"];
                var cozType = courseTable.Rows[i]["Type"];
                dt.Rows.Add(cozId, cozName, tchName, cozTerm, cozCredit, cozType);
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void FormStudentOptionalCoz_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("课程编号");
            dt.Columns.Add("课程名称");
            dt.Columns.Add("任课教师");
            dt.Columns.Add("开课学期");
            dt.Columns.Add("课程学分");
            dt.Columns.Add("课程类型");
            dataGridView.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelect";
            btn.HeaderText = "  ";
            btn.DefaultCellStyle.NullValue = "选课";
            dataGridView.Columns.Add(btn);
            dataGridView.AllowUserToAddRows = false;
            flushData();
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            flushData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelect" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var cozId = Convert.ToInt64(row["课程编号"].ToString());
                var stuId = FormStudent.Student.ID;
                int grade = -1;
                long id = FormMain.StuCozService.GetNextId();
                if (FormMain.StuCozService.PostEntity(new StuCoz(id, stuId, cozId, grade)))
                    MessageBox.Show("成功选课");
                flushData();
            }
        }
    }
}

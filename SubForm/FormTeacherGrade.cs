using System.Data;

namespace StuGradeManSys.SubForm
{
    public partial class FormTeacherGrade : Form
    {
        DataTable cozDt, stuDt;
        long CozId;
        string? CozName;

        public FormTeacherGrade()
        {
            InitializeComponent();
            cozDt = new DataTable();
            stuDt = new DataTable();
        }
        private void FormTeacherGrade_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
            cozDt.Columns.Add("课程编号");
            cozDt.Columns.Add("课程名称");
            cozDt.Columns.Add("开课学期");
            cozDt.Columns.Add("课程学分");
            cozDt.Columns.Add("课程类型");

            stuDt.Columns.Add("学生编号");
            stuDt.Columns.Add("学生姓名");
            stuDt.Columns.Add("学生系别");
            showCourses();
        }
        private void showCourses()
        {
            cozDt.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = cozDt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelect";
            btn.HeaderText = " ";
            btn.DefaultCellStyle.NullValue = "录入该课程";
            dataGridView.Columns.Add(btn);

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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelect" && e.RowIndex >= 0)
            {
                var row = cozDt.Rows[e.RowIndex];
                CozId = Convert.ToInt64(row["课程编号"].ToString());
                CozName = row["课程名称"].ToString();
                showStudents();
                buttonBack.Visible = true;

                labelHint.Text = "课程编号：" + CozId + "  课程名称：" + CozName;
            }
            else if (dataGridView.Columns[e.ColumnIndex].Name == "btnEnter" && e.RowIndex >= 0)
            {
                var row = stuDt.Rows[e.RowIndex];
                var stuId = Convert.ToInt64(row["学生编号"].ToString());
                var stuCozTable = FormMain.StuCozService.GetEntities();
                if (stuCozTable == null || stuCozTable.Rows.Count == 0) return;
                var stuCozId = stuCozTable.Select("StudentId=" + stuId + " and CourseId=" + CozId)[0]["ID"];
                var stuCoz = FormMain.StuCozService.GetEntity(Convert.ToInt64(stuCozId));
                if (stuCoz == null) return;
                string? grade = "";
                var temp = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value;
                if (temp == null) grade = "-1";
                else grade = temp.ToString();
                stuCoz.Grade = Convert.ToInt32(grade);
                FormMain.StuCozService.PostEntity(stuCoz);
                flushStudents();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            showCourses();
            buttonBack.Visible = false;
            labelHint.Text = "请选择所开设课程进行成绩录入";
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name != "grade")
            {
                e.Cancel = true;
            }    
        }

        private void flushStudents()
        {
            stuDt.Rows.Clear();
            var stuTable = FormMain.StudentService.GetEntities();
            if (stuTable == null || stuTable.Rows.Count == 0) return;
            var stuCozTable = FormMain.StuCozService.GetEntitiesBylimits("CourseId=" + CozId);
            if (stuCozTable == null || stuCozTable.Rows.Count == 0) return;
            for (int i = 0; i < stuCozTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(stuCozTable.Rows[i]["Grade"]) != -1) continue;
                var stuId = stuCozTable.Rows[i]["StudentId"];
                var row = stuTable.Select("ID=" + stuId)[0];
                var stuName = row["Name"];
                var stuDept = row["Department"];
                stuDt.Rows.Add(stuId, stuName, stuDept);
            }
        }
        private void showStudents()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = stuDt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnEnter";
            btn.HeaderText = " ";
            btn.DefaultCellStyle.NullValue = "录入该生成绩";
            dataGridView.Columns.Add(btn);
            dataGridView.Columns.Add("grade", "成绩");

            flushStudents();
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}

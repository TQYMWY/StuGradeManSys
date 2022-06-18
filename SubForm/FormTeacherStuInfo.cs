using System.Data;

namespace StuGradeManSys.SubForm
{
    public partial class FormTeacherStuInfo : Form
    {
        DataTable cozDt, stuDt;
        long CozId;
        string? CozName;
        public FormTeacherStuInfo()
        {
            InitializeComponent();
            cozDt = new DataTable();
            stuDt = new DataTable();
        }
        private void FormTeacherStuInfo_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
            cozDt.Columns.Add("课程编号");
            cozDt.Columns.Add("课程名称");
            cozDt.Columns.Add("开课学期");
            cozDt.Columns.Add("课程学分");
            cozDt.Columns.Add("课程类型");

            stuDt.Columns.Add("学生编号");
            stuDt.Columns.Add("学生姓名");
            stuDt.Columns.Add("学生班级");
            stuDt.Columns.Add("学生系别");
            stuDt.Columns.Add("学生性别");
            stuDt.Columns.Add("学生邮箱");
            stuDt.Columns.Add("入学时间");
            stuDt.Columns.Add("学生成绩");
            showCourses();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            showCourses();
            buttonBack.Visible = false;
            labelHint.Text = "请选择所开设课程进行成绩录入";
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
        }

        private void showCourses()
        {
            cozDt.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = cozDt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelect";
            btn.HeaderText = " ";
            btn.DefaultCellStyle.NullValue = "查看该课程";
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

        private void showStudents()
        {
            stuDt.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = stuDt;

            var stuTable = FormMain.StudentService.GetEntities();
            if (stuTable == null || stuTable.Rows.Count == 0) return;
            var stuCozTable = FormMain.StuCozService.GetEntitiesBylimits("CourseId=" + CozId);
            if (stuCozTable == null || stuCozTable.Rows.Count == 0) return;
            for (int i = 0; i < stuCozTable.Rows.Count; i++)
            {
                var stuId = stuCozTable.Rows[i]["StudentId"];
                var row = stuTable.Select("ID=" + stuId)[0];
                var stuName = row["Name"];
                var stuClass = row["Class"];
                var stuDept = row["Department"];
                var stuGender = row["Gender"];
                var stuMail = row["Mailbox"];
                var stuEnrollTime = row["EnrollTime"];
                var stuGrade = stuCozTable.Rows[i]["Grade"].ToString();
                if (stuGrade == "-1") stuGrade = "未录入";
                
                stuDt.Rows.Add(stuId, stuName, stuClass, stuDept, stuGender, stuMail, stuEnrollTime, stuGrade);
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}

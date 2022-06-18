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
    public partial class FormAdminCoz : Form
    {
        DataTable dt;
        public FormAdminCoz()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void flushData()
        {
            dt.Rows.Clear();    

            var CourseTable = FormMain.CourseService.GetEntities();
            if (CourseTable == null || CourseTable.Rows.Count == 0) return;

            for (int i = 0; i < CourseTable.Rows.Count; i++)
            {
                var courseID = CourseTable.Rows[i]["ID"];
                var courseName = CourseTable.Rows[i]["Name"];
                var courseTeacherId = CourseTable.Rows[i]["TeacherId"];
                var courseCredit = CourseTable.Rows[i]["Credit"];
                var courseTerm = CourseTable.Rows[i]["Term"];
                var courseType = CourseTable.Rows[i]["Type"];
                dt.Rows.Add(courseID,courseName,courseTeacherId,courseCredit, courseTerm,courseType );
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void FormAdminCoz_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("课程id");
            dt.Columns.Add("课程名");
            dt.Columns.Add("授课教师id");
            dt.Columns.Add("学分");
            dt.Columns.Add("学期");
            dt.Columns.Add("课程类型");
            dataGridView.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelect";
            btn.HeaderText = "  ";
            btn.DefaultCellStyle.NullValue = "删除";
            dataGridView.Columns.Add(btn);
            dataGridView.AllowUserToAddRows = false;
            flushData();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            flushData();
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxCourseID.Text;
            string getName = textBoxName.Text;
            string getTeaID = textBoxTeacherID.Text;
            string getCredit = textBoxCredit.Text;
            string getTerm = textBoxTerm.Text;
            string getType = textBoxType.Text;
            if ((getID.Length == 0) || (getName.Length == 0) || (getTeaID.Length == 0) || (getCredit.Length == 0) || (getTerm.Length == 0) || (getType.Length == 0))
            {
                MessageBox.Show("请检查是否有输入框为空！");
            }
            else
            {
                    var temp_Newcourse = new Course();
                    temp_Newcourse.ID = Convert.ToInt64(getID);
                    temp_Newcourse.Name = getName;
                    temp_Newcourse.TeacherId = Convert.ToInt64(getTeaID);
                    temp_Newcourse.Credit = Convert.ToInt32(getCredit);
                    temp_Newcourse.Term = Convert.ToInt32(getTerm);
                    temp_Newcourse.Type = getType;
                if (FormMain.CourseService.PostEntity(temp_Newcourse))
                        MessageBox.Show("成功插入/更新用户信息！");

            }
            flushData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelect" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var temp_course = new Course();
                temp_course.ID = Convert.ToInt64(row["课程id"]);
                temp_course.Name = row["课程名"].ToString();
                temp_course.TeacherId = Convert.ToInt32(row["授课教师id"]);
                temp_course.Credit = Convert.ToInt32(row["学分"]);
                temp_course.Term = Convert.ToInt32(row["学期"]);
                temp_course.Type = row["课程类型"].ToString();
                //需要维护数据库完整性，有外键约束的情况下无法顺利删除，需要加判断
                if (FormMain.CourseService.DeleteEntity(temp_course))
                    MessageBox.Show("成功删除课程信息");
                flushData();
            }
        }
    }
}

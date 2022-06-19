using StuGradeManSys.Entities;
using StuGradeManSys.Services;
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
    public partial class FormStudentGrade : Form
    {
        string limits = "";
        DataTable dt;
        public FormStudentGrade()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void FormStudentGrade_Load(object sender, EventArgs e)
        {
            limits = "";
            dt.Columns.Add("课程编号");
            dt.Columns.Add("课程名称");
            dt.Columns.Add("任课教师");
            dt.Columns.Add("成绩");
            dt.Columns.Add("学分");
            dt.Columns.Add("类型");
            dt.Columns.Add("学期");
            dataGridView.DataSource = dt;
            dataGridView.AllowUserToAddRows = false;
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void updateLabels(int numCourse, int numCredit, int numComCourse, int numComCredit)
        {
            labelCourse.Text = "课程门数：" + numCourse;
            labelCredit.Text = "合计学分：" + numCredit;
            labelComCourse.Text = "必修门数：" + numComCourse;
            labelComCredit.Text = "必修学分：" + numComCredit;
            labelOptCourse.Text = "选修门数：" + (numCourse - numComCourse);
            labelOptCredit.Text = "选修学分：" + (numCredit - numComCredit);
        }
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            limits = "1=2";
            if (checkBox1.Checked) limits += " or Term=" + 1;
            if (checkBox2.Checked) limits += " or Term=" + 2;
            if (checkBox3.Checked) limits += " or Term=" + 3;
            if (checkBox4.Checked) limits += " or Term=" + 4;
            if (checkBox5.Checked) limits += " or Term=" + 5;
            if (checkBox6.Checked) limits += " or Term=" + 6;
            if (checkBox7.Checked) limits += " or Term=" + 7;
            if (checkBox8.Checked) limits += " or Term=" + 8;
            dt.Rows.Clear();
            updateLabels(0, 0, 0, 0);
            var courseTable = FormMain.CourseService.GetEntitiesBylimits(limits);
            if (courseTable == null || courseTable.Rows.Count == 0) return;
            var teacherTable = FormMain.TeacherService.GetEntities();
            if (teacherTable == null || teacherTable.Rows.Count == 0) return;
            var stuCozTable = FormMain.StuCozService.GetEntitiesBylimits("grade>=0 and StudentId=" + FormStudent.Student.ID);
            if (stuCozTable == null || stuCozTable.Rows.Count == 0) return;
            int numCourse, numCredit, numComCourse, numComCredit;
            numCourse = numCredit = numComCourse = numComCredit = 0;
            for (int i = 0; i < stuCozTable.Rows.Count; i++)
            {
                var cozId = stuCozTable.Rows[i]["courseId"].ToString();
                var cozRows = courseTable.Select("ID=" + cozId);
                var cozName = cozRows[0]["Name"].ToString();
                var tchId = cozRows[0]["TeacherId"].ToString();
                var tchName = teacherTable.Select("ID=" + tchId)[0]["Name"];
                var grade = stuCozTable.Rows[i]["Grade"].ToString();
                var credit = cozRows[0]["Credit"].ToString();
                var type = cozRows[0]["Type"].ToString();
                var cozTerm = cozRows[0]["Term"].ToString();
                
                dt.Rows.Add(cozId, cozName, tchName, grade, cozTerm, type, cozTerm);

                numCourse++;
                numCredit += Convert.ToInt32(credit);
                if (type == "compulsory")
                {
                    numComCourse++;
                    numComCredit += Convert.ToInt32(credit);
                }
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            updateLabels(numCourse, numCredit, numComCourse, numComCredit);
        }
    }
}

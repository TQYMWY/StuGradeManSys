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
    public partial class FormAdminSel : Form
    {
        DataTable dt;
        public FormAdminSel()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void flushData()
        {
            dt.Rows.Clear();

            var SelTable = FormMain.StuCozService.GetEntities();
            if (SelTable == null || SelTable.Rows.Count == 0) return;
            for (int i = 0; i < SelTable.Rows.Count; i++)
            {
                var ID = SelTable.Rows[i]["id"];
                var stuID = SelTable.Rows[i]["studentId"];
                var couID = SelTable.Rows[i]["courseId"];
                var grade = SelTable.Rows[i]["grade"];
                dt.Rows.Add(ID, stuID, couID, grade);
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FormAdminSel_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("学生ID");
            dt.Columns.Add("课程ID");
            dt.Columns.Add("成绩");
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelect" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var tempid = Convert.ToInt64(row["ID"]);
                var tempstuid = Convert.ToInt64(row["学生ID"]);
                var tempcouid = Convert.ToInt64(row["课程ID"]);
                var tempgrade = Convert.ToInt32(row["成绩"]);
                if (FormMain.StuCozService.DeleteEntity(new StuCoz(tempid, tempstuid, tempcouid, tempgrade)))
                    MessageBox.Show("成功删除选课信息！");
                flushData();
            }
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxID.Text;
            string getstuID = textBoxStudentID.Text;
            string getcouID = textBoxCourseID.Text;
            string getGrade = textBoxGrade.Text;
            if ((getID.Length == 0) || (getstuID.Length == 0) || (getcouID.Length == 0) || (getGrade.Length == 0))
            {
                MessageBox.Show("请检查是否有输入框为空！");
            }
            else
            {
                if (FormMain.StuCozService.PostEntity(new StuCoz(Convert.ToInt64(getID), Convert.ToInt64(getstuID), Convert.ToInt64(getcouID), Convert.ToInt32(getGrade))))
                    MessageBox.Show("成功插入/更新选课信息！");
            }
            flushData();
        }
    }
}

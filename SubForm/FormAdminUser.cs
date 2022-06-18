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
    public partial class FormAdminUser : Form
    {
        DataTable dt;
        public FormAdminUser()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void flushData()
        {
            dt.Rows.Clear();

            var UserTable = FormMain.UserService.GetEntities();
            if (UserTable == null || UserTable.Rows.Count == 0) return;

            for (int i = 0; i < UserTable.Rows.Count; i++)
            {
                var UserID = UserTable.Rows[i]["ID"];
                var UserName = UserTable.Rows[i]["Name"];
                var UserPwd = "******";
                var UserRole = UserTable.Rows[i]["Role"];
                dt.Rows.Add(UserID, UserName, UserPwd, UserRole);
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            flushData();
        }

        private void FormAdminUser_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("用户id");
            dt.Columns.Add("用户名");
            dt.Columns.Add("用户密码");
            dt.Columns.Add("用户身份");
            dataGridView.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelect";
            btn.HeaderText = "  ";
            btn.DefaultCellStyle.NullValue = "删除";
            dataGridView.Columns.Add(btn);
            dataGridView.AllowUserToAddRows = false;
            flushData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelect" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var temp_user = new User();
                temp_user.ID = Convert.ToInt64(row["用户id"].ToString());
                temp_user.Name = row["用户名"].ToString();
                temp_user.Role = row["用户身份"].ToString();

                //需要维护数据库完整性，有外键约束的情况下无法顺利删除，需要加判断
                if (FormMain.UserService.DeleteEntity(temp_user))
                    MessageBox.Show("成功删除用户信息");
                flushData();
            }
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxUserID.Text;
            string getName = textBoxUserName.Text;
            string getPwd = textBoxUserPwd.Text;
            if((getID.Length == 0) || (getName.Length == 0) ||(getPwd.Length == 0))
            {
                MessageBox.Show("请检查是否有输入框为空！");
            }
            else
            {
                if(radioButtonStudent.Checked == radioButtonAdmin.Checked == radioButtonTeacher.Checked == false)
                {
                    MessageBox.Show("请选择用户身份！");
                }
                else
                {
                    var temp_Newuser = new User();
                    temp_Newuser.ID = Convert.ToInt64(getID);
                    temp_Newuser.Name = getName;
                    temp_Newuser.Pwd = getPwd;
                    if (radioButtonStudent.Checked)
                        temp_Newuser.Role = "student";
                    if (radioButtonTeacher.Checked)
                        temp_Newuser.Role = "teacher";
                    if (radioButtonAdmin.Checked)
                        temp_Newuser.Role = "administrator";
                    if(FormMain.UserService.PostEntity(temp_Newuser))
                        MessageBox.Show("成功插入/更新用户信息！");
                }
            }
            flushData();
        }
    }
}

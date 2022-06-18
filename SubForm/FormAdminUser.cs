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
        string getRole = "";
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
            //btn为删除按钮
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnSelectDelete";
            btn.HeaderText = "  ";
            btn.DefaultCellStyle.NullValue = "删除";
            dataGridView.Columns.Add(btn);
            dataGridView.AllowUserToAddRows = false;
            //btn2为更新按钮
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Name = "btnSelectUpdate";
            btn2.HeaderText = "  ";
            btn2.DefaultCellStyle.NullValue = "更新";
            dataGridView.Columns.Add(btn2);
            dataGridView.AllowUserToAddRows = false;
            flushData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectDelete" && e.RowIndex >= 0)
            {
                var row = dt.Rows[e.RowIndex];
                var temp_user = new User();
                temp_user.ID = Convert.ToInt64(row["用户id"].ToString());
                temp_user.Name = row["用户名"].ToString();
                temp_user.Role = row["用户身份"].ToString();
                switch (temp_user.Role)
                {
                    case "student":
                        var stu = new Student();
                        stu.ID = temp_user.ID;
                        FormMain.StudentService.DeleteEntity(stu);
                        break;
                    case "teacher":
                        var tch = new Teacher();
                        tch.ID = temp_user.ID;
                        FormMain.TeacherService.DeleteEntity(tch);
                        break;
                    default:
                        break;
                }
                //需要维护数据库完整性，有外键约束的情况下无法顺利删除，需要加判断
                if (FormMain.UserService.DeleteEntity(temp_user))
                    MessageBox.Show("成功删除用户信息");
                flushData();
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "btnSelectUpdate" && e.RowIndex >= 0)
            {
                MessageBox.Show("请在下方表单里更新新的用户信息并确认！");
                var row = dt.Rows[e.RowIndex];
                textBoxUserID.Text = row["用户id"].ToString();
                textBoxUserName.Text = row["用户名"].ToString();
                textBoxUserPwd.Text = "******";
                if (row["用户身份"].ToString() == "administrator")
                    radioButtonAdmin.Checked = true;
                if (row["用户身份"].ToString() == "student")
                    radioButtonStudent.Checked = true;
                if (row["用户身份"].ToString() == "teacher")
                    radioButtonTeacher.Checked = true;
                if (radioButtonStudent.Checked)
                {
                    getRole = "student";
                }
                if (radioButtonTeacher.Checked)
                {
                    getRole = "teacher";
                }
                if (radioButtonAdmin.Checked)
                {
                    getRole = "administrator";
                }
                textBoxUserName.ReadOnly = false;
                textBoxUserPwd.ReadOnly = false;
                buttonpost.Visible = true;
                buttonGiveup.Visible = true;
            }
        }

        private void buttonpost_Click(object sender, EventArgs e)
        {
            string getID = textBoxUserID.Text;
            string getName = textBoxUserName.Text;
            string getPwd = textBoxUserPwd.Text;
            if ((getID.Length == 0) || (getName.Length == 0) ||(getPwd.Length == 0))
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
                    {
                        temp_Newuser.Role = "student";
                        if(getRole != "student")
                        {
                            if(getRole == "teacher")
                            {
                                var tmp_stea = new Teacher();
                                tmp_stea.ID = Convert.ToInt64(getID);
                                FormMain.TeacherService.DeleteEntity(tmp_stea);
                            }
                        }
                        var tmp_stu = new Student();
                        tmp_stu.ID = temp_Newuser.ID;
                        tmp_stu.Name = getName;
                        if (FormMain.UserService.PostEntity(temp_Newuser) && FormMain.StudentService.PostEntity(tmp_stu))
                            MessageBox.Show("成功添加/更新用户信息！");
                    }
                    if (radioButtonTeacher.Checked)
                    {
                        temp_Newuser.Role = "teacher";
                        if (getRole != "teacher")
                        {
                            if (getRole == "student")
                            {
                                var tmp_tstu = new Student();
                                tmp_tstu.ID = Convert.ToInt64(getID);
                                FormMain.StudentService.DeleteEntity(tmp_tstu);
                            }
                        }
                        var tmp_tea = new Teacher();
                        tmp_tea.ID = temp_Newuser.ID;
                        tmp_tea.Name = getName;
                        if (FormMain.UserService.PostEntity(temp_Newuser) && FormMain.TeacherService.PostEntity(tmp_tea))
                            MessageBox.Show("成功添加/更新用户信息！");
                    }
                        
                    if (radioButtonAdmin.Checked)
                    {
                        temp_Newuser.Role = "administrator";
                        if (getRole != "administrator")
                        {
                            if (getRole == "student")
                            {
                                var tmp_astu = new Student();
                                tmp_astu.ID = Convert.ToInt64(getID);
                                FormMain.StudentService.DeleteEntity(tmp_astu);
                            }
                            if (getRole == "teacher")
                            {
                                var tmp_atea = new Teacher();
                                tmp_atea.ID = Convert.ToInt64(getID);
                                FormMain.TeacherService.DeleteEntity(tmp_atea);
                            }
                        }
                        var tmp_admin = new Admin();
                        tmp_admin.ID = temp_Newuser.ID;
                        tmp_admin.Name = getName;
                        if (FormMain.UserService.PostEntity(temp_Newuser) && FormMain.AdminService.PostEntity(tmp_admin))
                            MessageBox.Show("成功添加/更新用户信息！");
                    }

                    textBoxUserID.Text = "";
                    textBoxUserName.Text = "";
                    textBoxUserPwd.Text = "";
                    radioButtonStudent.Checked = radioButtonAdmin.Checked = radioButtonTeacher.Checked = false;
                    textBoxUserName.ReadOnly = true;
                    textBoxUserPwd.ReadOnly = true;
                    buttonpost.Visible = false;
                    buttonGiveup.Visible = false;
                }
            }
            flushData();
        }

        private void buttongetNewuser_Click(object sender, EventArgs e)
        {
            //生成一个新的用户ID
            MessageBox.Show("请在左下方表单里填写新用户的信息并确认！");
            string getNewID = FormMain.UserService.GetNextId().ToString();
            textBoxUserID.Text = getNewID;
            textBoxUserName.Text = "";
            textBoxUserPwd.Text = "";
            radioButtonStudent.Checked = radioButtonAdmin.Checked = radioButtonTeacher.Checked = false;
            textBoxUserName.ReadOnly = false;
            textBoxUserPwd.ReadOnly = false;
            buttonpost.Visible = true;
            buttonGiveup.Visible = true;
        }

        private void buttonGiveup_Click(object sender, EventArgs e)
        {
            textBoxUserID.Text = "";
            textBoxUserName.Text = "";
            textBoxUserPwd.Text = "";
            radioButtonStudent.Checked = radioButtonAdmin.Checked = radioButtonTeacher.Checked = false;
            textBoxUserName.ReadOnly = true;
            textBoxUserPwd.ReadOnly = true;
            buttonpost.Visible = false;
            buttonGiveup.Visible = false;
        }
    }
}

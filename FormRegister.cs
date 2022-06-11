using StuGradeManSys.Databases;
using StuGradeManSys.Entities;
using StuGradeManSys.Repositories;
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

namespace StuGradeManSys
{
    public partial class FormRegister : Form
    {
        private User user;
        public FormRegister()
        {
            InitializeComponent();
            user = new User();
            user.Role = "student";
            long id = FormMain.UserService.GetNextId();
            this.textBoxID.Text = id.ToString();
        }
        
        private void textBoxRePwd_Leave(object sender, EventArgs e)
        {
            if (textBoxRePwd.Text != textBoxPwd.Text)
            {
                labelHint.Text = "两次密码不一致，请重新输入";
            }
            else
            {
                labelHint.Text = "为保证唯一，账号为自动分配，不可自己设置";
            }
        }

        private void radioButtonTeacher_CheckedChanged(object sender, EventArgs e)
        {
            user.Role = "teacher";
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            user.Role = "student";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxRePwd.Text == textBoxPwd.Text)
            {
                user.ID = Convert.ToInt64(textBoxID.Text.Trim());
                user.Pwd = textBoxPwd.Text.Trim();
                user.Name = textBoxName.Text.Trim();
                if (FormMain.UserService.PostEntity(user))
                {
                    if (user.Role == "teacher")
                    {
                        Teacher teacher = new Teacher();
                        teacher.ID = user.ID;
                        teacher.Name = user.Name;
                        FormMain.TeacherService.PostEntity(teacher);
                    }
                    else if (user.Role == "student")
                    {
                        Student student = new Student();
                        student.ID = user.ID;
                        student.Name = user.Name;
                        FormMain.StudentService.PostEntity(student);
                    }
                    MessageBox.Show("注册成功!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            } 
        }
    }
}

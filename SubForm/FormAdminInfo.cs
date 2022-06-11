using StuGradeManSys.Entities;
using StuGradeManSys.Utils;
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
    public partial class FormAdminInfo : Form
    {
        User user;
        Admin admin;
        public FormAdminInfo()
        {
            InitializeComponent();
            user = FormMain.User.Copy<User>();
            admin = FormAdmin.Admin.Copy<Admin>();
        }
        private void FormAdminInfo_Load(object sender, EventArgs e)
        {
            this.textBoxID.Text = FormMain.User.ID.ToString();
            this.textBoxName.Text = FormMain.User.Name.ToString();
            this.textBoxPwd.Text = "********";
            this.textBoxRole.Text = FormMain.User.Role.ToString();

            this.textBoxMail.Text = FormAdmin.Admin.Mailbox.ToString();
        }
        private void labelChangePwd_Click(object sender, EventArgs e)
        {
            labelChangePwd.Text = "再次输入密码：";
            labelChangePwd.ForeColor = Color.Black;
            textBoxPwd.ReadOnly = false;
            textBoxPwd.Text = "";
            textBoxPwd.Enabled = true;
            textBoxRePwd.Visible = true;
            buttonChangeInfo.Visible = false;
            buttonSave.Visible = true;
            buttonGiveUp.Visible = true;
        }
        private void checkPwd()
        {
            if (textBoxPwd.Text != textBoxRePwd.Text)
            {
                labelHint.Visible = true;
            }
            else
            {
                labelHint.Visible = false;
                user.Pwd = textBoxRePwd.Text.Trim();
            }
        }
        private void textBoxRePwd_Leave(object sender, EventArgs e)
        {
            checkPwd();
        }
        private void textBoxPwd_Leave(object sender, EventArgs e)
        {
            checkPwd();
        }
        private void getUserInfoBack()
        {
            labelChangePwd.Text = "修改密码";
            labelChangePwd.ForeColor = Color.Blue;
            textBoxPwd.ReadOnly = true;
            textBoxPwd.Text = "********";
            textBoxPwd.Enabled = false;
            textBoxRePwd.Visible = false;
            buttonChangeInfo.Visible = true;
            buttonSave.Visible = false;
            buttonGiveUp.Visible = false;

            textBoxRePwd.Text = "";
            labelHint.Visible = false;

            this.textBoxMail.Text = FormAdmin.Admin.Mailbox.ToString();
            textBoxMail.ReadOnly = true;
        }
        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            user = FormMain.User.Copy<User>();
            admin = FormAdmin.Admin.Copy<Admin>();
            getUserInfoBack();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (user.Pwd != FormMain.User.Pwd)
            {
                if (FormMain.UserService.PostEntity(user))
                    FormMain.User.Pwd = user.Pwd;
            }
            admin.Mailbox = textBoxMail.Text.Trim();
            if (FormMain.AdminService.PostEntity(admin))
            {
                FormAdmin.Admin.Mailbox = textBoxMail.Text.Trim();
            }
            getUserInfoBack();
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            textBoxMail.ReadOnly = false;
            buttonSave.Visible = true;
            buttonGiveUp.Visible = true;
        }

        
    }
}

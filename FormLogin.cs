namespace StuGradeManSys
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegister();
            formRegister.Owner = this.Owner;
            this.Hide();
            formRegister.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.User.ID = Convert.ToInt64(textBoxID.Text.Trim());
            }
            catch (Exception)
            {
                FormMain.User.ID = 0;
            }
            FormMain.User.Pwd = textBoxPwd.Text.Trim();
            FormMain.User = FormMain.UserService.Authenticate(FormMain.User);
            if (FormMain.User.ID == -1)
            {
                labelCheck.Show();
            }
            else
            {
                var fa = (FormMain)this.Owner;
                if (fa != null) fa.flushInfo();
                this.Close();
            }
        }

    }
}

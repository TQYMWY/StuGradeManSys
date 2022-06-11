using StuGradeManSys.Entities;
using StuGradeManSys.Services;
using StuGradeManSys.Utils;


namespace StuGradeManSys.SubForm
{
    public partial class FormAdmin : Form
    {
        public static Admin Admin = new Admin();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            var adm = FormMain.AdminService.GetEntity(FormMain.User.ID);
            if (adm == null)
            {
                MessageBox.Show("数据库出错");
                this.Close();
                return;
            }
            Admin = adm;
            panel.OpenForm(new FormAdminInfo());
        }
        private bool CheckInfo()
        {
            if (Admin.Mailbox == string.Empty)
                return false;
            return true;
        }
        private void InfoManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminInfo());
        }

        private void StuInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormAdminStu());
        }

        private void TchInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormAdminTch());
        }

        private void CozInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormAdminCoz());
        }

        private void SelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormAdminSel());
        }

        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("请先完善信息");
                return;
            }
            panel.OpenForm(new FormAdminUser());
        }
    }
}

using StuGradeManSys.Entities;
using StuGradeManSys.Services;
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
    public partial class FormAdmin : Form
    {
        public static Admin Admin = new Admin();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            panel.OpenForm(new FormAdminInfo());
        }

        private void InfoManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminInfo());
        }

        private void StuInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminStu());
        }

        private void TchInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminTch());
        }

        private void CozInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminCoz());
        }

        private void SelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminSel());
        }

        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.OpenForm(new FormAdminUser());
        }
    }
}

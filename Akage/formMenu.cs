using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akage
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            openChildForm(new formHlmn());
        }

        private int mn = 1;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (mn != 1)
            {
                openChildForm(new formHlmn());
                mn = 1;
            }
        }

        private void btnKalkulasi_Click(object sender, EventArgs e)
        {
            if (mn != 2)
            {
                openChildForm(new formKalkulasi());
                mn = 2;
            }
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (mn != 3)
            {
                openChildForm(new formHasil2());
                mn = 3;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (mn != 4)
            {
                openChildForm(new formList());
                mn = 4;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formMenu fMenu = new formMenu();
            fMenu.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}

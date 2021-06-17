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
    public partial class formHasil2 : Form
    {
        public formHasil2()
        {
            InitializeComponent();
            if ((formHasil1.kalori ?? formHasil1.karbohidrat 
                ?? formHasil1.protein ?? formHasil1.lemak) != null)
                Hasil();
        }

        private void Hasil()
        {
            lblKal.Text = formHasil1.kalori;
            lbKarbo.Text = formHasil1.karbohidrat;
            lbProt.Text = formHasil1.protein;
            lbLemak.Text = formHasil1.lemak;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

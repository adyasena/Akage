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
    public partial class formHasil1 : Form
    {
        public formHasil1()
        {
            InitializeComponent();
            hasil();
        }

        public static string kalori, karbohidrat, protein, lemak;
        private void hasil()
        {
            lbKkal.Text = String.Format("{0:0}", formKalkulasi.kal) + " kkal";
            lbKar.Text = String.Format("{0:0}", formKalkulasi.karbohidrat) + " g";
            lbPro.Text = String.Format("{0:0}", formKalkulasi.protein) + " g";
            lbLem.Text = String.Format("{0:0}", formKalkulasi.lemak) + " g";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            kalori = String.Format("{0:0}", formKalkulasi.kal) + " kkal";
            karbohidrat = String.Format("{0:0}", formKalkulasi.karbohidrat) + " g";
            protein = String.Format("{0:0}", formKalkulasi.protein) + " g";
            lemak = String.Format("{0:0}", formKalkulasi.lemak) + " g";
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

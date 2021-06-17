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
    public partial class formKalkulasi : Form
    {
        public formKalkulasi()
        {
            InitializeComponent();
        }

        public static double kal, bmr, karbohidrat, protein, lemak;

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUmur.Text) || string.IsNullOrEmpty(tbBerat.Text) 
                || string.IsNullOrEmpty(tbTinggi.Text) || (cbAktiv.SelectedIndex == -1))
                MessageBox.Show("Mohon lengkapi data");
            else if (rbMale.Checked == false & rbFemale.Checked == false)
                MessageBox.Show("Mohon lengkapi data");
            else
            {
                double Umur = double.Parse(tbUmur.Text);
                double Berat = double.Parse(tbBerat.Text);
                double Tinggi = double.Parse(tbTinggi.Text);

                Hitung(Umur, Berat, Tinggi);

                formHasil1 hasil = new formHasil1();
                hasil.StartPosition = FormStartPosition.CenterScreen;
                hasil.Show();
            }
        }

        public void Hitung(double umur, double beratBadan, double tinggiBadan)
        {
            if (rbMale.Checked)
                bmr = 66.5 + (beratBadan * 13.7) + (tinggiBadan * 5) - (umur * 6.8);
            else if (rbFemale.Checked)
                bmr = 655 + (beratBadan * 9.6) + (tinggiBadan * 1.8) - (umur * 4.7);

            string akt = cbAktiv.SelectedItem.ToString();
            if (akt == "Tidak pernah")
                kal = bmr * 1.2;
            else if (akt == "Jarang (1-2 hari)")
                kal = bmr * 1.375;
            else if (akt == "Kadang (3-4 hari)")
                kal = bmr * 1.55;
            else if (akt == "Sering (5-6 hari)")
                kal = bmr * 1.725;
            else if (akt == "Selalu/aktivitas berat")
                kal = bmr * 1.9;
            karbohidrat = kal * 12 / 20 / 4;
            protein = kal * 3 / 20 / 4;
            lemak = kal * 5 / 20 / 9;
        }
    }
}

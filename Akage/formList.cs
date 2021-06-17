using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akage
{
    public partial class formList : Form
    {
        public formList()
        {
            InitializeComponent();
        }

        private void formList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbBuahDataSet1.Buah' table. You can move, or remove it, as needed.
            this.buahTableAdapter1.Fill(this.dbBuahDataSet1.Buah);
            dgvList.ClearSelection();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Szamol(object sender, EventArgs e)
        {
            double osszeg;
            osszeg = ((double)nudSzam1.Value + (double)nudSzam2.Value) / 2;
            lblMegoldas.Text = Convert.ToString(osszeg);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kilep = MessageBox.Show("Biztosan kilépsz?", "Ablak bezár", MessageBoxButtons.YesNo);
            if (kilep == DialogResult.No) e.Cancel = true; ;
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

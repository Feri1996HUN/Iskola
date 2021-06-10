using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalisFormSzambekeres
{
    public partial class MainForm : Form
    {
        int szam1 = 0, szam2 = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Szam1()
        {
            Beker frm = new Beker();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                szam1 = frm.getszam();
                lblSzamok.Text += Convert.ToString(szam1);
            }
        }

        private void Szam2()
        {
            Beker frm = new Beker();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                szam2 = frm.getszam();
                lblSzamok.Text += ("; " + Convert.ToString(szam2));
            }
        }

        private void Szamol()
        {
            int osszeg = 0;
            osszeg = (szam1 + szam2) / 2;
            lblSzamok.Text += ("\n Számtani átlag: " + osszeg);
        }

        private void btnSzam2_Click(object sender, EventArgs e)
        {
            Szam2();
            if (szam1 > 0 && szam2 > 0) Szamol();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            Szam1();
            if (szam1 > 0 && szam2 > 0) Szamol();
        }
    }
}

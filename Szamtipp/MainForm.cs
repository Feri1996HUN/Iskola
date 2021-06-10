using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamtipp
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private int Legnagyobb()
        {
            int max = 21;
            max = (int)nudLegnagy.Value;
            return max;
        }

        private void Megold()
        {
            int szam;
            szam = vsz.Next(1, Legnagyobb());
            if (szam == (int)nudTipp.Value) lblEredm.Text = String.Format("Eltaláltad!!! A szám: {0}", szam);
            else if (szam > (int)nudTipp.Value) lblEredm.Text = String.Format("A szám amire tippeltél ksiebb mint a keresett szám! A szám: {0}", szam);
            else lblEredm.Text = String.Format("A szám amire tippeltél nagyobb mint a keresett szám! A szám: {0}", szam);
        }

        private void btnLegnagy_Click(object sender, EventArgs e)
        {
            Legnagyobb();
        }

        private void btnMegold_Click(object sender, EventArgs e)
        {
            Megold();
        }
    }
}

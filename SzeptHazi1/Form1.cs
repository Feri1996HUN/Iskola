using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzeptHazi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            szamol();
        }


        private void szamol()
        {
            int osszeg = 0, kulonb = 0, szorzat = 0;
            double hanyados = 0;
            osszeg = Convert.ToInt32(nudszam1.Value) + Convert.ToInt32(nudszam2.Value);
            kulonb = Convert.ToInt32(nudszam1.Value) - Convert.ToInt32(nudszam2.Value);
            szorzat = Convert.ToInt32(nudszam1.Value) * Convert.ToInt32(nudszam2.Value);
            hanyados = Convert.ToDouble(nudszam1.Value) / Convert.ToDouble(nudszam2.Value);
            lblMegoldas.Text = string.Format("A két szám összege: {0}\nA két szám különbsége: {1}\nA két szám szorzata: {2}\nA két szám hányadosa: {3}", osszeg, kulonb, szorzat, hanyados);
        }
    }
}

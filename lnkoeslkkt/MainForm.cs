using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lnkoeslkkt
{
    public partial class MainForm : Form
    {
        private string megoldas = "Megoldás: {0}";
        public MainForm()
        {
            InitializeComponent();
        }

        private int lnko(int szam1, int szam2)
        {
            int maradek = 1, megold = 0;
            if (szam1 == szam2) megold = szam1;
            else if (szam1 > szam2)
            {
                maradek = szam1 % szam2;
                while (maradek != 0)
                {
                    megold = maradek;
                    maradek = szam2 % maradek;
                }
            }
            else
            {
                maradek = szam2 % szam1;
                while (maradek != 0)
                {
                    megold = maradek;
                    maradek = szam1 % maradek;
                }
            }
            lblMegoldas.Text = String.Format(megoldas, megold);
            return megold;
        }

        private void lkkt(int szam1, int szam2)
        {
            int megold;
            megold = (szam1 / lnko(szam1, szam2)) * szam2;
            lblMegoldas.Text = String.Format(megoldas, megold);
        }

        private void rbLNKO_Click(object sender, EventArgs e)
        {
            lnko((int)nudSzam1.Value, (int)nudSzam2.Value);
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbLKKT_Click(object sender, EventArgs e)
        {
            lkkt((int)nudSzam1.Value, (int)nudSzam2.Value);
        }
    }
}

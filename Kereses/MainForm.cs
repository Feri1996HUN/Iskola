using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kereses
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        int mindb = 1, maxdb = 20, minszam = 1, maxszam = 99;

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            SzamHozzaad();
        }

        public MainForm()
        {
            InitializeComponent();
            nudKezzel.Visible = false;
            btnHozzaad.Visible = false;
            minimumtsmi.Enabled = false;
            maximumtsmi.Enabled = false;
        }

        private void General(object sender, EventArgs e)
        {
            lbSzamok.Items.Clear();
            int db = 0, szam;
            db = vsz.Next(mindb, maxdb + 1);

            while (lbSzamok.Items.Count <= db)
            {
                szam = vsz.Next(minszam, maxszam + 1);
                Azonossag(szam);
            }
            nudKezzel.Visible = false;
            btnHozzaad.Visible = false;
            if (lbSzamok.Items.Count > 0)
            {
                minimumtsmi.Enabled = true;
                maximumtsmi.Enabled = true;
            }
        }

        private void Azonossag(int szam)
        {
            bool azonos = false;
            azonos = false;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                if (Convert.ToInt32(lbSzamok.Items[i]) == szam)
                {
                    azonos = true;
                    break;
                }
            }
            if (!azonos) lbSzamok.Items.Add(szam);
        }

        private void Kezzel(object sender, EventArgs e)
        {
            nudKezzel.Visible = true;
            btnHozzaad.Visible = true;
            
        }
        private void SzamHozzaad()
        {
            if (lbSzamok.Items.Count <= maxdb) Azonossag((int)nudKezzel.Value); 
            else MessageBox.Show("Elérted a maximum db számot!");
            if (lbSzamok.Items.Count > 0)
            {
                minimumtsmi.Enabled = true;
                maximumtsmi.Enabled = true;
            }
        }

        private void Keres(object sender, EventArgs e)
        {
            int min = maxszam, max = minszam;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                if (min > Convert.ToInt32(lbSzamok.Items[i])) min = Convert.ToInt32(lbSzamok.Items[i]);
                if (max < Convert.ToInt32(lbSzamok.Items[i])) max = Convert.ToInt32(lbSzamok.Items[i]);
            }
            if (sender is ToolStripMenuItem)
            {
                if ((sender as ToolStripMenuItem).Name == "minimumtsmi") MessageBox.Show("A legkisebb szám: " + Convert.ToString(min));
                if ((sender as ToolStripMenuItem).Name == "maximumtsmi") MessageBox.Show("A legnagyobb szám: " + Convert.ToString(max));
            }

        }

        private void Atlag(object sender, EventArgs e)
        {
            int atlag = 0;
            for  (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                atlag += Convert.ToInt32(lbSzamok.Items[i]);
            }
            atlag /= lbSzamok.Items.Count;
            MessageBox.Show("Átlag: " + atlag);
        }

        private void Osszeg(object sender, EventArgs e)
        {
            int osszeg = 0;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                osszeg += Convert.ToInt32(lbSzamok.Items[i]);
            }
            MessageBox.Show("Összeg: " + osszeg);
        }

        private void Paros(object sender, EventArgs e)
        {
            int osszeg = 0;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                if (Convert.ToInt32(lbSzamok.Items[i]) % 2 == 0) osszeg += Convert.ToInt32(lbSzamok.Items[i]);
            }
            MessageBox.Show("Páros számok összege: " + osszeg);
        }

        private void Kilep(object sender, EventArgs e)
        {
            Close();
        }




    }
}

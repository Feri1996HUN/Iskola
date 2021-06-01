using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menumasodikfeladat
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void General(object sender, EventArgs e)
        {
            lbSzamok.Items.Clear();
            //int [] szamok = new int[10];
            int i = 1, szam;
            bool azonos = false;
            //szamok[0] = vsz.Next(10, 101);
            //lbSzamok.Items.Add(szamok[0]);
            /*while (i < 10)
            {
                szam = vsz.Next(10, 101);
                azonos = false;
                for (int p = 0; p <= i; p++)
                {
                    if (szamok[p] == szam)
                    {
                        azonos = true;
                        break;
                    }
                }
                if (!azonos)
                {
                    szamok[i] = szam;
                    lbSzamok.Items.Add(szamok[i]);
                    i++;
                }
            }
            */
            while (i <= 10)
            {
                azonos = false;
                szam = vsz.Next(10, 101);
                if (!Paros(szam))
                {
                    lbSzamok.Items.Add(szam);
                    i++;
                }
            }
            Status();
        }

        private bool Paros(int szam)
        {
            bool azonos = false;
            foreach (int p in lbSzamok.Items)
            {
                if (p == szam)
                {
                    azonos = true;
                    break;
                }
            }
            return azonos;
        }

        private void Torles(object sender, EventArgs e)
        {
            lbSzamok.Items.Remove(lbSzamok.SelectedItem);
            Status();
        }

        private void UjElem(object sender, EventArgs e)
        {
            int ujszam;
            try
            {
                ujszam = Convert.ToInt32(tbxEredm.Text);
                if (!Paros(ujszam)) lbSzamok.Items.Add(ujszam);
                else MessageBox.Show("Már van ilyen szám!");
                Status();
            }
            catch (Exception)
            {
                MessageBox.Show("Nem számot adtál meg!");
            }
        }

        private void Osszeadas(object sender, EventArgs e)
        {
            int osszeg = 0;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                osszeg += Convert.ToInt32(lbSzamok.Items[i]);
            }
            lblEredm.Text = String.Format("A számok összege: {0}", osszeg);
        }
        private void Szorzas(object sender, EventArgs e)
        {
            long osszeg = 1;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                osszeg *= Convert.ToInt32(lbSzamok.Items[i]);
            }
            lblEredm.Text = String.Format("A számok szorzata: {0:000,000}", osszeg);
        }

        private void Status()
        {
            int min = Int32.MaxValue, max = Int32.MinValue;
            for (int i = 0; i < lbSzamok.Items.Count; i++)
            {
                if (min > Convert.ToInt32(lbSzamok.Items[i])) min = Convert.ToInt32(lbSzamok.Items[i]);
                if (max < Convert.ToInt32(lbSzamok.Items[i])) max = Convert.ToInt32(lbSzamok.Items[i]);
            }
            tsslDbszam.Text = String.Format("A lista db szám: {0}", lbSzamok.Items.Count);
            tsslLegkisebb.Text = String.Format("Legkisebb elem: {0}", min);
            tsslLegnagyobb.Text = String.Format("Legnagyobb elem: {0}", max);
        }
    }
}

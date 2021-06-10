using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaJatekProgram
{
    public struct Szabaly
    {
        public int hanyszam;
        public int ido;
        public int jegy;
    }
    public partial class MainForm : Form
    {
        
        Szabaly adat = new Szabaly();
        Random vsz = new Random();
        int[] szamok;
        int[] megoldas;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Adatok()
        {
            if (rbHatszamjegy.Checked)
            {
                adat.hanyszam = 6;
                rb20mp.Enabled = false;
                rb5mp.Enabled = true;
            }
            else
            {
                adat.hanyszam = 9;
                rb20mp.Enabled = true;
                rb5mp.Enabled = false;
            }
            
            if (rb5mp.Checked) adat.ido = 5;
            else if (rb10mp.Checked) adat.ido = 10;
            else adat.ido = 20;
            if (rb1jegy.Checked) adat.jegy = 1;
            else adat.jegy = 2;
        }

        private void General()
        {
            szamok = new int[adat.hanyszam];
            megoldas = new int[adat.hanyszam];
            if (adat.jegy == 1)
            {
                for (int i = 0; i < adat.hanyszam; i++)
                {
                    szamok[i] = vsz.Next(1, 10);
                }
            }
            else
            {
                for (int i = 0; i < adat.hanyszam; i++)
                {
                    szamok[i] = vsz.Next(1, 100);
                }
            }
        }

        private void Ellenoriz()
        {
            bool talalt = false;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == megoldas[i]) talalt = true;
            }
            if (talalt) MessageBox.Show("Ügyes vagy!");
            else MessageBox.Show("Elrontottad!");
        }

            private void btnStart_Click(object sender, EventArgs e)
        {
            Adatok();
            General();
            Memoria frm = new Memoria();
            Megold mfrm = new Megold();
            frm.SetAdat(adat);
            frm.Kiirat(szamok);
            frm.ShowDialog();
            mfrm.ShowDialog();
            mfrm.SetAdat(adat);
            mfrm.Megoldas(megoldas);
            Ellenoriz();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JegyAr
{
    public partial class MainForm : Form
    {
        double osszeg;
        string fuvardij = "Fuvardíj: {0} Ft";
        struct Allomas
        {
            public string allomasnev;
            public double dij;
        }
        Allomas[] allomas = new Allomas[5];
        
        public MainForm()
        {
            InitializeComponent();
            allomasfeltolt();
            combofeltolt();
            cbxAllomas.SelectedIndex = 0;
        }

        private void allomasfeltolt()
        {
            allomas[0].allomasnev = "Válasszon";
            allomas[1].allomasnev = "Budapest";
            allomas[2].allomasnev = "Hatvan";
            allomas[3].allomasnev = "Székesfehérvár";
            allomas[4].allomasnev = "Kecskemét";
            allomas[0].dij = 0;
            allomas[1].dij = 1500;
            allomas[2].dij = 1300;
            allomas[3].dij = 2000;
            allomas[4].dij = 2800;
            
        }

        private void combofeltolt()
        {
            for (int i = 0; i < allomas.Length; i++)
            {
                cbxAllomas.Items.Add(allomas[i].allomasnev);
            }
        }

        private double Hely()
        {
           return allomas[cbxAllomas.SelectedIndex].dij;
        }

        private void Szamol()
        {
            osszeg = Hely();
            if (rbDiak.Checked) osszeg /= 2;
            if (rbNyugdij.Checked) osszeg /= 2;
            if (cbxTorzsutas.Checked) osszeg *= 0.3;

            if (cbxKutya.Checked) osszeg += 800;
            if (cbxBicikli.Checked) osszeg += 600;
            if (cbxPoggyasz.Checked) osszeg += 400;

            lblEredm.Text = String.Format(fuvardij, osszeg);
        }

        private void Ujra()
        {
            rbDiak.Checked = false;
            rbNyugdij.Checked = false;
            cbxTorzsutas.Checked = false;
            cbxKutya.Checked = false;
            cbxBicikli.Checked = false;
            cbxPoggyasz.Checked = false;
            cbxAllomas.SelectedIndex = 0;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            Ujra();
        }

        private void cbxAllomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void rbDiak_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void rbNyugdij_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void cbxTorzsutas_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void cbxKutya_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void cbxBicikli_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }

        private void cbxPoggyasz_CheckedChanged(object sender, EventArgs e)
        {
            Szamol();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3szammuveletek
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SzamtaniK(object sender, EventArgs e)
        {
            double szamtaniosszeg;
            szamtaniosszeg = ((double)nudSzam1.Value + (double)nudSzam2.Value + (double)nudSzam3.Value) / 3;
            lbEredm.Items.Add(String.Format("Számtani közép: {0:0.00}", szamtaniosszeg));
        }
        
        private void MertaniK(object sender, EventArgs e)
        {
            double mertaniosszeg;
            mertaniosszeg = ((double)nudSzam1.Value * (double)nudSzam2.Value * (double)nudSzam3.Value) / 3;
            lbEredm.Items.Add(String.Format("Mértani közép: {0:0.00}", mertaniosszeg));
        }

        private void HarmonikusK(object sender, EventArgs e)
        {
            double harmonikusosszeg;
            harmonikusosszeg = 1 / (((1 / (double)nudSzam1.Value) + (1 / (double)nudSzam2.Value) + (1 / (double)nudSzam3.Value)) / 3);
            lbEredm.Items.Add(String.Format("Harmonikus közép: {0:0.00}", harmonikusosszeg));
        }

        private void Legnagyobb(object sender, EventArgs e)
        {
            int legnagyobb;
            legnagyobb = Math.Max((int)nudSzam1.Value, Math.Max((int)nudSzam2.Value, (int)nudSzam3.Value));
            lbEredm.Items.Add("Legnagyobb szám: " + legnagyobb);
        }

        private void Torles(object sender, EventArgs e)
        {
            nudSzam1.Value = nudSzam1.Minimum;
            nudSzam2.Value = nudSzam2.Minimum;
            nudSzam3.Value = nudSzam3.Minimum;
            lbEredm.Items.Clear();
        }

        private void kilepes(object sender, EventArgs e)
        {
            Close();
        }


    }
}

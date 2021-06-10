using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalisKiscserkesz
{
    public partial class Adatbevitel : Form
    {
        public struct Cserkesz
        {
            public string azonosito;
            public string nev;
            public DateTime datum;
        }
        Cserkesz adat = new Cserkesz();
        public Adatbevitel()
        {
            InitializeComponent();
        }

        private void Adatbekeres()
        {
            
            bool kitoltve = false;
            while (!kitoltve)
            {
                if (tbxAzon.Text != String.Empty && tbxNev.Text != String.Empty && dtpDatum.Value != null)
                {
                    adat.azonosito = tbxAzon.Text;
                    adat.nev = tbxNev.Text;
                    adat.datum = dtpDatum.Value;
                    kitoltve = true;
                }
                else MessageBox.Show("Nem jól töltötted ki!");
            }
        }

        public Cserkesz Getadat()
        {
            return adat;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Adatbekeres();
        }
    }
}

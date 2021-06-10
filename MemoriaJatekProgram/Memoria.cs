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
    public partial class Memoria : Form
    {
        int szamlalo = 0;
        Timer idozito = new Timer();
        Szabaly adatfelhaszn = new Szabaly();
        public Memoria()
        {
            InitializeComponent();
        }

        public void SetAdat(Szabaly adat)
        {
            adatfelhaszn = adat;
        }

        public void Kiirat(int[] szamok)
        {
            idozito.Enabled = true;
            idozito.Tick += Idozito_Tick;
            idozito.Interval = 1000;
            idozito.Start();
            for (int i = 0; i < szamok.Length; i++)
            {
                lblSzamok.Text += String.Format("{0}; ", szamok[i]);
            }
        }   

        private void Idozito_Tick(object sender, EventArgs e)
        {
            lblIdo.Text = Convert.ToString(szamlalo);
            szamlalo++;
            if (szamlalo == adatfelhaszn.ido)
            {
                idozito.Stop();
                Close();
            }
        }
    }
}

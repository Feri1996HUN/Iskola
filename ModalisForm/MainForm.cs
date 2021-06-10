using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalisForm
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        bool paros;
        public MainForm()
        {
            InitializeComponent();
        }

        private int General()
        {
            int szam;
            szam = vsz.Next(1, 21);
            return szam;
        }


        private void btnMegold_Click(object sender, EventArgs e)
        {
            int szam = General();
            if (paros)
            {
                if (szam % 2 == 0) MessageBox.Show("Eltaláltad: " + szam, "Páros szám", MessageBoxButtons.OK);
                else MessageBox.Show("Nem találtad el: " + szam, "Nem páros szám", MessageBoxButtons.OK);
            }
            else
            {
                if (szam % 2 == 1) MessageBox.Show("Eltaláltad: " + szam, "Páratlan szám", MessageBoxButtons.OK);
                else MessageBox.Show("Nem találtad el: " + szam, "Nem páratlan szám", MessageBoxButtons.OK);
            }
            
        }

        private void btnParos_Click(object sender, EventArgs e)
        {
            paros = true;
        }

        private void btnParatlan_Click(object sender, EventArgs e)
        {
            paros = false;
        }
    }
}

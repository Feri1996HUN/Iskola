using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NemModalisForm
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        bool paros = true;
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
            Uzenet frm = new Uzenet();
            if (paros)
            {
                if (szam % 2 == 0) frm.setLabel("Eltaláltad: " + szam);
                else frm.setLabel("Nem találtad el: " + szam);
            }
            else
            {
                if (szam % 2 == 1) frm.setLabel("Eltaláltad: " + szam);
                else frm.setLabel("Nem találtad el: " + szam);
            }
            frm.Show();
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

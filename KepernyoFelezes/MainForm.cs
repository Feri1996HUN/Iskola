using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepernyoFelezes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            splitContainer1.SplitterDistance = (int)(splitContainer1.Width * 0.5);
        }
        private void Szamol(object sender, EventArgs e)
        {
            int osszeg = 0;
            osszeg = (int)nudSzam1.Value + (int)nudSzam2.Value;
            lblMegoldas.Text = Convert.ToString(osszeg);
        }

        private void Igazit()
        {
            Point Koordinata = new Point();
            Koordinata.X = (splitContainer1.Panel1.Width - gbxMozgat.Location.X) / 2;
            Koordinata.Y = gbxMozgat.Location.Y;
            gbxMozgat.Location = Koordinata;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Igazit();
        }

        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            Igazit();
        }
    }
}

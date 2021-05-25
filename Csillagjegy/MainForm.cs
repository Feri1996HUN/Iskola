using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csillagjegy
{
    public partial class MainForm : Form
    {
        string[] csillag = new string[13];
        DateTime[] datum = new DateTime[13];
        public MainForm()
        {
            InitializeComponent();

            csillagnev();
            csillagdatum();
        }

        private void csillagnev()
        {
            csillag[0] = "Bak";
            csillag[1] = "Vízöntő";
            csillag[2] = "Halak";
            csillag[3] = "Kos";
            csillag[4] = "Bika";
            csillag[5] = "Ikrek";
            csillag[6] = "Rák";
            csillag[7] = "Oroszlán";
            csillag[8] = "Szűz";
            csillag[9] = "Mérleg";
            csillag[10] = "Skorpió";
            csillag[11] = "Nyilas";
            csillag[12] = "Bak";
        }

        private void csillagdatum()
        {
            datum[0] = new DateTime(2008, 01, 01);
            datum[1] = new DateTime(2008, 01, 20);
            datum[2] = new DateTime(2008, 02, 19);
            datum[3] = new DateTime(2008, 03, 21);
            datum[4] = new DateTime(2008, 04, 20);
            datum[5] = new DateTime(2008, 05, 21);
            datum[6] = new DateTime(2008, 06, 22);
            datum[7] = new DateTime(2008, 07, 23);
            datum[8] = new DateTime(2008, 08, 23);
            datum[9] = new DateTime(2008, 09, 23);
            datum[10] = new DateTime(2008, 10, 23);
            datum[11] = new DateTime(2008, 11, 22);
            datum[12] = new DateTime(2008, 12, 22);
        }

        private void Csillag()
        {
            DateTime keres = new DateTime(2008, dtpDatum.Value.Month, dtpDatum.Value.Day);

            for (int i = 0; i < datum.Length; i++)
            {
                if (datum[i].Date > keres.Date)
                {
                    lblEredm.Text = csillag[i - 1];
                    break;
                }
                if (i == 12 && keres.Date.Day > 21) lblEredm.Text = csillag[12];
            }
        }

        private void btnMegold_Click(object sender, EventArgs e)
        {
            Csillag();
        }
    }
}

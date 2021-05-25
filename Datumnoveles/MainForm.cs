using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datumnoveles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Ido();
        }

        private DateTime Megold()
        {
            DateTime datum = dtpDatum.Value;
            DateTime ujdatum = new DateTime();
            if (rbnEv.Checked)
            {
                ujdatum = datum.AddYears((int)nudSzam.Value);
            }
            if (rbnHo.Checked)
            {
                ujdatum = datum.AddMonths((int)nudSzam.Value);
            }
            if (rbnNap.Checked)
            {
                ujdatum = datum.AddDays((int)nudSzam.Value);
            }
            if (rbnOra.Checked)
            {
                ujdatum = datum.AddHours((int)nudSzam.Value);
            }
            if (rbnPerc.Checked)
            {
                ujdatum = datum.AddMinutes((int)nudSzam.Value);
            }
            if (rbnMperc.Checked)
            {
                ujdatum = datum.AddSeconds((int)nudSzam.Value);
            }
            return ujdatum;
        }

        private void Ido()
        {
            mtbEredm.Text = String.Format("{0:HH:mm:ss}", dtpDatum.Value);
            
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            lblEredm.Text = String.Format("{0:yyyy.mm.dd HH:mm:ss}" , Megold());
        }
    }
}

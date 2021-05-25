using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formaz
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            cbxMit.SelectedItem = "Szöveg";
            nudFontmeret.Value = 14;
            rtbEredm.BackColor = Color.White;

        }

        private void btnAtir_Click(object sender, EventArgs e)
        {
            rtbEredm.Text = textBox1.Text;
        }

        private void Szin()
        {
            if (cbxMit.SelectedItem == "Szöveg")
            {
                if (rbPiros.Checked) rtbEredm.ForeColor = Color.Red;
                else if (rbKek.Checked) rtbEredm.ForeColor = Color.Blue;
                else if (rbZold.Checked) rtbEredm.ForeColor = Color.Green;
            }
            else
            {
                if (rbPiros.Checked) rtbEredm.BackColor = Color.Red;
                else if (rbKek.Checked) rtbEredm.BackColor = Color.Blue;
                else if (rbZold.Checked) rtbEredm.BackColor = Color.Green;
            }
        }

        private void Fontbeallit()
        {
            rtbEredm.Font = new Font(GetFontName(), GetFontMeret(), GetFontStyle());
            
        }

        private FontStyle GetFontStyle()
        {
            FontStyle rt = FontStyle.Regular;
            if (cbxDolt.Checked) rt |= FontStyle.Italic;
            if (cbxAlahuzott.Checked) rt |= FontStyle.Underline;
            if (cbxFelkover.Checked) rt |= FontStyle.Bold;
            return rt;
        }

        private int GetFontMeret()
        {
            return (int)nudFontmeret.Value;
        }


        private string GetFontName()
        {
            if (rbArial.Checked) return rbArial.Text;
            if (rbTimes.Checked) return rbTimes.Text;
            if (rbComic.Checked) return rbComic.Text;
            return String.Empty;
        }



        private void btnAlkalmaz_Click(object sender, EventArgs e)
        {
            Szin();
            Fontbeallit();
        }

        private void Kikapcs()
        {
            if (cbxMit.SelectedItem == "Háttér")
            {
                gbxStilus.Enabled = false;
                gbxFont.Enabled = false;
                nudFontmeret.Enabled = false;
            }
            else
            {
                gbxStilus.Enabled = true;
                gbxFont.Enabled = true;
                nudFontmeret.Enabled = true;
            }
        }

        private void cbxMit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kikapcs();
        }
    }
}

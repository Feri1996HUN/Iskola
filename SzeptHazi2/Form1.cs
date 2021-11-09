using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzeptHazi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNev.Visible = false;
            lblEv.Visible = false;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            Szamol();
        }


        private void Szamol()
        {
            bool mehet = false;
            if (tbxNev.Text == null || tbxNev.Text.All(char.IsNumber) == true)
            {
                MessageBox.Show("Nem nevet adtál meg!");
            }
            else
            {
                lblNev.Text = tbxNev.Text;
                mehet = true;
            }
            if (mehet == true)
            {
                int ev = 0;
                ev = DateTime.Now.Year - Convert.ToInt32(nudEv.Value);
                tbxNev.Visible = false;
                nudEv.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnSzamol.Visible = false;
                lblEv.Visible = true;
                lblNev.Visible = true;
                lblEv.Text = Convert.ToString(ev);
                this.BackColor = Color.FromArgb(0, 0, 255);
            }
            
        }
    }
}

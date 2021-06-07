using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinvalaszto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSzinez_Click(object sender, EventArgs e)
        {
            Szinez();
        }

        private void Szinez()
        {
            ColorDialog colorDialog1 = new ColorDialog();
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lblSzines.BackColor = colorDialog1.Color;
                lblAdatok.Text = colorDialog1.Color.ToString();
            }
               
        }
    }
}

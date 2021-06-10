using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHatterSzinez
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKerdes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Piros legyen a háttér?", "Háttér", MessageBoxButtons.YesNo) == DialogResult.Yes) this.BackColor = Color.Red;  
            else this.BackColor = Color.Green;
        }
    }
}

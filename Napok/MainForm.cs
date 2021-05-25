using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napok
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Szamol(object sender, DateRangeEventArgs e)
        {
            lblEredm.Text = ("Eredmény napokban: ") + Convert.ToString(mcZaro.SelectionStart.Date.Subtract(mcKezd.SelectionStart.Date).Days);
        }


    }
}

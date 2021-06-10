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
    public partial class Uzenet : Form
    {
        public Uzenet()
        {
            InitializeComponent();
        }

        public void setLabel(string a)
        {
            lblUzenet.Text = a;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

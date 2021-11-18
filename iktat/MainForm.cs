using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatDataSet.users' table. You can move, or remove it, as needed.

        }

        private void levélToolStripMenuItem_Click(object sender, EventArgs e)
        {
            letterone frm = new letterone();
            frm.ShowDialog();
        }

        private void levélListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lettersgrid frm = new lettersgrid();
            frm.ShowDialog();
        }

        private void iktatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iktatform frm = new iktatform();
            frm.ShowDialog();
        }

        private void valami1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usertetel frm = new usertetel();
            frm.ShowDialog();
        }

        private void valami2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
            frm.ShowDialog();
        }
    }
}

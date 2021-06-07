using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKep_Click(object sender, EventArgs e)
        {
            Kep();
        }

        private void Kep()
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = new Bitmap(of.FileName);

            }

        }



    }
}

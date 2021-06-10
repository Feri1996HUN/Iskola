using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalisFormSzambekeres
{
    public partial class Beker : Form
    {
        int szam;
        public Beker()
        {
            InitializeComponent();
        }

        private void Szambeker()
        {
            try
            {
                szam = Convert.ToInt32(tbxSzam.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem számot adtál meg");
            }
        }

        public int getszam()
        {
            return szam;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Szambeker();

        }
    }
}

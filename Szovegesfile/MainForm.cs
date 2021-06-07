using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szovegesfile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Szoveg()
        {
            tbxSzoveg.Text = String.Empty;
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(of.FileName, FileMode.Open);
                StreamReader rs = new StreamReader(fs);
                string s = rs.ReadToEnd();
                tbxSzoveg.Text = s;
                rs.Close();
                fs.Close();
            }

        }

        private void Mentes()
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                StreamWriter wr = new StreamWriter(fs);
                wr.Write(tbxSzoveg.Text);
                wr.Close();
                fs.Close();
            }
        }

        private void btnSzoveg_Click(object sender, EventArgs e)
        {
            Szoveg();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            Mentes();
        }
    }
}

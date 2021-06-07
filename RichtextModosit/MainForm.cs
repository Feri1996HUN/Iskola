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

namespace RichtextModosit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Megnyit(object sender, EventArgs e)
        {
            rtbSzoveg.Text = String.Empty;
            OpenFileDialog of = new OpenFileDialog();
            //"Text files (*.txt)|*.txt|All files (*.*)|*.*"'
            of.Filter = "Rich Text files (*.rtf)|*.rtf";
            if (of.ShowDialog() == DialogResult.OK)
            {
                rtbSzoveg.LoadFile(of.FileName);
            }
        }

        private void Hatterszin(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtbSzoveg.BackColor = cd.Color;
            }
        }

        private void Fontos(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtbSzoveg.Font = fd.Font;
            }

        }

        private void Mentes(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Rich Text files (*.rtf)|*.rtf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                rtbSzoveg.SaveFile(sf.FileName);
            }

        }

    }
}

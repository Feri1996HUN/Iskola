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

namespace ModalisKiscserkesz
{
    public partial class MainForm : Form
    {
        public struct Cserkesz
        {
            public string azonosito;
            public string nev;
            public DateTime datum;
        }
        Cserkesz keszadat = new Cserkesz();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Adat()
        {
            Adatbevitel frm = new Adatbevitel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                keszadat.azonosito = frm.Getadat().azonosito;
                keszadat.nev = frm.Getadat().nev;
                keszadat.datum = frm.Getadat().datum;
                lbxAdatok.Items.Add(keszadat.azonosito + "; " + keszadat.nev + "; " + keszadat.datum.ToString("yyyy-MM-dd"));
            }
        }

        private void Mentes()
        {
            int i = 0;
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                StreamWriter wr = new StreamWriter(fs);
                while(lbxAdatok.Items.Count > i)
                {
                    wr.Write(lbxAdatok.Items[i] + "\n");
                    i++;
                }
                wr.Close();
                fs.Close();
            }
        }

        private void Olvasas()
        {
            lbxAdatok.Items.Clear();
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(of.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    lbxAdatok.Items.Add(s);
                }
                
                sr.Close();
                fs.Close();
            }

        }


        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            Adat();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            Olvasas();
        }
    }
}

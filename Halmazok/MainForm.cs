using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmazok
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            // A halmaz legenerálása
            Halmazgen((int)nudA.Value, lbxA);

            // B halmaz legenerálása
            Halmazgen((int)nudB.Value, lbxB);
            
            // A U B
            for (int i = 0; i < lbxA.Items.Count; i++) lbxAuB.Items.Add(lbxA.Items[i]);
            for (int i = 0; i < lbxB.Items.Count; i++) if (!Bennevan(lbxB.Items[i], lbxAuB)) lbxAuB.Items.Add(lbxB.Items[i]);

            // A M B
            for (int i = 0; i < lbxA.Items.Count; i++) if (Bennevan(lbxA.Items[i], lbxB)) lbxAmB.Items.Add(lbxA.Items[i]);

            // A - B
            for (int i = 0; i < lbxA.Items.Count; i++) if (!Bennevan(lbxA.Items[i], lbxB)) lbxAbolB.Items.Add(lbxA.Items[i]);

            // B - A
            for (int i = 0; i < lbxB.Items.Count; i++) if (!Bennevan(lbxB.Items[i], lbxA)) lbxBbolA.Items.Add(lbxB.Items[i]);

            // db szám kiírása
            Dbkiir();
        }

        private void Dbkiir()
        {
            lblAdb.Text = Convert.ToString(lbxA.Items.Count) + " db";
            lblBdb.Text = Convert.ToString(lbxB.Items.Count) + " db";
            lblAuBdb.Text = Convert.ToString(lbxAuB.Items.Count) + " db";
            lblAmBdb.Text = Convert.ToString(lbxAmB.Items.Count) + " db";
            lblAbolBdb.Text = Convert.ToString(lbxAbolB.Items.Count) + " db";
            lblBbolAdb.Text = Convert.ToString(lbxBbolA.Items.Count) + " db";
        }


        private void Halmazgen(int k, ListBox lbx)
        {
            bool paros = false;
            int szam, j = 0;
            // A halmaz legenerálása

            while (j < k)
            {
                paros = false;
                szam = rnd.Next(1, 100);
                for (int p = 0; p < lbx.Items.Count; p++)
                {
                    if (szam == (int)lbx.Items[p])
                    {
                        paros = true;
                    }
                }
                if (!paros)
                {
                    lbx.Items.Add(szam);
                    j++;
                }
            }
        }

        private bool Bennevan(object elem, ListBox lbx)
        {
            for (int p = 0; p < lbx.Items.Count; p++)
            {
                if ((int)elem == (int)lbx.Items[p])
                {
                    return true;
                }
            }
            return false;
        }

    }

    
}

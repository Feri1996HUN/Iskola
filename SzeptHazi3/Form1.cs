using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzeptHazi3
{
    public partial class Form1 : Form
    {
        int min = 1, max = 101;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMegold_Click(object sender, EventArgs e)
        {
            Torol();
            General();
            Rendez();
        }

        private void General()
        {
            int[] tomb = new int[Convert.ToInt32(nudDB.Value)];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(min, max);
                ltbTomb.Items.Add(tomb[i]);
            }
        }

        private void Rendez()
        {
            for (int i = 0; i < ltbTomb.Items.Count; i++)
            {
                ltbRendez.Items.Add(ltbTomb.Items[i]);
            }
            int db = ltbTomb.Items.Count, n;
            for (int i = db - 1; i > 0; i--)
            {
                for (int p = 0; p < i; p++)
                {
                    if (Convert.ToInt32(ltbRendez.Items[p]) > Convert.ToInt32(ltbRendez.Items[p + 1]))
                    {
                        n = Convert.ToInt32(ltbRendez.Items[p]);
                        ltbRendez.Items[p] = ltbRendez.Items[p+1];
                        ltbRendez.Items[p + 1] = n;
                    }
                }
            }
        }
        private void Torol()
        {
            ltbTomb.Items.Clear();
            ltbRendez.Items.Clear();
        }
    }
}

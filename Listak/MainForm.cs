using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hozzaad(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Name == "btnBalAd") lsbBal.Items.Add(txbBal.Text);
                else lsbJobb.Items.Add(txbJobb.Text);
            }
        }
        
        private void Torol(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Name == "btnBalTorol") lsbBal.Items.RemoveAt(lsbBal.SelectedIndex);
                else lsbJobb.Items.RemoveAt(lsbJobb.SelectedIndex);
            }
        }

        private void Felulre(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnBalFelulre") FelulreMost(lsbBal);
            else FelulreMost(lsbJobb);
        }

        private void FelulreMost(ListBox lsb)
        {
            lsb.Items.Insert(0, lsb.SelectedItem);
            lsb.Items.RemoveAt(lsb.SelectedIndex);
            lsb.SelectedIndex = 0;
        }

        private void Alulra(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnBalAlulra") AlulraMost(lsbBal);
            else AlulraMost(lsbJobb);
        }

        private void AlulraMost(ListBox lsb)
        {
            lsb.Items.Add(lsb.SelectedItem);
            lsb.Items.RemoveAt(lsb.SelectedIndex);
            lsb.SelectedIndex = lsb.Items.Count - 1;
        }

        private void Fel(object sender, EventArgs e)
        {

            if ((sender as Button).Name == "btnBalFel") FelMost(lsbBal);
            else FelMost(lsbJobb);
        }

        private void FelMost(ListBox lsb)
        {
            object szoveg = lsb.SelectedItem;
            int hely = lsb.SelectedIndex;
            if (hely > 0)
            {
                lsb.Items.RemoveAt(lsb.SelectedIndex);
                lsb.Items.Insert(hely - 1, szoveg);
                lsb.SelectedIndex = hely - 1;
            }
        }

        private void Le(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnBalLe") LeMost(lsbBal);
            else LeMost(lsbJobb);
        }

        private void LeMost(ListBox lsb)
        {
            object szoveg = lsbBal.SelectedItem;
            int hely = lsbBal.SelectedIndex;
            if (hely < lsbBal.Items.Count - 1)
            {
                lsbBal.Items.RemoveAt(lsbBal.SelectedIndex);
                lsbBal.Items.Insert(hely + 1, szoveg);
                lsbBal.SelectedIndex = hely + 1;
            }
        }

        private void Jobbra(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnJobbra") Masol(lsbBal, lsbJobb);
            else Masol(lsbJobb, lsbBal);
        }

        private void Masol(ListBox mibol, ListBox mibe)
        {
            if (mibol.SelectedItem != null)
            {
                mibe.Items.Add(mibol.SelectedItem);
                mibol.Items.RemoveAt(mibol.SelectedIndex);
            }
        }

    }
}

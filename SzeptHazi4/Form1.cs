using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzeptHazi4
{
    public partial class Form1 : Form
    {
        int hossz = 10;
        int min = 1, max = 101;
        Random r = new Random();
        List<int> lista = new List<int>();
        

        public Form1()
        {
            InitializeComponent();
            General();
        }

        private void General()
        {
            for (int i = 0; i < hossz; i++)
            {
                lista.Add(r.Next(min, max));
                ltbArray.Items.Add(lista[i]);
            }

            int legkisebb = max, legnagyobb = min, sum = 0;
            double atlag;
            foreach (int i in lista)
            {
                if (legkisebb > i) legkisebb = i;
                if (legnagyobb < i) legnagyobb = i;
                sum += i;
            }
            atlag = (double)sum / (double)lista.Count;
            lblMegoldas.Text = string.Format("A lista legkisebb eleme: {0}\n" +
                "A lista legnagyobb eleme: {1}\n" +
                "A lista elemeinek összege: {2}\n" +
                "A lista elemeinek átlaga: {3}", legkisebb, legnagyobb, sum, atlag);
        }
    }
}

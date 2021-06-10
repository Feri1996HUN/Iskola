using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaJatekProgram
{
    public partial class Megold : Form
    {
        Szabaly adatfelhaszn = new Szabaly();
        public Megold()
        {
            InitializeComponent();
        }

        public void SetAdat(Szabaly adat)
        {
            adatfelhaszn = adat;
        }

        public void Megoldas(int[] megoldas)
        {
            if (adatfelhaszn.hanyszam == 9)
            {
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                megoldas[0] = Convert.ToInt32(textBox1.Text);
                megoldas[1] = Convert.ToInt32(textBox2.Text);
                megoldas[2] = Convert.ToInt32(textBox3.Text);
                megoldas[3] = Convert.ToInt32(textBox4.Text);
                megoldas[4] = Convert.ToInt32(textBox5.Text);
                megoldas[5] = Convert.ToInt32(textBox6.Text);
                megoldas[6] = Convert.ToInt32(textBox7.Text);
                megoldas[7] = Convert.ToInt32(textBox8.Text);
                megoldas[8] = Convert.ToInt32(textBox9.Text);
            }
            else
            {
                megoldas[0] = Convert.ToInt32(textBox1.Text);
                megoldas[1] = Convert.ToInt32(textBox2.Text);
                megoldas[2] = Convert.ToInt32(textBox3.Text);
                megoldas[3] = Convert.ToInt32(textBox4.Text);
                megoldas[4] = Convert.ToInt32(textBox5.Text);
                megoldas[5] = Convert.ToInt32(textBox6.Text);
            }
            Close();
        }
    }
}

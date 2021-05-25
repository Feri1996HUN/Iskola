using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int max = 1, min = 100;

        private void feltolt()
        {
            object[] intArray = new object[(int)nudOszlop.Value];
            dgvMatrix.Columns.Clear();
            dgvMatrix.Rows.Clear();
            // Oszlopok létrehozása
            for (int i = 0; i < nudOszlop.Value; i++)
            {
                dgvMatrix.Columns.Add(String.Empty, String.Empty);
                dgvMatrix.Columns[i].Width = 35;
            }

            // Soronként végigmegyünk
            for (int i = 0; i < (int)nudSor.Value; i++)
            {
                // A sor előállítása
                for (int p = 0; p < (int)nudOszlop.Value; p++)
                {
                    intArray[p] = rnd.Next(max, min);
                }

                // Sor hozzáadása a mátrixhoz 
                dgvMatrix.Rows.Add(intArray);

            }
        }

        private void legkisebb()
        {
            int mini = 0, minp = 0;
            // legkisebb szám, leg kis szám index
            int sor = dgvMatrix.Rows.Count;
            int oszlop = dgvMatrix.Columns.Count;
            for (int i = 0; i < sor; i++)
            {
                for (int p = 0; p < oszlop; p++)
                {
                    if (Convert.ToInt32(dgvMatrix[p, i].Value) < min)
                    {
                        min = Convert.ToInt32(dgvMatrix[p, i].Value);
                        mini = i;
                        minp = p;
                    }
                }
                
            }
            rtbEredm.AppendText(String.Format("A legkisebb szám: {0} \n", min));
            rtbEredm.AppendText(String.Format("A legkisebb szám indexe: {0}, {1} \n", minp, mini));
        }

        private void legnagyobb()
        {
            int maxi = 0, maxp = 0;
            // legnagyobb szám, leg nagyobb szám index
            for (int i = 0; i < (int)nudSor.Value; i++)
            {
                for (int p = 0; p < (int)nudOszlop.Value; p++)
                {
                    if (Convert.ToInt32(dgvMatrix[p, i].Value) > max)
                    {
                        max = Convert.ToInt32(dgvMatrix[p, i].Value);
                        maxi = i;
                        maxp = p;
                    }
                }

            }
            rtbEredm.AppendText(String.Format("A legnagyobb szám: {0} \n", max));
            rtbEredm.AppendText(String.Format("A legnagyobb szám indexe: {0}, {1} \n", maxp, maxi));
        }

        private void atlag()
        {
            // számok átlaga
            int atlag = 0;
            for (int i = 0; i < (int)nudSor.Value; i++)
            {
                for (int p = 0; p < (int)nudOszlop.Value; p++)
                {
                    atlag += Convert.ToInt32(dgvMatrix[p, i].Value);
                }

            }
            atlag /= ((int)nudOszlop.Value * (int)nudSor.Value);
            rtbEredm.AppendText(String.Format("A számok átlaga: {0} \n", atlag));
        }

        private void btnMehet_Click(object sender, EventArgs e)
        {

            feltolt();

            legkisebb();

            legnagyobb();

            atlag();
            
        }
    }
}

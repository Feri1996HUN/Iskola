using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaziFeladatmatrixForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int min = 10, max = -10;

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            General1();
            General2();
            Skalar();
            AtloOsszeg();
            Terulet();
        }

        private void General2()
        {
            object[] intArray = new object[(int)nudMatrix.Value];
            dgvMatrix2.Columns.Clear();
            dgvMatrix2.Rows.Clear();

            for (int i = 0; i < nudMatrix.Value; i++)
            {
                dgvMatrix2.Columns.Add(String.Empty, String.Empty);
                dgvMatrix2.Columns[i].Width = 30;
            }


            for (int i = 0; i < (int)nudMatrix.Value; i++)
            {

                for (int p = 0; p < (int)nudMatrix.Value; p++)
                {
                    intArray[p] = r.Next(max, min);
                }

                dgvMatrix2.Rows.Add(intArray);

            }
        }
            private void General1()
        {
            object[] intArray = new object[(int)nudMatrix.Value];
            dgvMatrix1.Columns.Clear();
            dgvMatrix1.Rows.Clear();
            
            for (int i = 0; i< nudMatrix.Value; i++)
            {
                dgvMatrix1.Columns.Add(String.Empty, String.Empty);
                dgvMatrix1.Columns[i].Width = 30;
            }

            
            for (int i = 0; i<(int)nudMatrix.Value; i++)
            {
                
                for (int p = 0; p<(int)nudMatrix.Value; p++)
                {
                    intArray[p] = r.Next(max, min);
                }

            dgvMatrix1.Rows.Add(intArray);

            }
        }

        private void Skalar()
        {
            int skalar = 0;
            for (int i = 0; i < (int)nudMatrix.Value; i++)
            {
                for (int p = 0; p < (int)nudMatrix.Value; p++)
                {
                    skalar = Convert.ToInt32(dgvMatrix1.Rows[i].Cells[p].Value) * Convert.ToInt32(dgvMatrix2.Rows[i].Cells[p].Value);
                }
            }
            lblSkalar.Text = String.Format("A két mártix skaláris szorzata: {0}", skalar);
        }

        private void AtloOsszeg()
        {
            int atlo1 = 0, atlo2 = 0;
            for (int i = 0; i < nudMatrix.Value; i++)
            {
                atlo1 += Convert.ToInt32(dgvMatrix1.Rows[i].Cells[i].Value);
                atlo2 += Convert.ToInt32(dgvMatrix2.Rows[i].Cells[i].Value);
            }

            lblAtlo.Text = String.Format("A két mártix átlóösszegének ({0}, {1}) különbsége: {2}",atlo1, atlo2, atlo1-atlo2);
        }

        private void Terulet()
        {
            int terulet = 0, n=0;

            if (Convert.ToInt32(nudMatrix.Value) % 2 == 0)
            {
                for (int i = 0; i < (int)nudMatrix.Value / 2 - 1; i++)
                {
                    for (int p = 1 + n; p < (int)nudMatrix.Value - i - 1; p++)
                    {
                        terulet += Convert.ToInt32(dgvMatrix1.Rows[i].Cells[p].Value);
                    }
                    n++;
                }
                lblTerulet.Text = String.Format("Az első mátrix két átló feletti terület összege: {0}", terulet);
            }
            else
            {
                for (int i = 0; i < ((int)nudMatrix.Value -1 )/2; i++)
                {
                    for (int p = 1 + n; p < (int)nudMatrix.Value - i - 1; p++)
                    {
                        terulet += Convert.ToInt32(dgvMatrix1.Rows[i].Cells[p].Value);
                    }
                    n++;
                }
                lblTerulet.Text = String.Format("Az első mátrix két átló feletti terület összege: {0}", terulet);
            }
        }



    }
}

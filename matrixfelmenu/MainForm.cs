using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixfelmenu
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        int sorok = 3, oszlopok = 3, szelesseg = 35;
        public MainForm()
        {
            InitializeComponent();
            General();
        }

        private void General()
        {
            Matrix(dgvSzamok);
            for (int i = 0; i < sorok; i++)
            {
                // sor létrehozása
                DataGridViewRow sor = new DataGridViewRow();
                for (int p = 0; p < oszlopok; p++)
                {
                    // cella létrehozása
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    // cella feltöltése véletlen számokkal
                    cell.Value = vsz.Next(10, 21);
                    // cellák hozzáadása a sorokhoz
                    sor.Cells.Add(cell);
                }
                // sorok hozzáadása a mátrixhoz (datagridviewhoz)
                dgvSzamok.Rows.Add(sor);
            }


        }

        private void Matrix(DataGridView a)
        {
            a.Rows.Clear();
            a.Columns.Clear();

            for (int i = 0; i < oszlopok; i++)
            {
                a.Columns.Add(String.Empty, String.Empty);
                a.Columns[i].Width = szelesseg;
            }
        }

        private void Transzponalas(object sender, EventArgs e)
        {
            Matrix(dgvEredm);
            for (int i = 0; i < oszlopok; i++)
            {
                DataGridViewRow sor = new DataGridViewRow();
                for (int p = 0; p < sorok; p++)
                { 
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = dgvSzamok.Rows[p].Cells[i].Value;
                    sor.Cells.Add(cell);
                }
                dgvEredm.Rows.Add(sor);
            }
        }

        private void Paratlan(object sender, EventArgs e)
        {
            int osszeg = 0;
            for (int i = 0; i < sorok; i++)
            {

                for ( int p = 0; p < oszlopok; p++)
                {
                    if (Convert.ToInt32(dgvSzamok.Rows[i].Cells[p].Value) % 2 == 1) osszeg += Convert.ToInt32(dgvSzamok.Rows[i].Cells[p].Value);
                }
            }
            lblMegoldas.Text = String.Format("Páratlan számok összege: {0}", osszeg);
        }

        private void Foatlo(object sender, EventArgs e)
        {
            int osszeg = 0;
            for (int i = 0; i < sorok; i++)
            {
                osszeg += Convert.ToInt32(dgvSzamok.Rows[i].Cells[i].Value);
            }
            lblMegoldas.Text = String.Format("Főátló összege: {0}", osszeg);
        }

        private void SorokOsszeg(object sender, EventArgs e)
        {
            int osszeg = 0;
            int i = 0;
            for (i = 0; i < sorok; i++)
            {
                osszeg = 0;
                for (int p = 0; p < oszlopok; p++)
                {
                    osszeg += Convert.ToInt32(dgvSzamok.Rows[i].Cells[p].Value);
                }
                lblMegoldas.Text += String.Format(" \n {0}. sor összege: {1}", i + 1, osszeg);
            }   
        }

        private void OszlopokOsszeg(object sender, EventArgs e)
        {
            int osszeg = 0;
            int i = 0;
            for (i = 0; i < oszlopok; i++)
            {
                osszeg = 0;
                for (int p = 0; p < sorok; p++)
                {
                    osszeg += Convert.ToInt32(dgvSzamok.Rows[p].Cells[i].Value);
                }
                lblMegoldas.Text += String.Format(" \n {0}. oszlop összege: {1}", i + 1, osszeg);
            }
        }
    }
}

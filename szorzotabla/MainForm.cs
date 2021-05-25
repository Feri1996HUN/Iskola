using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szorzotabla
{
    public partial class MainForm : Form
    {
        // Osztályváltozók
        private int szeles = 35;    // Mező szélessége
        private int sorOszlop = 10;    // Sorok és oszlopok száma
        private int keret = 50;     // Táblázat körüli keret mérete
        private Random rnd = new Random();
        private int jodb = 0, rosszdb = -1;
        private int aktualsor, aktualoszlop;
        private string txtjo = "Jó válaszok száma: {0}";
        private string txtrossz = "Rossz válaszok száma: {0}";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TablaEpit(sorOszlop);
        }

        private void TablaEpit(int sor)
        {
            // Töröljük a sorokat és oszlopokat
            dgvSzor.Columns.Clear();
            dgvSzor.Rows.Clear();

            // Táblázat méretének meghatározása
            dgvSzor.Width = sorOszlop * szeles + 2 * keret;

            // Generálom az oszlopokat
            for (int i = 0; i < sorOszlop; i++)
            {
                dgvSzor.Columns.Add(String.Empty, String.Empty);
                dgvSzor.Columns[i].Width = szeles;
            }

            // Sorok generálása
            for (int i = 0; i < sorOszlop; i++)
            {
                object[] sortomb = new object[sorOszlop];
                dgvSzor.Rows.Add(sortomb);
            }

            // Fejléc megadása
            for (int i = 0; i < sorOszlop; i++)
            {
                dgvSzor[0, i].Value = i;
                dgvSzor[0, i].Style.Font = new Font(dgvSzor.Font, FontStyle.Bold);
                dgvSzor[i, 0].Value = i;
                dgvSzor[i, 0].Style.Font = new Font(dgvSzor.Font, FontStyle.Italic);
            }



        }

        private void sorsol()
        {
            int sorsorsol = rnd.Next(1, sorOszlop);
            int oszlopsorsol = rnd.Next(1, sorOszlop);
            while (dgvSzor[oszlopsorsol, sorsorsol].Style.BackColor == Color.LightBlue)
            {
                    sorsorsol = rnd.Next(1, sorOszlop);
                    oszlopsorsol = rnd.Next(1, sorOszlop);
            }
            dgvSzor[oszlopsorsol, sorsorsol].Style.BackColor = Color.LightBlue;
            dgvSzor[oszlopsorsol, 0].Style.BackColor = Color.Orange;
            dgvSzor[0, sorsorsol].Style.BackColor = Color.Orange;

            // Fókusz beállítása a cellára
            dgvSzor.Focus();
            dgvSzor.CurrentCell = dgvSzor.Rows[sorsorsol].Cells[oszlopsorsol];

            aktualoszlop = oszlopsorsol;
            aktualsor = sorsorsol;

            
        }

        private void btnFeladat_Click(object sender, EventArgs e)
        {
            sorsol();

        }

        private void dgvSzor_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvSzor[aktualoszlop, aktualsor].Value == null)
            {
                rosszdb++;
                lblRossz.Text = String.Format(txtrossz, rosszdb);
            }
        }

        private void ellenoriz(int sor, int oszlop)
        {
            if (Convert.ToInt32(dgvSzor[oszlop, sor].Value) == (oszlop * sor))
            {
                jodb++;
                lblJo.Text = String.Format(txtjo, jodb);
            }
            else
            {
                rosszdb++;
                lblRossz.Text = String.Format(txtrossz, rosszdb);
            }

            if ((jodb + rosszdb) == ((sorOszlop - 1) * (sorOszlop - 1)))
                {
                MessageBox.Show("Gratulálok, teljesítetted a szorzótáblát!");
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void dgvSzor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ellenoriz(e.RowIndex, e.ColumnIndex);
        }
    }
}

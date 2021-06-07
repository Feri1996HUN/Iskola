using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixTabcontrol
{
    public partial class MainForm : Form
    {
        Random vsz = new Random();
        int sor = 3, oszlop = 3, mindb = 1, maxdb = 20;
        public MainForm()
        {
            InitializeComponent();
            Matrix();
            Transzponalt();
            Keres();
        }

        private void UresMatrix(DataGridView matrix)
        {
            matrix.Rows.Clear();
            matrix.Columns.Clear();
            for (int i = 0; i < oszlop; i++)
            {
                matrix.Columns.Add(String.Empty, String.Empty);
            }
            for (int i = 0; i < sor; i++)
            {
                DataGridViewRow sor = new DataGridViewRow();
                for (int p = 0; p < oszlop; p++)
                {
                    DataGridViewCell cella = new DataGridViewTextBoxCell();
                    cella.Value = String.Empty;
                    sor.Cells.Add(cella);
                }
                matrix.Rows.Add(sor);
            }
        }


        private void Matrix()
        {
            UresMatrix(dgvMatrix);
            for (int i = 0; i < sor; i++)
            {
                for (int p = 0; p < oszlop; p++)
                {
                    dgvMatrix.Rows[i].Cells[p].Value = vsz.Next(mindb, maxdb + 1);
                }
            }
        }

        private void Transzponalt()
        {
            UresMatrix(dgvTranszponal);
            for (int i = 0; i < oszlop; i++)
            {
                for (int p = 0; p < sor; p++)
                {
                    dgvTranszponal.Rows[p].Cells[i].Value = dgvMatrix.Rows[i].Cells[p].Value;
                }
            }
        }

        private void btnSkalar_Click(object sender, EventArgs e)
        {
            Skalar();
            tabControl1.SelectTab(2);
        }

        private void Skalar()
        {
            UresMatrix(dgvSkalar);
            for (int i = 0; i < sor; i++)
            {
                for (int p = 0; p < oszlop; p++)
                {
                    dgvSkalar.Rows[i].Cells[p].Value = (Convert.ToInt32(dgvMatrix.Rows[i].Cells[p].Value) * (int)nudSkalar.Value);
                }
            }
            
        }

        private void Keres()
        {
            int min = maxdb, max = mindb;
            for (int i = 0; i < sor; i++)
            {
                for (int p = 0; p < oszlop; p++)
                {
                    if (min > Convert.ToInt32(dgvMatrix.Rows[i].Cells[p].Value)) min = Convert.ToInt32(dgvMatrix.Rows[i].Cells[p].Value);
                    if (max < Convert.ToInt32(dgvMatrix.Rows[i].Cells[p].Value)) max = Convert.ToInt32(dgvMatrix.Rows[i].Cells[p].Value);
                }
            }
            lblLegkisebb.Text = Convert.ToString(min);
            lblLegnagyobb.Text = Convert.ToString(max);
        }

    }
}

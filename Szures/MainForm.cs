using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szures
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        int szamgen = 50;
        int mingen = 1, maxgen = 9999;
        string stat = "Statisztika: \n Összes szám: {0} \n Szűrt számok: {1}";
        List<int> primek = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void General()
        {
            if (cbxTorol.Checked) lbxBal.Items.Clear();
            int szam, i = 0, p;
            bool paros;
            int[] tomb = new int[szamgen];
            tomb[0] = rnd.Next(mingen, maxgen);
            while (i < szamgen - 1)
            {
                paros = false;
                szam = rnd.Next(mingen, maxgen);
                for (p = 0; p <= i; p++)
                {
                    if (tomb[p] == szam)
                    {
                        paros = true;
                        break;
                    }
                }
                if (!paros &&  i < szamgen - 1)
                {
                    i++;
                    tomb[i] = szam;
                    lbxBal.Items.Add(szam);
                }
            }
        }

        private void Primek()
        {
            primek.Add(2);
            bool prim = true;
            for (int i = 3; i < maxgen; i++)
            {
                prim = true;
                foreach (int p in primek)
                {
                    if ((i % p) == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim) primek.Add(i);
            }
        }
        private void Primirat()
        {
            lbxJobb.Items.Add("Prím számok");
            foreach (int i in lbxBal.Items)
            {
                Isprim(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }
        private void Isprim(int i)
        {
            foreach (int p in primek)
            {
                if (i == p)
                {
                    lbxJobb.Items.Add(i);
                    break;
                }
            }
        }

            
        private void Kiiratas()
        {
            for (int i = 0; i < clbSzures.CheckedItems.Count; i++)
            {
                switch (clbSzures.CheckedItems[i])
                {
                    case "Prímek": 
                        Primirat();
                        break;
                    case "Páros számok":
                        Paros();
                        break;
                    case "Páratlan számok":
                        Paratlan();
                        break;
                    case "Hárommal osztható számok":
                        Harom();
                        break;
                    case "Hattal osztható számok":
                        Hat();
                        break;
                    case "Kilencel osztható számok":
                        Kilenc();
                        break;
                    case "Négyzetszámok":
                        Negyzet();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Dupla()
        {
            if (cbxDupla.Checked)
            {
                foreach (int i in lbxBal.Items)
                {
                    for (int p = 0; p < clbSzures.CheckedItems.Count; p++)
                    {
                        switch (clbSzures.CheckedItems[p])
                        {
                            case "Prímek":
                                Isprim(i);
                                break;
                            case "Páros számok":
                                Isparos(i);
                                break;
                            case "Páratlan számok":
                                Isparatlan(i);
                                break;
                            case "Hárommal osztható számok":
                                Isharom(i);
                                break;
                            case "Hattal osztható számok":
                                Ishat(i);
                                break;
                            case "Kilencel osztható számok":
                                Iskilenc(i);
                                break;
                            case "Négyzetszámok":
                                Isnegyzet(i);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void Negyzet()
        {
            lbxJobb.Items.Add("Négyzetszámok");
            foreach (int i in lbxBal.Items)
            {
                Isnegyzet(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Isnegyzet(int i)
        {
            double p = Math.Sqrt((double)i);
            if (p == Math.Floor(p)) lbxJobb.Items.Add(i);
        }

        private void Kilenc()
        {
            lbxJobb.Items.Add("Kilenccel osztható számok");
            foreach (int i in lbxBal.Items)
            {
                Iskilenc(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Iskilenc(int i)
        {
            if (i % 9 == 0) lbxJobb.Items.Add(i);
        }

        private void Hat()
        {
            lbxJobb.Items.Add("Hattal osztható számok");
            foreach (int i in lbxBal.Items)
            {
                Ishat(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Ishat(int i)
        {
            if (i % 6 == 0) lbxJobb.Items.Add(i);
        }

        private void Harom()
        {
            lbxJobb.Items.Add("Hárommal osztható számok");
            foreach (int i in lbxBal.Items)
            {
                Isharom(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Isharom(int i)
        {
            if (i % 3 == 0) lbxJobb.Items.Add(i);
        }

        private void Paratlan()
        {
            lbxJobb.Items.Add("Páratlan számok");
            foreach (int i in lbxBal.Items)
            {
                Isparatlan(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Isparatlan(int i)
        {
            if (i % 2 != 0) lbxJobb.Items.Add(i);
        }

        private void Paros()
        {
            lbxJobb.Items.Add("Páros számok");
            foreach (int i in lbxBal.Items)
            {
                Isparos(i);
            }
            lbxJobb.Items.Add("* * * * * * * *");
        }

        private void Isparos(int i)
        {
            if (i % 2 == 0) lbxJobb.Items.Add(i);
        }


        private void Statisztika()
        {
            lblStatisztika.Text = String.Format(stat, lbxBal.Items.Count, lbxJobb.Items.Count);
        }

        private void btnSzur_Click(object sender, EventArgs e)
        {
            if (cbxDupla.Checked) Dupla();
            else Kiiratas();
            Statisztika();
        }

        private void clbSzures_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxJobb.Items.Clear();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            General();
            Statisztika();
        }
    }
}

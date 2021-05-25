﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szoveg
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            // Meghatározzuk a kattintás helyét
            // A label területét 3 x 3 = 9 egységre osztjuk
            int n = e.X / (label1.Width / 3); // Megadja, hogy vízszintesen melyik tartományba kattintottunk
            int m = e.Y / (label1.Height / 3); // Megadja, hogy függőlegesen melyik tartományba kattintottunk

            int ssz = m * 3 + n; // Beszámoztuk az egyes tartományokat 1 - 9

            switch (ssz)
            {
                case 0: label1.TextAlign = ContentAlignment.TopLeft; break;  
                case 1: label1.TextAlign = ContentAlignment.TopCenter; break; 
                case 2: label1.TextAlign = ContentAlignment.TopRight; break;
                case 3: label1.TextAlign = ContentAlignment.MiddleLeft; break; 
                case 4: label1.TextAlign = ContentAlignment.MiddleCenter; break;  
                case 5: label1.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: label1.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: label1.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: label1.TextAlign = ContentAlignment.BottomRight; break;
                default:
                    break;
            }


        }
    }
}

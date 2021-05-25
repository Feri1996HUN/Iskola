using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMove
{
    public partial class MainForm : Form
    {
        // Tagváltozók
        int meretvalt = 10;
        int mozgat = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNovekszik_Click(object sender, EventArgs e)
        {
            // Form mérete növekszik
            Width += meretvalt;
            Height += meretvalt;

        }

        private void btnCsokken_Click(object sender, EventArgs e)
        {
            // Form mérete csökken
            Width -= meretvalt;
            Height -= meretvalt;
        }

        private void btnAtlatNovek_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1) Opacity -= 0.1;
        
        }

        private void btnAtlatCsokken_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0) Opacity += 0.1;
        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            Top = 0;
            btnFelul.Enabled = false;
            btnFel.Enabled = false;
            btnKozepre.Enabled = true;
            btnLe.Enabled = true;
            btnAlulra.Enabled = true;
            btnBalra.Enabled = true;
            btnBalszel.Enabled = true;
            btnJobbra.Enabled = true;
            btnJobbszel.Enabled = true;
            
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            if (Top >= mozgat)
            {
                Top -= mozgat;
                btnKozepre.Enabled = true;
                btnLe.Enabled = true;
                btnAlulra.Enabled = true;
                btnBalra.Enabled = true;
                btnBalszel.Enabled = true;
                btnJobbra.Enabled = true;
                btnJobbszel.Enabled = true;
            }
            else
            {
                btnFel.Enabled = false;
                if (Top == 0)
                {
                    btnFelul.Enabled = false;
                    
                }
                    
            }
        }

        private void btnKozepre_Click(object sender, EventArgs e)
        {
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            btnKozepre.Enabled = false;
            btnFelul.Enabled = true;
            btnFel.Enabled = true;
            btnLe.Enabled = true;
            btnAlulra.Enabled = true;
            btnBalra.Enabled = true;
            btnBalszel.Enabled = true;
            btnJobbra.Enabled = true;
            btnJobbszel.Enabled = true;
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            if (Top <= (Screen.PrimaryScreen.Bounds.Height - Height - mozgat))
            {
                Top += mozgat;
                btnFelul.Enabled = true;
                btnFel.Enabled = true;
                btnKozepre.Enabled = true;
                btnAlulra.Enabled = true;
                btnBalra.Enabled = true;
                btnBalszel.Enabled = true;
                btnJobbra.Enabled = true;
                btnJobbszel.Enabled = true;
            }
            else
            {
                btnLe.Enabled = false;
                btnAlulra.Enabled = false;
            }
        }

        private void btnAlulra_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            btnFelul.Enabled = true;
            btnFel.Enabled = true;
            btnKozepre.Enabled = true;
            btnLe.Enabled = false;
            btnAlulra.Enabled = false;
            btnBalra.Enabled = true;
            btnBalszel.Enabled = true;
            btnJobbra.Enabled = true;
            btnJobbszel.Enabled = true;
        }

        private void btnJobbra_Click(object sender, EventArgs e)
        {
            if (Left <= (Screen.PrimaryScreen.Bounds.Width - Width - mozgat))
            {
                Left += mozgat;
                btnFelul.Enabled = true;
                btnFel.Enabled = true;
                btnKozepre.Enabled = true;
                btnLe.Enabled = true;
                btnAlulra.Enabled = true;
                btnBalra.Enabled = true;
                btnBalszel.Enabled = true;
            }
            else
            {
                btnJobbra.Enabled = false;
                btnJobbszel.Enabled = false;
            }
        }

        private void btnJobbszel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            btnFelul.Enabled = true;
            btnFel.Enabled = true;
            btnKozepre.Enabled = true;
            btnLe.Enabled = true;
            btnAlulra.Enabled = true;
            btnBalra.Enabled = true;
            btnBalszel.Enabled = true;
            btnJobbra.Enabled = false;
            btnJobbszel.Enabled = false;
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            if (Left > mozgat) 
            {
            Left -= mozgat;
            btnFelul.Enabled = true;
            btnFel.Enabled = true;
            btnKozepre.Enabled = true;
            btnLe.Enabled = true;
            btnAlulra.Enabled = true;
            btnJobbra.Enabled = true;
            btnJobbszel.Enabled = true;
            }
            else
            {
                btnBalra.Enabled = false;
                btnBalszel.Enabled = false;
            }
            

        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            Left = 0;
            btnFelul.Enabled = true;
            btnFel.Enabled = true;
            btnKozepre.Enabled = true;
            btnLe.Enabled = true;
            btnAlulra.Enabled = true;
            btnBalra.Enabled = false;
            btnBalszel.Enabled = false;
            btnJobbra.Enabled = true;
            btnJobbszel.Enabled = true;
        }
    }
}

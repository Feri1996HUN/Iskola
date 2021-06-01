namespace menumasodikfeladat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSzamok = new System.Windows.Forms.ListBox();
            this.tbxEredm = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generáltsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.töröltsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.újElemtsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.összeadástsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.szorzástsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDbszam = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLegkisebb = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLegnagyobb = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEredm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSzamok
            // 
            this.lbSzamok.FormattingEnabled = true;
            this.lbSzamok.Location = new System.Drawing.Point(12, 35);
            this.lbSzamok.Name = "lbSzamok";
            this.lbSzamok.Size = new System.Drawing.Size(146, 264);
            this.lbSzamok.TabIndex = 0;
            // 
            // tbxEredm
            // 
            this.tbxEredm.Location = new System.Drawing.Point(12, 305);
            this.tbxEredm.Name = "tbxEredm";
            this.tbxEredm.Size = new System.Drawing.Size(146, 20);
            this.tbxEredm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generáltsmi,
            this.töröltsmi,
            this.újElemtsmi,
            this.összeadástsmi,
            this.szorzástsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generáltsmi
            // 
            this.generáltsmi.Name = "generáltsmi";
            this.generáltsmi.Size = new System.Drawing.Size(59, 20);
            this.generáltsmi.Text = "Generál";
            this.generáltsmi.Click += new System.EventHandler(this.General);
            // 
            // töröltsmi
            // 
            this.töröltsmi.Name = "töröltsmi";
            this.töröltsmi.Size = new System.Drawing.Size(49, 20);
            this.töröltsmi.Text = "Törlés";
            this.töröltsmi.Click += new System.EventHandler(this.Torles);
            // 
            // újElemtsmi
            // 
            this.újElemtsmi.Name = "újElemtsmi";
            this.újElemtsmi.Size = new System.Drawing.Size(59, 20);
            this.újElemtsmi.Text = "Új elem";
            this.újElemtsmi.Click += new System.EventHandler(this.UjElem);
            // 
            // összeadástsmi
            // 
            this.összeadástsmi.Name = "összeadástsmi";
            this.összeadástsmi.Size = new System.Drawing.Size(73, 20);
            this.összeadástsmi.Text = "Összeadás";
            this.összeadástsmi.Click += new System.EventHandler(this.Osszeadas);
            // 
            // szorzástsmi
            // 
            this.szorzástsmi.Name = "szorzástsmi";
            this.szorzástsmi.Size = new System.Drawing.Size(57, 20);
            this.szorzástsmi.Text = "Szorzás";
            this.szorzástsmi.Click += new System.EventHandler(this.Szorzas);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDbszam,
            this.tsslLegkisebb,
            this.tsslLegnagyobb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDbszam
            // 
            this.tsslDbszam.Name = "tsslDbszam";
            this.tsslDbszam.Size = new System.Drawing.Size(84, 17);
            this.tsslDbszam.Text = "Lista db szám: ";
            // 
            // tsslLegkisebb
            // 
            this.tsslLegkisebb.Name = "tsslLegkisebb";
            this.tsslLegkisebb.Size = new System.Drawing.Size(95, 17);
            this.tsslLegkisebb.Text = "Legkisebb elem: ";
            // 
            // tsslLegnagyobb
            // 
            this.tsslLegnagyobb.Name = "tsslLegnagyobb";
            this.tsslLegnagyobb.Size = new System.Drawing.Size(108, 17);
            this.tsslLegnagyobb.Text = "Legnagyobb elem: ";
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(13, 332);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(0, 13);
            this.lblEredm.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbxEredm);
            this.Controls.Add(this.lbSzamok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSzamok;
        private System.Windows.Forms.TextBox tbxEredm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generáltsmi;
        private System.Windows.Forms.ToolStripMenuItem töröltsmi;
        private System.Windows.Forms.ToolStripMenuItem újElemtsmi;
        private System.Windows.Forms.ToolStripMenuItem összeadástsmi;
        private System.Windows.Forms.ToolStripMenuItem szorzástsmi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDbszam;
        private System.Windows.Forms.ToolStripStatusLabel tsslLegkisebb;
        private System.Windows.Forms.ToolStripStatusLabel tsslLegnagyobb;
        private System.Windows.Forms.Label lblEredm;
    }
}


namespace _3szammuveletek
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
            this.components = new System.ComponentModel.Container();
            this.nudSzam1 = new System.Windows.Forms.NumericUpDown();
            this.nudSzam2 = new System.Windows.Forms.NumericUpDown();
            this.nudSzam3 = new System.Windows.Forms.NumericUpDown();
            this.lbEredm = new System.Windows.Forms.ListBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.számtanitsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mértanitsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonikustsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.legnagyobbtsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.törléstsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépéstsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSzamtani = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMertani = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHarmonikus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLegnagyobb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKilepes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam3)).BeginInit();
            this.msMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSzam1
            // 
            this.nudSzam1.Location = new System.Drawing.Point(13, 33);
            this.nudSzam1.Name = "nudSzam1";
            this.nudSzam1.Size = new System.Drawing.Size(120, 20);
            this.nudSzam1.TabIndex = 0;
            // 
            // nudSzam2
            // 
            this.nudSzam2.Location = new System.Drawing.Point(139, 33);
            this.nudSzam2.Name = "nudSzam2";
            this.nudSzam2.Size = new System.Drawing.Size(120, 20);
            this.nudSzam2.TabIndex = 0;
            // 
            // nudSzam3
            // 
            this.nudSzam3.Location = new System.Drawing.Point(265, 33);
            this.nudSzam3.Name = "nudSzam3";
            this.nudSzam3.Size = new System.Drawing.Size(120, 20);
            this.nudSzam3.TabIndex = 0;
            // 
            // lbEredm
            // 
            this.lbEredm.ContextMenuStrip = this.contextMenuStrip1;
            this.lbEredm.FormattingEnabled = true;
            this.lbEredm.Location = new System.Drawing.Point(13, 68);
            this.lbEredm.Name = "lbEredm";
            this.lbEredm.Size = new System.Drawing.Size(186, 121);
            this.lbEredm.TabIndex = 1;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.számtanitsmi,
            this.mértanitsmi,
            this.harmonikustsmi,
            this.legnagyobbtsmi,
            this.törléstsmi,
            this.kilépéstsmi});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // számtanitsmi
            // 
            this.számtanitsmi.Image = global::_3szammuveletek.Properties.Resources.calculating;
            this.számtanitsmi.Name = "számtanitsmi";
            this.számtanitsmi.Size = new System.Drawing.Size(112, 20);
            this.számtanitsmi.Text = "Számtani átlag";
            this.számtanitsmi.Click += new System.EventHandler(this.SzamtaniK);
            // 
            // mértanitsmi
            // 
            this.mértanitsmi.Image = global::_3szammuveletek.Properties.Resources.calculator;
            this.mértanitsmi.Name = "mértanitsmi";
            this.mértanitsmi.Size = new System.Drawing.Size(105, 20);
            this.mértanitsmi.Text = "Mértani átlag";
            this.mértanitsmi.Click += new System.EventHandler(this.MertaniK);
            // 
            // harmonikustsmi
            // 
            this.harmonikustsmi.Image = global::_3szammuveletek.Properties.Resources.math;
            this.harmonikustsmi.Name = "harmonikustsmi";
            this.harmonikustsmi.Size = new System.Drawing.Size(129, 20);
            this.harmonikustsmi.Text = "Harmonikus átlag";
            this.harmonikustsmi.Click += new System.EventHandler(this.HarmonikusK);
            // 
            // legnagyobbtsmi
            // 
            this.legnagyobbtsmi.Image = global::_3szammuveletek.Properties.Resources.maths;
            this.legnagyobbtsmi.Name = "legnagyobbtsmi";
            this.legnagyobbtsmi.Size = new System.Drawing.Size(131, 20);
            this.legnagyobbtsmi.Text = "Legnagyobb szám";
            this.legnagyobbtsmi.Click += new System.EventHandler(this.Legnagyobb);
            // 
            // törléstsmi
            // 
            this.törléstsmi.Image = global::_3szammuveletek.Properties.Resources.trash;
            this.törléstsmi.Name = "törléstsmi";
            this.törléstsmi.Size = new System.Drawing.Size(65, 20);
            this.törléstsmi.Text = "Törlés";
            this.törléstsmi.Click += new System.EventHandler(this.Torles);
            // 
            // kilépéstsmi
            // 
            this.kilépéstsmi.Image = global::_3szammuveletek.Properties.Resources.cancel;
            this.kilépéstsmi.Name = "kilépéstsmi";
            this.kilépéstsmi.Size = new System.Drawing.Size(72, 20);
            this.kilépéstsmi.Text = "Kilépés";
            this.kilépéstsmi.Click += new System.EventHandler(this.kilepes);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSzamtani,
            this.tsmMertani,
            this.tsmHarmonikus,
            this.tsmLegnagyobb,
            this.tsmTorles,
            this.tsmKilepes});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 136);
            // 
            // tsmSzamtani
            // 
            this.tsmSzamtani.Image = global::_3szammuveletek.Properties.Resources.calculating;
            this.tsmSzamtani.Name = "tsmSzamtani";
            this.tsmSzamtani.Size = new System.Drawing.Size(170, 22);
            this.tsmSzamtani.Text = "Számtani átlag";
            this.tsmSzamtani.Click += new System.EventHandler(this.SzamtaniK);
            // 
            // tsmMertani
            // 
            this.tsmMertani.Image = global::_3szammuveletek.Properties.Resources.calculator;
            this.tsmMertani.Name = "tsmMertani";
            this.tsmMertani.Size = new System.Drawing.Size(170, 22);
            this.tsmMertani.Text = "Mértani átlag";
            this.tsmMertani.Click += new System.EventHandler(this.MertaniK);
            // 
            // tsmHarmonikus
            // 
            this.tsmHarmonikus.Image = global::_3szammuveletek.Properties.Resources.math;
            this.tsmHarmonikus.Name = "tsmHarmonikus";
            this.tsmHarmonikus.Size = new System.Drawing.Size(170, 22);
            this.tsmHarmonikus.Text = "Harmonikus átlag";
            this.tsmHarmonikus.Click += new System.EventHandler(this.HarmonikusK);
            // 
            // tsmLegnagyobb
            // 
            this.tsmLegnagyobb.Image = global::_3szammuveletek.Properties.Resources.maths;
            this.tsmLegnagyobb.Name = "tsmLegnagyobb";
            this.tsmLegnagyobb.Size = new System.Drawing.Size(170, 22);
            this.tsmLegnagyobb.Text = "Legnagyobb szám";
            this.tsmLegnagyobb.Click += new System.EventHandler(this.Legnagyobb);
            // 
            // tsmTorles
            // 
            this.tsmTorles.Image = global::_3szammuveletek.Properties.Resources.trash;
            this.tsmTorles.Name = "tsmTorles";
            this.tsmTorles.Size = new System.Drawing.Size(170, 22);
            this.tsmTorles.Text = "Törlés";
            this.tsmTorles.Click += new System.EventHandler(this.Torles);
            // 
            // tsmKilepes
            // 
            this.tsmKilepes.Image = global::_3szammuveletek.Properties.Resources.cancel;
            this.tsmKilepes.Name = "tsmKilepes";
            this.tsmKilepes.Size = new System.Drawing.Size(170, 22);
            this.tsmKilepes.Text = "Kilépés";
            this.tsmKilepes.Click += new System.EventHandler(this.kilepes);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEredm);
            this.Controls.Add(this.nudSzam3);
            this.Controls.Add(this.nudSzam2);
            this.Controls.Add(this.nudSzam1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam3)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSzam1;
        private System.Windows.Forms.NumericUpDown nudSzam2;
        private System.Windows.Forms.NumericUpDown nudSzam3;
        private System.Windows.Forms.ListBox lbEredm;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem számtanitsmi;
        private System.Windows.Forms.ToolStripMenuItem mértanitsmi;
        private System.Windows.Forms.ToolStripMenuItem harmonikustsmi;
        private System.Windows.Forms.ToolStripMenuItem legnagyobbtsmi;
        private System.Windows.Forms.ToolStripMenuItem törléstsmi;
        private System.Windows.Forms.ToolStripMenuItem kilépéstsmi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSzamtani;
        private System.Windows.Forms.ToolStripMenuItem tsmMertani;
        private System.Windows.Forms.ToolStripMenuItem tsmHarmonikus;
        private System.Windows.Forms.ToolStripMenuItem tsmLegnagyobb;
        private System.Windows.Forms.ToolStripMenuItem tsmTorles;
        private System.Windows.Forms.ToolStripMenuItem tsmKilepes;
    }
}


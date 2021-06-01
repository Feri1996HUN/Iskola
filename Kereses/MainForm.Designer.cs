namespace Kereses
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumtsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumtsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.átlagszámítástsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.összegtsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.párostsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.számokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Generaltsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.kézzeltsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépéstsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSzamok = new System.Windows.Forms.ListBox();
            this.btnKilep = new System.Windows.Forms.Button();
            this.nudKezzel = new System.Windows.Forms.NumericUpDown();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKezzel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.átlagszámítástsmi,
            this.összegtsmi,
            this.párostsmi,
            this.számokToolStripMenuItem,
            this.kilépéstsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimumtsmi,
            this.maximumtsmi});
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // minimumtsmi
            // 
            this.minimumtsmi.Name = "minimumtsmi";
            this.minimumtsmi.Size = new System.Drawing.Size(180, 22);
            this.minimumtsmi.Text = "Minimum";
            this.minimumtsmi.Click += new System.EventHandler(this.Keres);
            // 
            // maximumtsmi
            // 
            this.maximumtsmi.Name = "maximumtsmi";
            this.maximumtsmi.Size = new System.Drawing.Size(180, 22);
            this.maximumtsmi.Text = "Maximum";
            this.maximumtsmi.Click += new System.EventHandler(this.Keres);
            // 
            // átlagszámítástsmi
            // 
            this.átlagszámítástsmi.Name = "átlagszámítástsmi";
            this.átlagszámítástsmi.Size = new System.Drawing.Size(92, 20);
            this.átlagszámítástsmi.Text = "Átlagszámítás";
            this.átlagszámítástsmi.Click += new System.EventHandler(this.Atlag);
            // 
            // összegtsmi
            // 
            this.összegtsmi.Name = "összegtsmi";
            this.összegtsmi.Size = new System.Drawing.Size(56, 20);
            this.összegtsmi.Text = "Összeg";
            this.összegtsmi.Click += new System.EventHandler(this.Osszeg);
            // 
            // párostsmi
            // 
            this.párostsmi.Name = "párostsmi";
            this.párostsmi.Size = new System.Drawing.Size(135, 20);
            this.párostsmi.Text = "Páros számok összege";
            this.párostsmi.Click += new System.EventHandler(this.Paros);
            // 
            // számokToolStripMenuItem
            // 
            this.számokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Generaltsmi,
            this.kézzeltsmi});
            this.számokToolStripMenuItem.Name = "számokToolStripMenuItem";
            this.számokToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.számokToolStripMenuItem.Text = "Számok";
            // 
            // Generaltsmi
            // 
            this.Generaltsmi.Name = "Generaltsmi";
            this.Generaltsmi.Size = new System.Drawing.Size(180, 22);
            this.Generaltsmi.Text = "Program generálja";
            this.Generaltsmi.Click += new System.EventHandler(this.General);
            // 
            // kézzeltsmi
            // 
            this.kézzeltsmi.Name = "kézzeltsmi";
            this.kézzeltsmi.Size = new System.Drawing.Size(180, 22);
            this.kézzeltsmi.Text = "Kézzel írom be";
            this.kézzeltsmi.Click += new System.EventHandler(this.Kezzel);
            // 
            // kilépéstsmi
            // 
            this.kilépéstsmi.Name = "kilépéstsmi";
            this.kilépéstsmi.Size = new System.Drawing.Size(56, 20);
            this.kilépéstsmi.Text = "Kilépés";
            this.kilépéstsmi.Click += new System.EventHandler(this.Kilep);
            // 
            // lbSzamok
            // 
            this.lbSzamok.FormattingEnabled = true;
            this.lbSzamok.Location = new System.Drawing.Point(13, 44);
            this.lbSzamok.Name = "lbSzamok";
            this.lbSzamok.Size = new System.Drawing.Size(120, 251);
            this.lbSzamok.TabIndex = 1;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(34, 310);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 2;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.Kilep);
            // 
            // nudKezzel
            // 
            this.nudKezzel.Location = new System.Drawing.Point(152, 44);
            this.nudKezzel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudKezzel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKezzel.Name = "nudKezzel";
            this.nudKezzel.Size = new System.Drawing.Size(120, 20);
            this.nudKezzel.TabIndex = 3;
            this.nudKezzel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(173, 70);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 4;
            this.btnHozzaad.Text = "Hozzáadom";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.nudKezzel);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.lbSzamok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Keresés";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKezzel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumtsmi;
        private System.Windows.Forms.ToolStripMenuItem maximumtsmi;
        private System.Windows.Forms.ToolStripMenuItem átlagszámítástsmi;
        private System.Windows.Forms.ToolStripMenuItem összegtsmi;
        private System.Windows.Forms.ToolStripMenuItem párostsmi;
        private System.Windows.Forms.ToolStripMenuItem számokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Generaltsmi;
        private System.Windows.Forms.ToolStripMenuItem kézzeltsmi;
        private System.Windows.Forms.ToolStripMenuItem kilépéstsmi;
        private System.Windows.Forms.ListBox lbSzamok;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.NumericUpDown nudKezzel;
        private System.Windows.Forms.Button btnHozzaad;
    }
}


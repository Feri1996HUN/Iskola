namespace matrixfelmenu
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
            this.dgvSzamok = new System.Windows.Forms.DataGridView();
            this.dgvEredm = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transzponálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páratlanSzámokÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.főátlóÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transzponálásToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.páratlanSzámokÖsszegeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.főátlóÖsszegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMegoldas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzamok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSzamok
            // 
            this.dgvSzamok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzamok.ColumnHeadersVisible = false;
            this.dgvSzamok.Location = new System.Drawing.Point(12, 93);
            this.dgvSzamok.Name = "dgvSzamok";
            this.dgvSzamok.RowHeadersVisible = false;
            this.dgvSzamok.Size = new System.Drawing.Size(240, 150);
            this.dgvSzamok.TabIndex = 0;
            // 
            // dgvEredm
            // 
            this.dgvEredm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEredm.ColumnHeadersVisible = false;
            this.dgvEredm.Location = new System.Drawing.Point(297, 93);
            this.dgvEredm.Name = "dgvEredm";
            this.dgvEredm.RowHeadersVisible = false;
            this.dgvEredm.Size = new System.Drawing.Size(240, 150);
            this.dgvEredm.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transzponálásToolStripMenuItem,
            this.páratlanSzámokÖsszegeToolStripMenuItem,
            this.főátlóÖsszegeToolStripMenuItem,
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem,
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transzponálásToolStripMenuItem
            // 
            this.transzponálásToolStripMenuItem.Name = "transzponálásToolStripMenuItem";
            this.transzponálásToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transzponálásToolStripMenuItem.Text = "Transzponálás";
            this.transzponálásToolStripMenuItem.Click += new System.EventHandler(this.Transzponalas);
            // 
            // páratlanSzámokÖsszegeToolStripMenuItem
            // 
            this.páratlanSzámokÖsszegeToolStripMenuItem.Name = "páratlanSzámokÖsszegeToolStripMenuItem";
            this.páratlanSzámokÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.páratlanSzámokÖsszegeToolStripMenuItem.Text = "Páratlan számok összege";
            this.páratlanSzámokÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.Paratlan);
            // 
            // főátlóÖsszegeToolStripMenuItem
            // 
            this.főátlóÖsszegeToolStripMenuItem.Name = "főátlóÖsszegeToolStripMenuItem";
            this.főátlóÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.főátlóÖsszegeToolStripMenuItem.Text = "Főátló összege";
            this.főátlóÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.Foatlo);
            // 
            // sorokbanLévőÉrtékekÖsszegeToolStripMenuItem
            // 
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem.Name = "sorokbanLévőÉrtékekÖsszegeToolStripMenuItem";
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem.Text = "Sorokban lévő értékek összege";
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.SorokOsszeg);
            // 
            // oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem
            // 
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem.Name = "oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem";
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(198, 20);
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem.Text = "Oszlopokban lévő értékek összege";
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.OszlopokOsszeg);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transzponálásToolStripMenuItem1,
            this.páratlanSzámokÖsszegeToolStripMenuItem2,
            this.főátlóÖsszegeToolStripMenuItem1,
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1,
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 114);
            // 
            // transzponálásToolStripMenuItem1
            // 
            this.transzponálásToolStripMenuItem1.Name = "transzponálásToolStripMenuItem1";
            this.transzponálásToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.transzponálásToolStripMenuItem1.Text = "Transzponálás";
            // 
            // páratlanSzámokÖsszegeToolStripMenuItem2
            // 
            this.páratlanSzámokÖsszegeToolStripMenuItem2.Name = "páratlanSzámokÖsszegeToolStripMenuItem2";
            this.páratlanSzámokÖsszegeToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.páratlanSzámokÖsszegeToolStripMenuItem2.Text = "Páratlan számok összege";
            // 
            // főátlóÖsszegeToolStripMenuItem1
            // 
            this.főátlóÖsszegeToolStripMenuItem1.Name = "főátlóÖsszegeToolStripMenuItem1";
            this.főátlóÖsszegeToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.főátlóÖsszegeToolStripMenuItem1.Text = "Főátló összege";
            // 
            // sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1
            // 
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Name = "sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1";
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Text = "Sorokban lévő értékek összege";
            // 
            // oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1
            // 
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Name = "oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1";
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1.Text = "Oszlopokban lévő értékek összege";
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.Location = new System.Drawing.Point(199, 262);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(138, 110);
            this.lblMegoldas.TabIndex = 3;
            this.lblMegoldas.Text = "Megoldás";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMegoldas);
            this.Controls.Add(this.dgvEredm);
            this.Controls.Add(this.dgvSzamok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzamok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzamok;
        private System.Windows.Forms.DataGridView dgvEredm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transzponálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páratlanSzámokÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem főátlóÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorokbanLévőÉrtékekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transzponálásToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem páratlanSzámokÖsszegeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem főátlóÖsszegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sorokbanLévőÉrtékekÖsszegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oszlopokbanLévőÉrtékekÖsszegeToolStripMenuItem1;
        private System.Windows.Forms.Label lblMegoldas;
    }
}


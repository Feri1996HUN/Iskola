namespace RichtextModosit
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
            this.betöltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.háttérszínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karakterSzínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSzoveg = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betöltToolStripMenuItem,
            this.háttérszínToolStripMenuItem,
            this.karakterSzínToolStripMenuItem,
            this.mentésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // betöltToolStripMenuItem
            // 
            this.betöltToolStripMenuItem.Name = "betöltToolStripMenuItem";
            this.betöltToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.betöltToolStripMenuItem.Text = "Betöltés";
            this.betöltToolStripMenuItem.Click += new System.EventHandler(this.Megnyit);
            // 
            // háttérszínToolStripMenuItem
            // 
            this.háttérszínToolStripMenuItem.Name = "háttérszínToolStripMenuItem";
            this.háttérszínToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.háttérszínToolStripMenuItem.Text = "Háttérszín";
            this.háttérszínToolStripMenuItem.Click += new System.EventHandler(this.Hatterszin);
            // 
            // karakterSzínToolStripMenuItem
            // 
            this.karakterSzínToolStripMenuItem.Name = "karakterSzínToolStripMenuItem";
            this.karakterSzínToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.karakterSzínToolStripMenuItem.Text = "Font";
            this.karakterSzínToolStripMenuItem.Click += new System.EventHandler(this.Fontos);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.Mentes);
            // 
            // rtbSzoveg
            // 
            this.rtbSzoveg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSzoveg.Location = new System.Drawing.Point(0, 24);
            this.rtbSzoveg.Name = "rtbSzoveg";
            this.rtbSzoveg.Size = new System.Drawing.Size(800, 426);
            this.rtbSzoveg.TabIndex = 1;
            this.rtbSzoveg.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSzoveg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Richtext";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem betöltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem háttérszínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karakterSzínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbSzoveg;
    }
}


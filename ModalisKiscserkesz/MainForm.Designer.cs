namespace ModalisKiscserkesz
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
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.lbxAdatok = new System.Windows.Forms.ListBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHozzaad.Location = new System.Drawing.Point(0, 0);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(255, 22);
            this.btnHozzaad.TabIndex = 0;
            this.btnHozzaad.Text = "Adat hozzáadása";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // lbxAdatok
            // 
            this.lbxAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAdatok.FormattingEnabled = true;
            this.lbxAdatok.Location = new System.Drawing.Point(0, 0);
            this.lbxAdatok.Name = "lbxAdatok";
            this.lbxAdatok.Size = new System.Drawing.Size(255, 240);
            this.lbxAdatok.TabIndex = 1;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(176, 4);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(76, 36);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Fájlba mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(3, 3);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(75, 37);
            this.btnBeolvas.TabIndex = 3;
            this.btnBeolvas.Text = "Beolvasás fájlból";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHozzaad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 22);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBeolvas);
            this.panel2.Controls.Add(this.btnMentes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 43);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbxAdatok);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 240);
            this.panel3.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 305);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Kiscserkész";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.ListBox lbxAdatok;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}


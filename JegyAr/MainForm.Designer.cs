namespace JegyAr
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
            this.cbxTorzsutas = new System.Windows.Forms.CheckBox();
            this.cbxKutya = new System.Windows.Forms.CheckBox();
            this.cbxBicikli = new System.Windows.Forms.CheckBox();
            this.cbxPoggyasz = new System.Windows.Forms.CheckBox();
            this.rbDiak = new System.Windows.Forms.RadioButton();
            this.rbNyugdij = new System.Windows.Forms.RadioButton();
            this.cbxAllomas = new System.Windows.Forms.ComboBox();
            this.gbxKedvez = new System.Windows.Forms.GroupBox();
            this.gpxPotdij = new System.Windows.Forms.GroupBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.lblEredm = new System.Windows.Forms.Label();
            this.gbxKedvez.SuspendLayout();
            this.gpxPotdij.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTorzsutas
            // 
            this.cbxTorzsutas.AutoSize = true;
            this.cbxTorzsutas.Location = new System.Drawing.Point(6, 66);
            this.cbxTorzsutas.Name = "cbxTorzsutas";
            this.cbxTorzsutas.Size = new System.Drawing.Size(72, 17);
            this.cbxTorzsutas.TabIndex = 0;
            this.cbxTorzsutas.Text = "Törzsutas";
            this.cbxTorzsutas.UseVisualStyleBackColor = true;
            this.cbxTorzsutas.CheckedChanged += new System.EventHandler(this.cbxTorzsutas_CheckedChanged);
            // 
            // cbxKutya
            // 
            this.cbxKutya.AutoSize = true;
            this.cbxKutya.Location = new System.Drawing.Point(6, 20);
            this.cbxKutya.Name = "cbxKutya";
            this.cbxKutya.Size = new System.Drawing.Size(53, 17);
            this.cbxKutya.TabIndex = 1;
            this.cbxKutya.Text = "Kutya";
            this.cbxKutya.UseVisualStyleBackColor = true;
            this.cbxKutya.CheckedChanged += new System.EventHandler(this.cbxKutya_CheckedChanged);
            // 
            // cbxBicikli
            // 
            this.cbxBicikli.AutoSize = true;
            this.cbxBicikli.Location = new System.Drawing.Point(6, 43);
            this.cbxBicikli.Name = "cbxBicikli";
            this.cbxBicikli.Size = new System.Drawing.Size(53, 17);
            this.cbxBicikli.TabIndex = 2;
            this.cbxBicikli.Text = "Bicikli";
            this.cbxBicikli.UseVisualStyleBackColor = true;
            this.cbxBicikli.CheckedChanged += new System.EventHandler(this.cbxBicikli_CheckedChanged);
            // 
            // cbxPoggyasz
            // 
            this.cbxPoggyasz.AutoSize = true;
            this.cbxPoggyasz.Location = new System.Drawing.Point(6, 66);
            this.cbxPoggyasz.Name = "cbxPoggyasz";
            this.cbxPoggyasz.Size = new System.Drawing.Size(99, 17);
            this.cbxPoggyasz.TabIndex = 3;
            this.cbxPoggyasz.Text = "Nagy poggyász";
            this.cbxPoggyasz.UseVisualStyleBackColor = true;
            this.cbxPoggyasz.CheckedChanged += new System.EventHandler(this.cbxPoggyasz_CheckedChanged);
            // 
            // rbDiak
            // 
            this.rbDiak.AutoSize = true;
            this.rbDiak.Location = new System.Drawing.Point(6, 20);
            this.rbDiak.Name = "rbDiak";
            this.rbDiak.Size = new System.Drawing.Size(70, 17);
            this.rbDiak.TabIndex = 4;
            this.rbDiak.TabStop = true;
            this.rbDiak.Text = "Diák 50%";
            this.rbDiak.UseVisualStyleBackColor = true;
            this.rbDiak.CheckedChanged += new System.EventHandler(this.rbDiak_CheckedChanged);
            // 
            // rbNyugdij
            // 
            this.rbNyugdij.AutoSize = true;
            this.rbNyugdij.Location = new System.Drawing.Point(6, 42);
            this.rbNyugdij.Name = "rbNyugdij";
            this.rbNyugdij.Size = new System.Drawing.Size(96, 17);
            this.rbNyugdij.TabIndex = 5;
            this.rbNyugdij.TabStop = true;
            this.rbNyugdij.Text = "Nyugdíjas 50%";
            this.rbNyugdij.UseVisualStyleBackColor = true;
            this.rbNyugdij.CheckedChanged += new System.EventHandler(this.rbNyugdij_CheckedChanged);
            // 
            // cbxAllomas
            // 
            this.cbxAllomas.FormattingEnabled = true;
            this.cbxAllomas.Location = new System.Drawing.Point(12, 26);
            this.cbxAllomas.Name = "cbxAllomas";
            this.cbxAllomas.Size = new System.Drawing.Size(121, 21);
            this.cbxAllomas.TabIndex = 6;
            this.cbxAllomas.SelectedIndexChanged += new System.EventHandler(this.cbxAllomas_SelectedIndexChanged);
            // 
            // gbxKedvez
            // 
            this.gbxKedvez.Controls.Add(this.cbxTorzsutas);
            this.gbxKedvez.Controls.Add(this.rbDiak);
            this.gbxKedvez.Controls.Add(this.rbNyugdij);
            this.gbxKedvez.Location = new System.Drawing.Point(12, 79);
            this.gbxKedvez.Name = "gbxKedvez";
            this.gbxKedvez.Size = new System.Drawing.Size(109, 100);
            this.gbxKedvez.TabIndex = 11;
            this.gbxKedvez.TabStop = false;
            this.gbxKedvez.Text = "Kedvezmények";
            // 
            // gpxPotdij
            // 
            this.gpxPotdij.Controls.Add(this.cbxBicikli);
            this.gpxPotdij.Controls.Add(this.cbxKutya);
            this.gpxPotdij.Controls.Add(this.cbxPoggyasz);
            this.gpxPotdij.Location = new System.Drawing.Point(151, 79);
            this.gpxPotdij.Name = "gpxPotdij";
            this.gpxPotdij.Size = new System.Drawing.Size(114, 100);
            this.gpxPotdij.TabIndex = 12;
            this.gpxPotdij.TabStop = false;
            this.gpxPotdij.Text = "Pót Díjak";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(18, 199);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 13;
            this.btnSzamol.Text = "Új számítás";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(18, 247);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(52, 13);
            this.lblEredm.TabIndex = 14;
            this.lblEredm.Text = "Fuvardíj: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.gpxPotdij);
            this.Controls.Add(this.gbxKedvez);
            this.Controls.Add(this.cbxAllomas);
            this.Name = "MainForm";
            this.Text = "Jegy Ár";
            this.gbxKedvez.ResumeLayout(false);
            this.gbxKedvez.PerformLayout();
            this.gpxPotdij.ResumeLayout(false);
            this.gpxPotdij.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxTorzsutas;
        private System.Windows.Forms.CheckBox cbxKutya;
        private System.Windows.Forms.CheckBox cbxBicikli;
        private System.Windows.Forms.CheckBox cbxPoggyasz;
        private System.Windows.Forms.RadioButton rbDiak;
        private System.Windows.Forms.RadioButton rbNyugdij;
        private System.Windows.Forms.ComboBox cbxAllomas;
        private System.Windows.Forms.GroupBox gbxKedvez;
        private System.Windows.Forms.GroupBox gpxPotdij;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label lblEredm;
    }
}


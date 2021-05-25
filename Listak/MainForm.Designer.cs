namespace Listak
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
            this.txbBal = new System.Windows.Forms.TextBox();
            this.lsbBal = new System.Windows.Forms.ListBox();
            this.btnBalAd = new System.Windows.Forms.Button();
            this.btnBalFelulre = new System.Windows.Forms.Button();
            this.btnBalFel = new System.Windows.Forms.Button();
            this.btnBalLe = new System.Windows.Forms.Button();
            this.btnBalAlulra = new System.Windows.Forms.Button();
            this.btnBalTorol = new System.Windows.Forms.Button();
            this.btnJobbra = new System.Windows.Forms.Button();
            this.btnBalra = new System.Windows.Forms.Button();
            this.txbJobb = new System.Windows.Forms.TextBox();
            this.lsbJobb = new System.Windows.Forms.ListBox();
            this.btnJobbAd = new System.Windows.Forms.Button();
            this.btnJobbFelulre = new System.Windows.Forms.Button();
            this.btnJobbFel = new System.Windows.Forms.Button();
            this.btnJobbLe = new System.Windows.Forms.Button();
            this.btnJobbAlulra = new System.Windows.Forms.Button();
            this.btnJobbTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbBal
            // 
            this.txbBal.Location = new System.Drawing.Point(13, 13);
            this.txbBal.Name = "txbBal";
            this.txbBal.Size = new System.Drawing.Size(148, 20);
            this.txbBal.TabIndex = 0;
            // 
            // lsbBal
            // 
            this.lsbBal.FormattingEnabled = true;
            this.lsbBal.Location = new System.Drawing.Point(13, 51);
            this.lsbBal.Name = "lsbBal";
            this.lsbBal.Size = new System.Drawing.Size(148, 368);
            this.lsbBal.TabIndex = 1;
            // 
            // btnBalAd
            // 
            this.btnBalAd.Location = new System.Drawing.Point(181, 10);
            this.btnBalAd.Name = "btnBalAd";
            this.btnBalAd.Size = new System.Drawing.Size(75, 23);
            this.btnBalAd.TabIndex = 2;
            this.btnBalAd.Text = "Hozzáad";
            this.btnBalAd.UseVisualStyleBackColor = true;
            this.btnBalAd.Click += new System.EventHandler(this.Hozzaad);
            // 
            // btnBalFelulre
            // 
            this.btnBalFelulre.Location = new System.Drawing.Point(181, 170);
            this.btnBalFelulre.Name = "btnBalFelulre";
            this.btnBalFelulre.Size = new System.Drawing.Size(75, 23);
            this.btnBalFelulre.TabIndex = 3;
            this.btnBalFelulre.Text = "Felülre";
            this.btnBalFelulre.UseVisualStyleBackColor = true;
            this.btnBalFelulre.Click += new System.EventHandler(this.Felulre);
            // 
            // btnBalFel
            // 
            this.btnBalFel.Location = new System.Drawing.Point(181, 199);
            this.btnBalFel.Name = "btnBalFel";
            this.btnBalFel.Size = new System.Drawing.Size(75, 23);
            this.btnBalFel.TabIndex = 4;
            this.btnBalFel.Text = "Fel";
            this.btnBalFel.UseVisualStyleBackColor = true;
            this.btnBalFel.Click += new System.EventHandler(this.Fel);
            // 
            // btnBalLe
            // 
            this.btnBalLe.Location = new System.Drawing.Point(181, 228);
            this.btnBalLe.Name = "btnBalLe";
            this.btnBalLe.Size = new System.Drawing.Size(75, 23);
            this.btnBalLe.TabIndex = 5;
            this.btnBalLe.Text = "Le";
            this.btnBalLe.UseVisualStyleBackColor = true;
            this.btnBalLe.Click += new System.EventHandler(this.Le);
            // 
            // btnBalAlulra
            // 
            this.btnBalAlulra.Location = new System.Drawing.Point(181, 257);
            this.btnBalAlulra.Name = "btnBalAlulra";
            this.btnBalAlulra.Size = new System.Drawing.Size(75, 23);
            this.btnBalAlulra.TabIndex = 6;
            this.btnBalAlulra.Text = "Alulra";
            this.btnBalAlulra.UseVisualStyleBackColor = true;
            this.btnBalAlulra.Click += new System.EventHandler(this.Alulra);
            // 
            // btnBalTorol
            // 
            this.btnBalTorol.Location = new System.Drawing.Point(181, 395);
            this.btnBalTorol.Name = "btnBalTorol";
            this.btnBalTorol.Size = new System.Drawing.Size(75, 23);
            this.btnBalTorol.TabIndex = 7;
            this.btnBalTorol.Text = "Töröl";
            this.btnBalTorol.UseVisualStyleBackColor = true;
            this.btnBalTorol.Click += new System.EventHandler(this.Torol);
            // 
            // btnJobbra
            // 
            this.btnJobbra.Location = new System.Drawing.Point(282, 170);
            this.btnJobbra.Name = "btnJobbra";
            this.btnJobbra.Size = new System.Drawing.Size(75, 23);
            this.btnJobbra.TabIndex = 8;
            this.btnJobbra.Text = "Jobbra";
            this.btnJobbra.UseVisualStyleBackColor = true;
            this.btnJobbra.Click += new System.EventHandler(this.Jobbra);
            // 
            // btnBalra
            // 
            this.btnBalra.Location = new System.Drawing.Point(282, 199);
            this.btnBalra.Name = "btnBalra";
            this.btnBalra.Size = new System.Drawing.Size(75, 23);
            this.btnBalra.TabIndex = 9;
            this.btnBalra.Text = "Balra";
            this.btnBalra.UseVisualStyleBackColor = true;
            this.btnBalra.Click += new System.EventHandler(this.Jobbra);
            // 
            // txbJobb
            // 
            this.txbJobb.Location = new System.Drawing.Point(375, 13);
            this.txbJobb.Name = "txbJobb";
            this.txbJobb.Size = new System.Drawing.Size(148, 20);
            this.txbJobb.TabIndex = 0;
            // 
            // lsbJobb
            // 
            this.lsbJobb.FormattingEnabled = true;
            this.lsbJobb.Location = new System.Drawing.Point(375, 51);
            this.lsbJobb.Name = "lsbJobb";
            this.lsbJobb.Size = new System.Drawing.Size(148, 368);
            this.lsbJobb.TabIndex = 1;
            // 
            // btnJobbAd
            // 
            this.btnJobbAd.Location = new System.Drawing.Point(543, 10);
            this.btnJobbAd.Name = "btnJobbAd";
            this.btnJobbAd.Size = new System.Drawing.Size(75, 23);
            this.btnJobbAd.TabIndex = 2;
            this.btnJobbAd.Text = "Hozzáad";
            this.btnJobbAd.UseVisualStyleBackColor = true;
            this.btnJobbAd.Click += new System.EventHandler(this.Hozzaad);
            // 
            // btnJobbFelulre
            // 
            this.btnJobbFelulre.Location = new System.Drawing.Point(543, 170);
            this.btnJobbFelulre.Name = "btnJobbFelulre";
            this.btnJobbFelulre.Size = new System.Drawing.Size(75, 23);
            this.btnJobbFelulre.TabIndex = 3;
            this.btnJobbFelulre.Text = "Felülre";
            this.btnJobbFelulre.UseVisualStyleBackColor = true;
            this.btnJobbFelulre.Click += new System.EventHandler(this.Felulre);
            // 
            // btnJobbFel
            // 
            this.btnJobbFel.Location = new System.Drawing.Point(543, 199);
            this.btnJobbFel.Name = "btnJobbFel";
            this.btnJobbFel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbFel.TabIndex = 4;
            this.btnJobbFel.Text = "Fel";
            this.btnJobbFel.UseVisualStyleBackColor = true;
            this.btnJobbFel.Click += new System.EventHandler(this.Fel);
            // 
            // btnJobbLe
            // 
            this.btnJobbLe.Location = new System.Drawing.Point(543, 228);
            this.btnJobbLe.Name = "btnJobbLe";
            this.btnJobbLe.Size = new System.Drawing.Size(75, 23);
            this.btnJobbLe.TabIndex = 5;
            this.btnJobbLe.Text = "Le";
            this.btnJobbLe.UseVisualStyleBackColor = true;
            this.btnJobbLe.Click += new System.EventHandler(this.Le);
            // 
            // btnJobbAlulra
            // 
            this.btnJobbAlulra.Location = new System.Drawing.Point(543, 257);
            this.btnJobbAlulra.Name = "btnJobbAlulra";
            this.btnJobbAlulra.Size = new System.Drawing.Size(75, 23);
            this.btnJobbAlulra.TabIndex = 6;
            this.btnJobbAlulra.Text = "Alulra";
            this.btnJobbAlulra.UseVisualStyleBackColor = true;
            this.btnJobbAlulra.Click += new System.EventHandler(this.Alulra);
            // 
            // btnJobbTorol
            // 
            this.btnJobbTorol.Location = new System.Drawing.Point(543, 395);
            this.btnJobbTorol.Name = "btnJobbTorol";
            this.btnJobbTorol.Size = new System.Drawing.Size(75, 23);
            this.btnJobbTorol.TabIndex = 7;
            this.btnJobbTorol.Text = "Töröl";
            this.btnJobbTorol.UseVisualStyleBackColor = true;
            this.btnJobbTorol.Click += new System.EventHandler(this.Torol);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBalra);
            this.Controls.Add(this.btnJobbra);
            this.Controls.Add(this.btnJobbTorol);
            this.Controls.Add(this.btnBalTorol);
            this.Controls.Add(this.btnJobbAlulra);
            this.Controls.Add(this.btnBalAlulra);
            this.Controls.Add(this.btnJobbLe);
            this.Controls.Add(this.btnBalLe);
            this.Controls.Add(this.btnJobbFel);
            this.Controls.Add(this.btnBalFel);
            this.Controls.Add(this.btnJobbFelulre);
            this.Controls.Add(this.btnBalFelulre);
            this.Controls.Add(this.btnJobbAd);
            this.Controls.Add(this.btnBalAd);
            this.Controls.Add(this.lsbJobb);
            this.Controls.Add(this.txbJobb);
            this.Controls.Add(this.lsbBal);
            this.Controls.Add(this.txbBal);
            this.Name = "MainForm";
            this.Text = "Listák kezelése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBal;
        private System.Windows.Forms.ListBox lsbBal;
        private System.Windows.Forms.Button btnBalAd;
        private System.Windows.Forms.Button btnBalFelulre;
        private System.Windows.Forms.Button btnBalFel;
        private System.Windows.Forms.Button btnBalLe;
        private System.Windows.Forms.Button btnBalAlulra;
        private System.Windows.Forms.Button btnBalTorol;
        private System.Windows.Forms.Button btnJobbra;
        private System.Windows.Forms.Button btnBalra;
        private System.Windows.Forms.TextBox txbJobb;
        private System.Windows.Forms.ListBox lsbJobb;
        private System.Windows.Forms.Button btnJobbAd;
        private System.Windows.Forms.Button btnJobbFelulre;
        private System.Windows.Forms.Button btnJobbFel;
        private System.Windows.Forms.Button btnJobbLe;
        private System.Windows.Forms.Button btnJobbAlulra;
        private System.Windows.Forms.Button btnJobbTorol;
    }
}


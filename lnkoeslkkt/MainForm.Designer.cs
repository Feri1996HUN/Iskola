namespace lnkoeslkkt
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
            this.nudSzam1 = new System.Windows.Forms.NumericUpDown();
            this.nudSzam2 = new System.Windows.Forms.NumericUpDown();
            this.rbLNKO = new System.Windows.Forms.RadioButton();
            this.rbLKKT = new System.Windows.Forms.RadioButton();
            this.btnKilep = new System.Windows.Forms.Button();
            this.lblMegoldas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSzam1
            // 
            this.nudSzam1.Location = new System.Drawing.Point(26, 35);
            this.nudSzam1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSzam1.Name = "nudSzam1";
            this.nudSzam1.Size = new System.Drawing.Size(120, 20);
            this.nudSzam1.TabIndex = 0;
            // 
            // nudSzam2
            // 
            this.nudSzam2.Location = new System.Drawing.Point(177, 35);
            this.nudSzam2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSzam2.Name = "nudSzam2";
            this.nudSzam2.Size = new System.Drawing.Size(120, 20);
            this.nudSzam2.TabIndex = 0;
            // 
            // rbLNKO
            // 
            this.rbLNKO.AutoSize = true;
            this.rbLNKO.Location = new System.Drawing.Point(26, 95);
            this.rbLNKO.Name = "rbLNKO";
            this.rbLNKO.Size = new System.Drawing.Size(114, 17);
            this.rbLNKO.TabIndex = 1;
            this.rbLNKO.TabStop = true;
            this.rbLNKO.Text = "LNKO kiszámolása";
            this.rbLNKO.UseVisualStyleBackColor = true;
            this.rbLNKO.Click += new System.EventHandler(this.rbLNKO_Click);
            // 
            // rbLKKT
            // 
            this.rbLKKT.AutoSize = true;
            this.rbLKKT.Location = new System.Drawing.Point(26, 141);
            this.rbLKKT.Name = "rbLKKT";
            this.rbLKKT.Size = new System.Drawing.Size(112, 17);
            this.rbLKKT.TabIndex = 2;
            this.rbLKKT.TabStop = true;
            this.rbLKKT.Text = "LKKT kiszámolása";
            this.rbLKKT.UseVisualStyleBackColor = true;
            this.rbLKKT.Click += new System.EventHandler(this.rbLKKT_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(26, 194);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 3;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.AutoSize = true;
            this.lblMegoldas.Location = new System.Drawing.Point(326, 37);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(59, 13);
            this.lblMegoldas.TabIndex = 4;
            this.lblMegoldas.Text = "Megoldas: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMegoldas);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.rbLKKT);
            this.Controls.Add(this.rbLNKO);
            this.Controls.Add(this.nudSzam2);
            this.Controls.Add(this.nudSzam1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSzam1;
        private System.Windows.Forms.NumericUpDown nudSzam2;
        private System.Windows.Forms.RadioButton rbLNKO;
        private System.Windows.Forms.RadioButton rbLKKT;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Label lblMegoldas;
    }
}


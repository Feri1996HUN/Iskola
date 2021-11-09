
namespace SzeptHazi1
{
    partial class Form1
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
            this.nudszam1 = new System.Windows.Forms.NumericUpDown();
            this.nudszam2 = new System.Windows.Forms.NumericUpDown();
            this.lblMegoldas = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudszam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudszam2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudszam1
            // 
            this.nudszam1.Location = new System.Drawing.Point(12, 41);
            this.nudszam1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudszam1.Name = "nudszam1";
            this.nudszam1.Size = new System.Drawing.Size(120, 20);
            this.nudszam1.TabIndex = 0;
            // 
            // nudszam2
            // 
            this.nudszam2.Location = new System.Drawing.Point(12, 80);
            this.nudszam2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudszam2.Name = "nudszam2";
            this.nudszam2.Size = new System.Drawing.Size(120, 20);
            this.nudszam2.TabIndex = 0;
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.AutoSize = true;
            this.lblMegoldas.Location = new System.Drawing.Point(24, 170);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(53, 13);
            this.lblMegoldas.TabIndex = 1;
            this.lblMegoldas.Text = "Megoldas";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(27, 119);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 2;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 296);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.lblMegoldas);
            this.Controls.Add(this.nudszam2);
            this.Controls.Add(this.nudszam1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudszam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudszam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudszam1;
        private System.Windows.Forms.NumericUpDown nudszam2;
        private System.Windows.Forms.Label lblMegoldas;
        private System.Windows.Forms.Button btnSzamol;
    }
}


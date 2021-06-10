namespace ModalisFormSzambekeres
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
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnSzam2 = new System.Windows.Forms.Button();
            this.lblSzamok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(13, 13);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(164, 59);
            this.btnSzamol.TabIndex = 0;
            this.btnSzamol.Text = "Szám1";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnSzam2
            // 
            this.btnSzam2.Location = new System.Drawing.Point(12, 78);
            this.btnSzam2.Name = "btnSzam2";
            this.btnSzam2.Size = new System.Drawing.Size(164, 59);
            this.btnSzam2.TabIndex = 0;
            this.btnSzam2.Text = "Szám2";
            this.btnSzam2.UseVisualStyleBackColor = true;
            this.btnSzam2.Click += new System.EventHandler(this.btnSzam2_Click);
            // 
            // lblSzamok
            // 
            this.lblSzamok.AutoSize = true;
            this.lblSzamok.Location = new System.Drawing.Point(51, 151);
            this.lblSzamok.Name = "lblSzamok";
            this.lblSzamok.Size = new System.Drawing.Size(0, 13);
            this.lblSzamok.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 295);
            this.Controls.Add(this.lblSzamok);
            this.Controls.Add(this.btnSzam2);
            this.Controls.Add(this.btnSzamol);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnSzam2;
        private System.Windows.Forms.Label lblSzamok;
    }
}


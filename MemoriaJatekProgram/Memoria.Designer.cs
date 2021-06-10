namespace MemoriaJatekProgram
{
    partial class Memoria
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
            this.lblSzamok = new System.Windows.Forms.Label();
            this.lblIdo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSzamok
            // 
            this.lblSzamok.AutoSize = true;
            this.lblSzamok.Location = new System.Drawing.Point(13, 13);
            this.lblSzamok.Name = "lblSzamok";
            this.lblSzamok.Size = new System.Drawing.Size(0, 13);
            this.lblSzamok.TabIndex = 0;
            // 
            // lblIdo
            // 
            this.lblIdo.AutoSize = true;
            this.lblIdo.Location = new System.Drawing.Point(107, 78);
            this.lblIdo.Name = "lblIdo";
            this.lblIdo.Size = new System.Drawing.Size(0, 13);
            this.lblIdo.TabIndex = 1;
            // 
            // Memoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 127);
            this.Controls.Add(this.lblIdo);
            this.Controls.Add(this.lblSzamok);
            this.Name = "Memoria";
            this.Text = "Memoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzamok;
        private System.Windows.Forms.Label lblIdo;
    }
}
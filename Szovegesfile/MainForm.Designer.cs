namespace Szovegesfile
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
            this.tbxSzoveg = new System.Windows.Forms.TextBox();
            this.btnSzoveg = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSzoveg
            // 
            this.tbxSzoveg.AcceptsReturn = true;
            this.tbxSzoveg.Location = new System.Drawing.Point(13, 13);
            this.tbxSzoveg.Multiline = true;
            this.tbxSzoveg.Name = "tbxSzoveg";
            this.tbxSzoveg.Size = new System.Drawing.Size(697, 244);
            this.tbxSzoveg.TabIndex = 0;
            // 
            // btnSzoveg
            // 
            this.btnSzoveg.Location = new System.Drawing.Point(291, 263);
            this.btnSzoveg.Name = "btnSzoveg";
            this.btnSzoveg.Size = new System.Drawing.Size(75, 23);
            this.btnSzoveg.TabIndex = 1;
            this.btnSzoveg.Text = "Szöveg";
            this.btnSzoveg.UseVisualStyleBackColor = true;
            this.btnSzoveg.Click += new System.EventHandler(this.btnSzoveg_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(417, 263);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnSzoveg);
            this.Controls.Add(this.tbxSzoveg);
            this.Name = "MainForm";
            this.Text = "Szöveg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSzoveg;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.TextBox tbxSzoveg;
    }
}


namespace FormHatterSzinez
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
            this.btnKerdes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKerdes
            // 
            this.btnKerdes.Location = new System.Drawing.Point(13, 13);
            this.btnKerdes.Name = "btnKerdes";
            this.btnKerdes.Size = new System.Drawing.Size(75, 23);
            this.btnKerdes.TabIndex = 0;
            this.btnKerdes.Text = "Új kérdés";
            this.btnKerdes.UseVisualStyleBackColor = true;
            this.btnKerdes.Click += new System.EventHandler(this.btnKerdes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(392, 311);
            this.Controls.Add(this.btnKerdes);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKerdes;
    }
}


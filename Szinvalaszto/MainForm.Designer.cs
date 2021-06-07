namespace Szinvalaszto
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
            this.lblSzines = new System.Windows.Forms.Label();
            this.btnSzinez = new System.Windows.Forms.Button();
            this.lblAdatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSzines
            // 
            this.lblSzines.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzines.Location = new System.Drawing.Point(12, 9);
            this.lblSzines.Name = "lblSzines";
            this.lblSzines.Size = new System.Drawing.Size(223, 99);
            this.lblSzines.TabIndex = 0;
            this.lblSzines.Text = "Mintaszöveg";
            this.lblSzines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSzinez
            // 
            this.btnSzinez.Location = new System.Drawing.Point(15, 135);
            this.btnSzinez.Name = "btnSzinez";
            this.btnSzinez.Size = new System.Drawing.Size(75, 23);
            this.btnSzinez.TabIndex = 1;
            this.btnSzinez.Text = "Szín!";
            this.btnSzinez.UseVisualStyleBackColor = true;
            this.btnSzinez.Click += new System.EventHandler(this.btnSzinez_Click);
            // 
            // lblAdatok
            // 
            this.lblAdatok.AutoSize = true;
            this.lblAdatok.Location = new System.Drawing.Point(129, 135);
            this.lblAdatok.Name = "lblAdatok";
            this.lblAdatok.Size = new System.Drawing.Size(35, 13);
            this.lblAdatok.TabIndex = 2;
            this.lblAdatok.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdatok);
            this.Controls.Add(this.btnSzinez);
            this.Controls.Add(this.lblSzines);
            this.Name = "MainForm";
            this.Text = "Színválasztó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSzines;
        private System.Windows.Forms.Button btnSzinez;
        private System.Windows.Forms.Label lblAdatok;
    }
}


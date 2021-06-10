namespace ModalisForm
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
            this.btnParos = new System.Windows.Forms.Button();
            this.btnParatlan = new System.Windows.Forms.Button();
            this.btnMegold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParos
            // 
            this.btnParos.Location = new System.Drawing.Point(12, 12);
            this.btnParos.Name = "btnParos";
            this.btnParos.Size = new System.Drawing.Size(93, 43);
            this.btnParos.TabIndex = 0;
            this.btnParos.Text = "Páros";
            this.btnParos.UseVisualStyleBackColor = true;
            this.btnParos.Click += new System.EventHandler(this.btnParos_Click);
            // 
            // btnParatlan
            // 
            this.btnParatlan.Location = new System.Drawing.Point(111, 12);
            this.btnParatlan.Name = "btnParatlan";
            this.btnParatlan.Size = new System.Drawing.Size(93, 43);
            this.btnParatlan.TabIndex = 0;
            this.btnParatlan.Text = "Páratlan";
            this.btnParatlan.UseVisualStyleBackColor = true;
            this.btnParatlan.Click += new System.EventHandler(this.btnParatlan_Click);
            // 
            // btnMegold
            // 
            this.btnMegold.Location = new System.Drawing.Point(62, 61);
            this.btnMegold.Name = "btnMegold";
            this.btnMegold.Size = new System.Drawing.Size(93, 43);
            this.btnMegold.TabIndex = 0;
            this.btnMegold.Text = "Tipp!";
            this.btnMegold.UseVisualStyleBackColor = true;
            this.btnMegold.Click += new System.EventHandler(this.btnMegold_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 180);
            this.Controls.Add(this.btnMegold);
            this.Controls.Add(this.btnParatlan);
            this.Controls.Add(this.btnParos);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParos;
        private System.Windows.Forms.Button btnParatlan;
        private System.Windows.Forms.Button btnMegold;
    }
}


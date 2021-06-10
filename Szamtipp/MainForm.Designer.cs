namespace Szamtipp
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
            this.btnMegold = new System.Windows.Forms.Button();
            this.btnLegnagy = new System.Windows.Forms.Button();
            this.nudLegnagy = new System.Windows.Forms.NumericUpDown();
            this.nudTipp = new System.Windows.Forms.NumericUpDown();
            this.lblEredm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLegnagy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMegold
            // 
            this.btnMegold.Location = new System.Drawing.Point(136, 71);
            this.btnMegold.Name = "btnMegold";
            this.btnMegold.Size = new System.Drawing.Size(75, 52);
            this.btnMegold.TabIndex = 0;
            this.btnMegold.Text = "Gondoltam egy számra";
            this.btnMegold.UseVisualStyleBackColor = true;
            this.btnMegold.Click += new System.EventHandler(this.btnMegold_Click);
            // 
            // btnLegnagy
            // 
            this.btnLegnagy.Location = new System.Drawing.Point(138, 12);
            this.btnLegnagy.Name = "btnLegnagy";
            this.btnLegnagy.Size = new System.Drawing.Size(75, 53);
            this.btnLegnagy.TabIndex = 1;
            this.btnLegnagy.Text = "Legnagyobb szám max enny lehet";
            this.btnLegnagy.UseVisualStyleBackColor = true;
            this.btnLegnagy.Click += new System.EventHandler(this.btnLegnagy_Click);
            // 
            // nudLegnagy
            // 
            this.nudLegnagy.Location = new System.Drawing.Point(12, 30);
            this.nudLegnagy.Name = "nudLegnagy";
            this.nudLegnagy.Size = new System.Drawing.Size(120, 20);
            this.nudLegnagy.TabIndex = 4;
            // 
            // nudTipp
            // 
            this.nudTipp.Location = new System.Drawing.Point(12, 88);
            this.nudTipp.Name = "nudTipp";
            this.nudTipp.Size = new System.Drawing.Size(120, 20);
            this.nudTipp.TabIndex = 5;
            // 
            // lblEredm
            // 
            this.lblEredm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEredm.Location = new System.Drawing.Point(6, 144);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(207, 77);
            this.lblEredm.TabIndex = 6;
            this.lblEredm.Text = "Eredmény";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 230);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.nudTipp);
            this.Controls.Add(this.nudLegnagy);
            this.Controls.Add(this.btnLegnagy);
            this.Controls.Add(this.btnMegold);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLegnagy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMegold;
        private System.Windows.Forms.Button btnLegnagy;
        private System.Windows.Forms.NumericUpDown nudLegnagy;
        private System.Windows.Forms.NumericUpDown nudTipp;
        private System.Windows.Forms.Label lblEredm;
    }
}


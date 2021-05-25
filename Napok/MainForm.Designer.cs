namespace Napok
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
            this.mcKezd = new System.Windows.Forms.MonthCalendar();
            this.mcZaro = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcKezd
            // 
            this.mcKezd.Location = new System.Drawing.Point(13, 55);
            this.mcKezd.MaxSelectionCount = 1;
            this.mcKezd.Name = "mcKezd";
            this.mcKezd.TabIndex = 0;
            this.mcKezd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Szamol);
            // 
            // mcZaro
            // 
            this.mcZaro.Location = new System.Drawing.Point(258, 55);
            this.mcZaro.MaxSelectionCount = 1;
            this.mcZaro.Name = "mcZaro";
            this.mcZaro.TabIndex = 1;
            this.mcZaro.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Szamol);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kezdő dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Záró dátum";
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(181, 242);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(108, 13);
            this.lblEredm.TabIndex = 4;
            this.lblEredm.Text = "Eredmény napokban:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcZaro);
            this.Controls.Add(this.mcKezd);
            this.Name = "MainForm";
            this.Text = "Napok számítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcKezd;
        private System.Windows.Forms.MonthCalendar mcZaro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEredm;
    }
}


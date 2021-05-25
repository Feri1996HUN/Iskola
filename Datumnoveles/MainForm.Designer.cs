namespace Datumnoveles
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.mtbEredm = new System.Windows.Forms.MaskedTextBox();
            this.rbnEv = new System.Windows.Forms.RadioButton();
            this.rbnHo = new System.Windows.Forms.RadioButton();
            this.rbnNap = new System.Windows.Forms.RadioButton();
            this.rbnOra = new System.Windows.Forms.RadioButton();
            this.rbnPerc = new System.Windows.Forms.RadioButton();
            this.rbnMperc = new System.Windows.Forms.RadioButton();
            this.nudSzam = new System.Windows.Forms.NumericUpDown();
            this.btnNov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEredm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "yyyy.mm.dd";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(12, 91);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // mtbEredm
            // 
            this.mtbEredm.Location = new System.Drawing.Point(12, 117);
            this.mtbEredm.Name = "mtbEredm";
            this.mtbEredm.Size = new System.Drawing.Size(100, 20);
            this.mtbEredm.TabIndex = 2;
            // 
            // rbnEv
            // 
            this.rbnEv.AutoSize = true;
            this.rbnEv.Location = new System.Drawing.Point(13, 22);
            this.rbnEv.Name = "rbnEv";
            this.rbnEv.Size = new System.Drawing.Size(38, 17);
            this.rbnEv.TabIndex = 3;
            this.rbnEv.TabStop = true;
            this.rbnEv.Text = "Év";
            this.rbnEv.UseVisualStyleBackColor = true;
            // 
            // rbnHo
            // 
            this.rbnHo.AutoSize = true;
            this.rbnHo.Location = new System.Drawing.Point(13, 45);
            this.rbnHo.Name = "rbnHo";
            this.rbnHo.Size = new System.Drawing.Size(57, 17);
            this.rbnHo.TabIndex = 3;
            this.rbnHo.TabStop = true;
            this.rbnHo.Text = "Hónap";
            this.rbnHo.UseVisualStyleBackColor = true;
            // 
            // rbnNap
            // 
            this.rbnNap.AutoSize = true;
            this.rbnNap.Location = new System.Drawing.Point(12, 68);
            this.rbnNap.Name = "rbnNap";
            this.rbnNap.Size = new System.Drawing.Size(45, 17);
            this.rbnNap.TabIndex = 3;
            this.rbnNap.TabStop = true;
            this.rbnNap.Text = "Nap";
            this.rbnNap.UseVisualStyleBackColor = true;
            // 
            // rbnOra
            // 
            this.rbnOra.AutoSize = true;
            this.rbnOra.Location = new System.Drawing.Point(104, 22);
            this.rbnOra.Name = "rbnOra";
            this.rbnOra.Size = new System.Drawing.Size(42, 17);
            this.rbnOra.TabIndex = 3;
            this.rbnOra.TabStop = true;
            this.rbnOra.Text = "Óra";
            this.rbnOra.UseVisualStyleBackColor = true;
            // 
            // rbnPerc
            // 
            this.rbnPerc.AutoSize = true;
            this.rbnPerc.Location = new System.Drawing.Point(103, 45);
            this.rbnPerc.Name = "rbnPerc";
            this.rbnPerc.Size = new System.Drawing.Size(47, 17);
            this.rbnPerc.TabIndex = 3;
            this.rbnPerc.TabStop = true;
            this.rbnPerc.Text = "Perc";
            this.rbnPerc.UseVisualStyleBackColor = true;
            // 
            // rbnMperc
            // 
            this.rbnMperc.AutoSize = true;
            this.rbnMperc.Location = new System.Drawing.Point(103, 68);
            this.rbnMperc.Name = "rbnMperc";
            this.rbnMperc.Size = new System.Drawing.Size(78, 17);
            this.rbnMperc.TabIndex = 3;
            this.rbnMperc.TabStop = true;
            this.rbnMperc.Text = "Másodperc";
            this.rbnMperc.UseVisualStyleBackColor = true;
            // 
            // nudSzam
            // 
            this.nudSzam.Location = new System.Drawing.Point(207, 33);
            this.nudSzam.Name = "nudSzam";
            this.nudSzam.Size = new System.Drawing.Size(120, 20);
            this.nudSzam.TabIndex = 4;
            // 
            // btnNov
            // 
            this.btnNov.Location = new System.Drawing.Point(225, 59);
            this.btnNov.Name = "btnNov";
            this.btnNov.Size = new System.Drawing.Size(75, 23);
            this.btnNov.TabIndex = 5;
            this.btnNov.Text = "Növelés";
            this.btnNov.UseVisualStyleBackColor = true;
            this.btnNov.Click += new System.EventHandler(this.btnNov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mennyivel?:";
            // 
            // lblEredm
            // 
            this.lblEredm.AutoSize = true;
            this.lblEredm.Location = new System.Drawing.Point(12, 144);
            this.lblEredm.Name = "lblEredm";
            this.lblEredm.Size = new System.Drawing.Size(35, 13);
            this.lblEredm.TabIndex = 7;
            this.lblEredm.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNov);
            this.Controls.Add(this.nudSzam);
            this.Controls.Add(this.rbnMperc);
            this.Controls.Add(this.rbnPerc);
            this.Controls.Add(this.rbnOra);
            this.Controls.Add(this.rbnNap);
            this.Controls.Add(this.rbnHo);
            this.Controls.Add(this.rbnEv);
            this.Controls.Add(this.mtbEredm);
            this.Controls.Add(this.dtpDatum);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.MaskedTextBox mtbEredm;
        private System.Windows.Forms.RadioButton rbnEv;
        private System.Windows.Forms.RadioButton rbnHo;
        private System.Windows.Forms.RadioButton rbnNap;
        private System.Windows.Forms.RadioButton rbnOra;
        private System.Windows.Forms.RadioButton rbnPerc;
        private System.Windows.Forms.RadioButton rbnMperc;
        private System.Windows.Forms.NumericUpDown nudSzam;
        private System.Windows.Forms.Button btnNov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEredm;
    }
}


namespace Formaz
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
            this.cbxMit = new System.Windows.Forms.ComboBox();
            this.nudFontmeret = new System.Windows.Forms.NumericUpDown();
            this.gbxSzin = new System.Windows.Forms.GroupBox();
            this.gbxStilus = new System.Windows.Forms.GroupBox();
            this.gbxFont = new System.Windows.Forms.GroupBox();
            this.cbxDolt = new System.Windows.Forms.CheckBox();
            this.cbxAlahuzott = new System.Windows.Forms.CheckBox();
            this.cbxFelkover = new System.Windows.Forms.CheckBox();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbTimes = new System.Windows.Forms.RadioButton();
            this.rbComic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtir = new System.Windows.Forms.Button();
            this.btnAlkalmaz = new System.Windows.Forms.Button();
            this.rbPiros = new System.Windows.Forms.RadioButton();
            this.rbKek = new System.Windows.Forms.RadioButton();
            this.rbZold = new System.Windows.Forms.RadioButton();
            this.rtbEredm = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontmeret)).BeginInit();
            this.gbxSzin.SuspendLayout();
            this.gbxStilus.SuspendLayout();
            this.gbxFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMit
            // 
            this.cbxMit.FormattingEnabled = true;
            this.cbxMit.Items.AddRange(new object[] {
            "Szöveg",
            "Háttér"});
            this.cbxMit.Location = new System.Drawing.Point(136, 13);
            this.cbxMit.Name = "cbxMit";
            this.cbxMit.Size = new System.Drawing.Size(121, 21);
            this.cbxMit.TabIndex = 0;
            this.cbxMit.SelectedIndexChanged += new System.EventHandler(this.cbxMit_SelectedIndexChanged);
            // 
            // nudFontmeret
            // 
            this.nudFontmeret.Location = new System.Drawing.Point(136, 65);
            this.nudFontmeret.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudFontmeret.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFontmeret.Name = "nudFontmeret";
            this.nudFontmeret.Size = new System.Drawing.Size(120, 20);
            this.nudFontmeret.TabIndex = 1;
            this.nudFontmeret.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // gbxSzin
            // 
            this.gbxSzin.Controls.Add(this.rbZold);
            this.gbxSzin.Controls.Add(this.rbKek);
            this.gbxSzin.Controls.Add(this.rbPiros);
            this.gbxSzin.Location = new System.Drawing.Point(28, 131);
            this.gbxSzin.Name = "gbxSzin";
            this.gbxSzin.Size = new System.Drawing.Size(74, 100);
            this.gbxSzin.TabIndex = 2;
            this.gbxSzin.TabStop = false;
            this.gbxSzin.Text = "Szín";
            // 
            // gbxStilus
            // 
            this.gbxStilus.Controls.Add(this.cbxFelkover);
            this.gbxStilus.Controls.Add(this.cbxDolt);
            this.gbxStilus.Controls.Add(this.cbxAlahuzott);
            this.gbxStilus.Location = new System.Drawing.Point(125, 131);
            this.gbxStilus.Name = "gbxStilus";
            this.gbxStilus.Size = new System.Drawing.Size(90, 100);
            this.gbxStilus.TabIndex = 3;
            this.gbxStilus.TabStop = false;
            this.gbxStilus.Text = "Stílus";
            // 
            // gbxFont
            // 
            this.gbxFont.Controls.Add(this.rbComic);
            this.gbxFont.Controls.Add(this.rbTimes);
            this.gbxFont.Controls.Add(this.rbArial);
            this.gbxFont.Location = new System.Drawing.Point(240, 131);
            this.gbxFont.Name = "gbxFont";
            this.gbxFont.Size = new System.Drawing.Size(125, 100);
            this.gbxFont.TabIndex = 4;
            this.gbxFont.TabStop = false;
            this.gbxFont.Text = "Font";
            // 
            // cbxDolt
            // 
            this.cbxDolt.AutoSize = true;
            this.cbxDolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxDolt.Location = new System.Drawing.Point(6, 20);
            this.cbxDolt.Name = "cbxDolt";
            this.cbxDolt.Size = new System.Drawing.Size(45, 17);
            this.cbxDolt.TabIndex = 0;
            this.cbxDolt.Text = "Dőlt";
            this.cbxDolt.UseVisualStyleBackColor = true;
            // 
            // cbxAlahuzott
            // 
            this.cbxAlahuzott.AutoSize = true;
            this.cbxAlahuzott.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxAlahuzott.Location = new System.Drawing.Point(6, 44);
            this.cbxAlahuzott.Name = "cbxAlahuzott";
            this.cbxAlahuzott.Size = new System.Drawing.Size(70, 17);
            this.cbxAlahuzott.TabIndex = 1;
            this.cbxAlahuzott.Text = "Aláhúzott";
            this.cbxAlahuzott.UseVisualStyleBackColor = true;
            // 
            // cbxFelkover
            // 
            this.cbxFelkover.AutoSize = true;
            this.cbxFelkover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxFelkover.Location = new System.Drawing.Point(6, 68);
            this.cbxFelkover.Name = "cbxFelkover";
            this.cbxFelkover.Size = new System.Drawing.Size(75, 17);
            this.cbxFelkover.TabIndex = 2;
            this.cbxFelkover.Text = "Félkövér";
            this.cbxFelkover.UseVisualStyleBackColor = true;
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rbArial.Location = new System.Drawing.Point(7, 20);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(47, 18);
            this.rbArial.TabIndex = 0;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            // 
            // rbTimes
            // 
            this.rbTimes.AutoSize = true;
            this.rbTimes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbTimes.Location = new System.Drawing.Point(7, 44);
            this.rbTimes.Name = "rbTimes";
            this.rbTimes.Size = new System.Drawing.Size(113, 18);
            this.rbTimes.TabIndex = 1;
            this.rbTimes.TabStop = true;
            this.rbTimes.Text = "Times New Roman";
            this.rbTimes.UseVisualStyleBackColor = true;
            // 
            // rbComic
            // 
            this.rbComic.AutoSize = true;
            this.rbComic.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbComic.Location = new System.Drawing.Point(7, 68);
            this.rbComic.Name = "rbComic";
            this.rbComic.Size = new System.Drawing.Size(84, 19);
            this.rbComic.TabIndex = 2;
            this.rbComic.TabStop = true;
            this.rbComic.Text = "Comic Sans";
            this.rbComic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mit formázok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Font méret: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Új szöveg: ";
            // 
            // btnAtir
            // 
            this.btnAtir.Location = new System.Drawing.Point(489, 208);
            this.btnAtir.Name = "btnAtir";
            this.btnAtir.Size = new System.Drawing.Size(75, 23);
            this.btnAtir.TabIndex = 10;
            this.btnAtir.Text = "Átír";
            this.btnAtir.UseVisualStyleBackColor = true;
            this.btnAtir.Click += new System.EventHandler(this.btnAtir_Click);
            // 
            // btnAlkalmaz
            // 
            this.btnAlkalmaz.Location = new System.Drawing.Point(489, 237);
            this.btnAlkalmaz.Name = "btnAlkalmaz";
            this.btnAlkalmaz.Size = new System.Drawing.Size(75, 23);
            this.btnAlkalmaz.TabIndex = 11;
            this.btnAlkalmaz.Text = "Alkalmaz";
            this.btnAlkalmaz.UseVisualStyleBackColor = true;
            this.btnAlkalmaz.Click += new System.EventHandler(this.btnAlkalmaz_Click);
            // 
            // rbPiros
            // 
            this.rbPiros.AutoSize = true;
            this.rbPiros.ForeColor = System.Drawing.Color.Red;
            this.rbPiros.Location = new System.Drawing.Point(7, 20);
            this.rbPiros.Name = "rbPiros";
            this.rbPiros.Size = new System.Drawing.Size(48, 17);
            this.rbPiros.TabIndex = 0;
            this.rbPiros.TabStop = true;
            this.rbPiros.Text = "Piros";
            this.rbPiros.UseVisualStyleBackColor = true;
            // 
            // rbKek
            // 
            this.rbKek.AutoSize = true;
            this.rbKek.ForeColor = System.Drawing.Color.Blue;
            this.rbKek.Location = new System.Drawing.Point(6, 45);
            this.rbKek.Name = "rbKek";
            this.rbKek.Size = new System.Drawing.Size(44, 17);
            this.rbKek.TabIndex = 0;
            this.rbKek.TabStop = true;
            this.rbKek.Text = "Kék";
            this.rbKek.UseVisualStyleBackColor = true;
            // 
            // rbZold
            // 
            this.rbZold.AutoSize = true;
            this.rbZold.ForeColor = System.Drawing.Color.Green;
            this.rbZold.Location = new System.Drawing.Point(6, 70);
            this.rbZold.Name = "rbZold";
            this.rbZold.Size = new System.Drawing.Size(46, 17);
            this.rbZold.TabIndex = 0;
            this.rbZold.TabStop = true;
            this.rbZold.Text = "Zöld";
            this.rbZold.UseVisualStyleBackColor = true;
            // 
            // rtbEredm
            // 
            this.rtbEredm.Location = new System.Drawing.Point(300, 13);
            this.rtbEredm.Name = "rtbEredm";
            this.rtbEredm.Size = new System.Drawing.Size(479, 112);
            this.rtbEredm.TabIndex = 12;
            this.rtbEredm.Text = "Próba";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEredm);
            this.Controls.Add(this.btnAlkalmaz);
            this.Controls.Add(this.btnAtir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxFont);
            this.Controls.Add(this.gbxStilus);
            this.Controls.Add(this.gbxSzin);
            this.Controls.Add(this.nudFontmeret);
            this.Controls.Add(this.cbxMit);
            this.Name = "MainForm";
            this.Text = "Formázás";
            ((System.ComponentModel.ISupportInitialize)(this.nudFontmeret)).EndInit();
            this.gbxSzin.ResumeLayout(false);
            this.gbxSzin.PerformLayout();
            this.gbxStilus.ResumeLayout(false);
            this.gbxStilus.PerformLayout();
            this.gbxFont.ResumeLayout(false);
            this.gbxFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMit;
        private System.Windows.Forms.NumericUpDown nudFontmeret;
        private System.Windows.Forms.GroupBox gbxSzin;
        private System.Windows.Forms.GroupBox gbxStilus;
        private System.Windows.Forms.CheckBox cbxFelkover;
        private System.Windows.Forms.CheckBox cbxDolt;
        private System.Windows.Forms.CheckBox cbxAlahuzott;
        private System.Windows.Forms.GroupBox gbxFont;
        private System.Windows.Forms.RadioButton rbComic;
        private System.Windows.Forms.RadioButton rbTimes;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtir;
        private System.Windows.Forms.Button btnAlkalmaz;
        private System.Windows.Forms.RadioButton rbZold;
        private System.Windows.Forms.RadioButton rbKek;
        private System.Windows.Forms.RadioButton rbPiros;
        private System.Windows.Forms.RichTextBox rtbEredm;
    }
}


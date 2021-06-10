namespace MemoriaJatekProgram
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
            this.rbHatszamjegy = new System.Windows.Forms.RadioButton();
            this.rbKilenszamjegy = new System.Windows.Forms.RadioButton();
            this.rb5mp = new System.Windows.Forms.RadioButton();
            this.rb10mp = new System.Windows.Forms.RadioButton();
            this.rb20mp = new System.Windows.Forms.RadioButton();
            this.rb1jegy = new System.Windows.Forms.RadioButton();
            this.rb2jegy = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbHatszamjegy
            // 
            this.rbHatszamjegy.AutoSize = true;
            this.rbHatszamjegy.Checked = true;
            this.rbHatszamjegy.Location = new System.Drawing.Point(24, 26);
            this.rbHatszamjegy.Name = "rbHatszamjegy";
            this.rbHatszamjegy.Size = new System.Drawing.Size(31, 17);
            this.rbHatszamjegy.TabIndex = 0;
            this.rbHatszamjegy.TabStop = true;
            this.rbHatszamjegy.Text = "6";
            this.rbHatszamjegy.UseVisualStyleBackColor = true;
            // 
            // rbKilenszamjegy
            // 
            this.rbKilenszamjegy.AutoSize = true;
            this.rbKilenszamjegy.Location = new System.Drawing.Point(24, 49);
            this.rbKilenszamjegy.Name = "rbKilenszamjegy";
            this.rbKilenszamjegy.Size = new System.Drawing.Size(31, 17);
            this.rbKilenszamjegy.TabIndex = 0;
            this.rbKilenszamjegy.Text = "9";
            this.rbKilenszamjegy.UseVisualStyleBackColor = true;
            // 
            // rb5mp
            // 
            this.rb5mp.AutoSize = true;
            this.rb5mp.Location = new System.Drawing.Point(21, 19);
            this.rb5mp.Name = "rb5mp";
            this.rb5mp.Size = new System.Drawing.Size(31, 17);
            this.rb5mp.TabIndex = 0;
            this.rb5mp.Text = "5";
            this.rb5mp.UseVisualStyleBackColor = true;
            // 
            // rb10mp
            // 
            this.rb10mp.AutoSize = true;
            this.rb10mp.Checked = true;
            this.rb10mp.Location = new System.Drawing.Point(21, 42);
            this.rb10mp.Name = "rb10mp";
            this.rb10mp.Size = new System.Drawing.Size(37, 17);
            this.rb10mp.TabIndex = 0;
            this.rb10mp.TabStop = true;
            this.rb10mp.Text = "10";
            this.rb10mp.UseVisualStyleBackColor = true;
            // 
            // rb20mp
            // 
            this.rb20mp.AutoSize = true;
            this.rb20mp.Location = new System.Drawing.Point(21, 65);
            this.rb20mp.Name = "rb20mp";
            this.rb20mp.Size = new System.Drawing.Size(37, 17);
            this.rb20mp.TabIndex = 0;
            this.rb20mp.Text = "20";
            this.rb20mp.UseVisualStyleBackColor = true;
            // 
            // rb1jegy
            // 
            this.rb1jegy.AutoSize = true;
            this.rb1jegy.Checked = true;
            this.rb1jegy.Location = new System.Drawing.Point(22, 26);
            this.rb1jegy.Name = "rb1jegy";
            this.rb1jegy.Size = new System.Drawing.Size(31, 17);
            this.rb1jegy.TabIndex = 0;
            this.rb1jegy.TabStop = true;
            this.rb1jegy.Text = "1";
            this.rb1jegy.UseVisualStyleBackColor = true;
            // 
            // rb2jegy
            // 
            this.rb2jegy.AutoSize = true;
            this.rb2jegy.Location = new System.Drawing.Point(22, 49);
            this.rb2jegy.Name = "rb2jegy";
            this.rb2jegy.Size = new System.Drawing.Size(31, 17);
            this.rb2jegy.TabIndex = 0;
            this.rb2jegy.Text = "2";
            this.rb2jegy.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(100, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Kezdés!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHatszamjegy);
            this.groupBox1.Controls.Add(this.rbKilenszamjegy);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hány szám?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb5mp);
            this.groupBox2.Controls.Add(this.rb10mp);
            this.groupBox2.Controls.Add(this.rb20mp);
            this.groupBox2.Location = new System.Drawing.Point(100, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mennyi ideig?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb1jegy);
            this.groupBox3.Controls.Add(this.rb2jegy);
            this.groupBox3.Location = new System.Drawing.Point(194, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hány jegyű?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 171);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHatszamjegy;
        private System.Windows.Forms.RadioButton rbKilenszamjegy;
        private System.Windows.Forms.RadioButton rb5mp;
        private System.Windows.Forms.RadioButton rb10mp;
        private System.Windows.Forms.RadioButton rb20mp;
        private System.Windows.Forms.RadioButton rb1jegy;
        private System.Windows.Forms.RadioButton rb2jegy;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


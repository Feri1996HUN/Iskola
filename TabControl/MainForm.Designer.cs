namespace TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMegoldas = new System.Windows.Forms.Label();
            this.nudSzam1 = new System.Windows.Forms.NumericUpDown();
            this.nudSzam2 = new System.Windows.Forms.NumericUpDown();
            this.btnMegold = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(214, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnKilep);
            this.tabPage1.Controls.Add(this.btnMegold);
            this.tabPage1.Controls.Add(this.nudSzam2);
            this.tabPage1.Controls.Add(this.nudSzam1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Számol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMegoldas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(206, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Megoldás";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjon meg két számot";
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.AutoSize = true;
            this.lblMegoldas.Location = new System.Drawing.Point(81, 101);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(0, 13);
            this.lblMegoldas.TabIndex = 0;
            // 
            // nudSzam1
            // 
            this.nudSzam1.Location = new System.Drawing.Point(38, 60);
            this.nudSzam1.Name = "nudSzam1";
            this.nudSzam1.Size = new System.Drawing.Size(120, 20);
            this.nudSzam1.TabIndex = 1;
            // 
            // nudSzam2
            // 
            this.nudSzam2.Location = new System.Drawing.Point(38, 101);
            this.nudSzam2.Name = "nudSzam2";
            this.nudSzam2.Size = new System.Drawing.Size(120, 20);
            this.nudSzam2.TabIndex = 2;
            // 
            // btnMegold
            // 
            this.btnMegold.Location = new System.Drawing.Point(61, 144);
            this.btnMegold.Name = "btnMegold";
            this.btnMegold.Size = new System.Drawing.Size(75, 23);
            this.btnMegold.TabIndex = 3;
            this.btnMegold.Text = "Megold";
            this.btnMegold.UseVisualStyleBackColor = true;
            this.btnMegold.Click += new System.EventHandler(this.Szamol);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(61, 185);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "Kilép";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 254);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "TabControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMegold;
        private System.Windows.Forms.NumericUpDown nudSzam2;
        private System.Windows.Forms.NumericUpDown nudSzam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMegoldas;
        private System.Windows.Forms.Button btnKilep;
    }
}


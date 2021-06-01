namespace KepernyoFelezes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxMozgat = new System.Windows.Forms.GroupBox();
            this.btnMegold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSzam2 = new System.Windows.Forms.NumericUpDown();
            this.nudSzam1 = new System.Windows.Forms.NumericUpDown();
            this.lblMegoldas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxMozgat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Green;
            this.splitContainer1.Panel1.Controls.Add(this.gbxMozgat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Brown;
            this.splitContainer1.Panel2.Controls.Add(this.lblMegoldas);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // gbxMozgat
            // 
            this.gbxMozgat.Controls.Add(this.btnMegold);
            this.gbxMozgat.Controls.Add(this.label1);
            this.gbxMozgat.Controls.Add(this.nudSzam2);
            this.gbxMozgat.Controls.Add(this.nudSzam1);
            this.gbxMozgat.Location = new System.Drawing.Point(54, 118);
            this.gbxMozgat.Name = "gbxMozgat";
            this.gbxMozgat.Size = new System.Drawing.Size(200, 173);
            this.gbxMozgat.TabIndex = 4;
            this.gbxMozgat.TabStop = false;
            this.gbxMozgat.Text = "groupBox1";
            // 
            // btnMegold
            // 
            this.btnMegold.Location = new System.Drawing.Point(63, 134);
            this.btnMegold.Name = "btnMegold";
            this.btnMegold.Size = new System.Drawing.Size(75, 23);
            this.btnMegold.TabIndex = 3;
            this.btnMegold.Text = "Összead";
            this.btnMegold.UseVisualStyleBackColor = true;
            this.btnMegold.Click += new System.EventHandler(this.Szamol);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adj meg két számot";
            // 
            // nudSzam2
            // 
            this.nudSzam2.Location = new System.Drawing.Point(47, 99);
            this.nudSzam2.Name = "nudSzam2";
            this.nudSzam2.Size = new System.Drawing.Size(120, 20);
            this.nudSzam2.TabIndex = 1;
            // 
            // nudSzam1
            // 
            this.nudSzam1.Location = new System.Drawing.Point(47, 64);
            this.nudSzam1.Name = "nudSzam1";
            this.nudSzam1.Size = new System.Drawing.Size(120, 20);
            this.nudSzam1.TabIndex = 0;
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.AutoSize = true;
            this.lblMegoldas.Location = new System.Drawing.Point(117, 103);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(0, 13);
            this.lblMegoldas.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxMozgat.ResumeLayout(false);
            this.gbxMozgat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzam1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnMegold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSzam2;
        private System.Windows.Forms.NumericUpDown nudSzam1;
        private System.Windows.Forms.Label lblMegoldas;
        private System.Windows.Forms.GroupBox gbxMozgat;
    }
}


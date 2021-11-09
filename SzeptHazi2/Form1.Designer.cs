
namespace SzeptHazi2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEv = new System.Windows.Forms.NumericUpDown();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblEv = new System.Windows.Forms.Label();
            this.lblRossznev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi a neved?";
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(162, 46);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(100, 20);
            this.tbxNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Melyik évben születtél?";
            // 
            // nudEv
            // 
            this.nudEv.Location = new System.Drawing.Point(162, 90);
            this.nudEv.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudEv.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudEv.Name = "nudEv";
            this.nudEv.Size = new System.Drawing.Size(100, 20);
            this.nudEv.TabIndex = 2;
            this.nudEv.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(71, 131);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(158, 55);
            this.btnSzamol.TabIndex = 3;
            this.btnSzamol.Text = "Kattints rám";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.ForeColor = System.Drawing.Color.Yellow;
            this.lblNev.Location = new System.Drawing.Point(115, 69);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(0, 13);
            this.lblNev.TabIndex = 0;
            // 
            // lblEv
            // 
            this.lblEv.AutoSize = true;
            this.lblEv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEv.Location = new System.Drawing.Point(115, 115);
            this.lblEv.Name = "lblEv";
            this.lblEv.Size = new System.Drawing.Size(0, 13);
            this.lblEv.TabIndex = 0;
            // 
            // lblRossznev
            // 
            this.lblRossznev.AutoSize = true;
            this.lblRossznev.Location = new System.Drawing.Point(111, 20);
            this.lblRossznev.Name = "lblRossznev";
            this.lblRossznev.Size = new System.Drawing.Size(0, 13);
            this.lblRossznev.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 232);
            this.Controls.Add(this.lblRossznev);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.nudEv);
            this.Controls.Add(this.tbxNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEv);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudEv;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblEv;
        private System.Windows.Forms.Label lblRossznev;
    }
}


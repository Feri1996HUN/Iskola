
namespace SzeptHazi3
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
            this.nudDB = new System.Windows.Forms.NumericUpDown();
            this.btnMegold = new System.Windows.Forms.Button();
            this.ltbTomb = new System.Windows.Forms.ListBox();
            this.ltbRendez = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány db szám legyen a tömbben";
            // 
            // nudDB
            // 
            this.nudDB.Location = new System.Drawing.Point(196, 34);
            this.nudDB.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDB.Name = "nudDB";
            this.nudDB.Size = new System.Drawing.Size(120, 20);
            this.nudDB.TabIndex = 1;
            this.nudDB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnMegold
            // 
            this.btnMegold.Location = new System.Drawing.Point(139, 76);
            this.btnMegold.Name = "btnMegold";
            this.btnMegold.Size = new System.Drawing.Size(75, 23);
            this.btnMegold.TabIndex = 3;
            this.btnMegold.Text = "klikk";
            this.btnMegold.UseVisualStyleBackColor = true;
            this.btnMegold.Click += new System.EventHandler(this.btnMegold_Click);
            // 
            // ltbTomb
            // 
            this.ltbTomb.FormattingEnabled = true;
            this.ltbTomb.Location = new System.Drawing.Point(32, 76);
            this.ltbTomb.Name = "ltbTomb";
            this.ltbTomb.Size = new System.Drawing.Size(71, 251);
            this.ltbTomb.TabIndex = 4;
            // 
            // ltbRendez
            // 
            this.ltbRendez.FormattingEnabled = true;
            this.ltbRendez.Location = new System.Drawing.Point(245, 76);
            this.ltbRendez.Name = "ltbRendez";
            this.ltbRendez.Size = new System.Drawing.Size(71, 251);
            this.ltbRendez.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "rendezett tömb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "tömb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.ltbRendez);
            this.Controls.Add(this.ltbTomb);
            this.Controls.Add(this.btnMegold);
            this.Controls.Add(this.nudDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDB;
        private System.Windows.Forms.Button btnMegold;
        private System.Windows.Forms.ListBox ltbTomb;
        private System.Windows.Forms.ListBox ltbRendez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


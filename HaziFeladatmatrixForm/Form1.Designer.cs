
namespace HaziFeladatmatrixForm
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
            this.nudMatrix = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAtlo = new System.Windows.Forms.Label();
            this.lblSkalar = new System.Windows.Forms.Label();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMatrix1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvMatrix2 = new System.Windows.Forms.DataGridView();
            this.lblTerulet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrix)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add meg, hogy hány eleműek legyenek a mátrixok:";
            // 
            // nudMatrix
            // 
            this.nudMatrix.Location = new System.Drawing.Point(283, 37);
            this.nudMatrix.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMatrix.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMatrix.Name = "nudMatrix";
            this.nudMatrix.Size = new System.Drawing.Size(120, 20);
            this.nudMatrix.TabIndex = 1;
            this.nudMatrix.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTerulet);
            this.tabPage1.Controls.Add(this.lblAtlo);
            this.tabPage1.Controls.Add(this.lblSkalar);
            this.tabPage1.Controls.Add(this.btnGeneral);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudMatrix);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Főoldal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAtlo
            // 
            this.lblAtlo.AutoSize = true;
            this.lblAtlo.Location = new System.Drawing.Point(16, 134);
            this.lblAtlo.Name = "lblAtlo";
            this.lblAtlo.Size = new System.Drawing.Size(58, 13);
            this.lblAtlo.TabIndex = 4;
            this.lblAtlo.Text = "Átlóösszeg";
            // 
            // lblSkalar
            // 
            this.lblSkalar.AutoSize = true;
            this.lblSkalar.Location = new System.Drawing.Point(16, 91);
            this.lblSkalar.Name = "lblSkalar";
            this.lblSkalar.Size = new System.Drawing.Size(37, 13);
            this.lblSkalar.TabIndex = 3;
            this.lblSkalar.Text = "Skalár";
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(423, 37);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "Generál";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMatrix1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mátrix 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMatrix1
            // 
            this.dgvMatrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrix1.Location = new System.Drawing.Point(3, 3);
            this.dgvMatrix1.Name = "dgvMatrix1";
            this.dgvMatrix1.Size = new System.Drawing.Size(786, 418);
            this.dgvMatrix1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMatrix2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mátrix 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvMatrix2
            // 
            this.dgvMatrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrix2.Location = new System.Drawing.Point(3, 3);
            this.dgvMatrix2.Name = "dgvMatrix2";
            this.dgvMatrix2.Size = new System.Drawing.Size(786, 418);
            this.dgvMatrix2.TabIndex = 0;
            // 
            // lblTerulet
            // 
            this.lblTerulet.AutoSize = true;
            this.lblTerulet.Location = new System.Drawing.Point(16, 174);
            this.lblTerulet.Name = "lblTerulet";
            this.lblTerulet.Size = new System.Drawing.Size(40, 13);
            this.lblTerulet.TabIndex = 5;
            this.lblTerulet.Text = "Terület";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrix)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMatrix;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvMatrix1;
        private System.Windows.Forms.DataGridView dgvMatrix2;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Label lblSkalar;
        private System.Windows.Forms.Label lblAtlo;
        private System.Windows.Forms.Label lblTerulet;
    }
}


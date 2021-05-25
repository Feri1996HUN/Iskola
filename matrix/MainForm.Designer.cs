namespace matrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSor = new System.Windows.Forms.Label();
            this.lblOszlop = new System.Windows.Forms.Label();
            this.nudSor = new System.Windows.Forms.NumericUpDown();
            this.nudOszlop = new System.Windows.Forms.NumericUpDown();
            this.btnMehet = new System.Windows.Forms.Button();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.rtbEredm = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adja meg a mátrix méretét:";
            // 
            // lblSor
            // 
            this.lblSor.AutoSize = true;
            this.lblSor.Location = new System.Drawing.Point(159, 18);
            this.lblSor.Name = "lblSor";
            this.lblSor.Size = new System.Drawing.Size(29, 13);
            this.lblSor.TabIndex = 1;
            this.lblSor.Text = "Sor: ";
            // 
            // lblOszlop
            // 
            this.lblOszlop.AutoSize = true;
            this.lblOszlop.Location = new System.Drawing.Point(284, 18);
            this.lblOszlop.Name = "lblOszlop";
            this.lblOszlop.Size = new System.Drawing.Size(45, 13);
            this.lblOszlop.TabIndex = 2;
            this.lblOszlop.Text = "Oszlop: ";
            // 
            // nudSor
            // 
            this.nudSor.Location = new System.Drawing.Point(203, 14);
            this.nudSor.Name = "nudSor";
            this.nudSor.Size = new System.Drawing.Size(66, 20);
            this.nudSor.TabIndex = 3;
            // 
            // nudOszlop
            // 
            this.nudOszlop.Location = new System.Drawing.Point(344, 14);
            this.nudOszlop.Name = "nudOszlop";
            this.nudOszlop.Size = new System.Drawing.Size(66, 20);
            this.nudOszlop.TabIndex = 4;
            // 
            // btnMehet
            // 
            this.btnMehet.Location = new System.Drawing.Point(425, 13);
            this.btnMehet.Name = "btnMehet";
            this.btnMehet.Size = new System.Drawing.Size(75, 23);
            this.btnMehet.TabIndex = 5;
            this.btnMehet.Text = "Mehet";
            this.btnMehet.UseVisualStyleBackColor = true;
            this.btnMehet.Click += new System.EventHandler(this.btnMehet_Click);
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(35, 57);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.Size = new System.Drawing.Size(440, 374);
            this.dgvMatrix.TabIndex = 6;
            // 
            // rtbEredm
            // 
            this.rtbEredm.Location = new System.Drawing.Point(516, 57);
            this.rtbEredm.Name = "rtbEredm";
            this.rtbEredm.Size = new System.Drawing.Size(242, 373);
            this.rtbEredm.TabIndex = 7;
            this.rtbEredm.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEredm);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.btnMehet);
            this.Controls.Add(this.nudOszlop);
            this.Controls.Add(this.nudSor);
            this.Controls.Add(this.lblOszlop);
            this.Controls.Add(this.lblSor);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Mátrix";
            ((System.ComponentModel.ISupportInitialize)(this.nudSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOszlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSor;
        private System.Windows.Forms.Label lblOszlop;
        private System.Windows.Forms.NumericUpDown nudSor;
        private System.Windows.Forms.NumericUpDown nudOszlop;
        private System.Windows.Forms.Button btnMehet;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.RichTextBox rtbEredm;
    }
}


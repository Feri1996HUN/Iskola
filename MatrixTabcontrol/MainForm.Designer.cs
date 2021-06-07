namespace MatrixTabcontrol
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
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageSkalar = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvTranszponal = new System.Windows.Forms.DataGridView();
            this.dgvSkalar = new System.Windows.Forms.DataGridView();
            this.lblLegkisebb = new System.Windows.Forms.Label();
            this.lblLegnagyobb = new System.Windows.Forms.Label();
            this.nudSkalar = new System.Windows.Forms.NumericUpDown();
            this.btnSkalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageSkalar.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranszponal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            this.dgvMatrix.Location = new System.Drawing.Point(8, 6);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(299, 210);
            this.dgvMatrix.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageSkalar);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 248);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSkalar);
            this.tabPage1.Controls.Add(this.nudSkalar);
            this.tabPage1.Controls.Add(this.dgvMatrix);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mátrix";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTranszponal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transzponált mátrix";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageSkalar
            // 
            this.tabPageSkalar.Controls.Add(this.dgvSkalar);
            this.tabPageSkalar.Location = new System.Drawing.Point(4, 22);
            this.tabPageSkalar.Name = "tabPageSkalar";
            this.tabPageSkalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkalar.Size = new System.Drawing.Size(440, 222);
            this.tabPageSkalar.TabIndex = 2;
            this.tabPageSkalar.Text = "Skalárszorzott mátrix";
            this.tabPageSkalar.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblLegkisebb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(440, 222);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Legkisebb érték";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblLegnagyobb);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(440, 222);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Legnagyobb érték";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvTranszponal
            // 
            this.dgvTranszponal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranszponal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTranszponal.Location = new System.Drawing.Point(3, 3);
            this.dgvTranszponal.Name = "dgvTranszponal";
            this.dgvTranszponal.Size = new System.Drawing.Size(434, 216);
            this.dgvTranszponal.TabIndex = 0;
            // 
            // dgvSkalar
            // 
            this.dgvSkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkalar.Location = new System.Drawing.Point(3, 3);
            this.dgvSkalar.Name = "dgvSkalar";
            this.dgvSkalar.Size = new System.Drawing.Size(434, 216);
            this.dgvSkalar.TabIndex = 0;
            // 
            // lblLegkisebb
            // 
            this.lblLegkisebb.AutoSize = true;
            this.lblLegkisebb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLegkisebb.Location = new System.Drawing.Point(178, 100);
            this.lblLegkisebb.Name = "lblLegkisebb";
            this.lblLegkisebb.Size = new System.Drawing.Size(76, 26);
            this.lblLegkisebb.TabIndex = 0;
            this.lblLegkisebb.Text = "label1";
            // 
            // lblLegnagyobb
            // 
            this.lblLegnagyobb.AutoSize = true;
            this.lblLegnagyobb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLegnagyobb.Location = new System.Drawing.Point(170, 99);
            this.lblLegnagyobb.Name = "lblLegnagyobb";
            this.lblLegnagyobb.Size = new System.Drawing.Size(76, 26);
            this.lblLegnagyobb.TabIndex = 0;
            this.lblLegnagyobb.Text = "label2";
            // 
            // nudSkalar
            // 
            this.nudSkalar.Location = new System.Drawing.Point(333, 80);
            this.nudSkalar.Name = "nudSkalar";
            this.nudSkalar.Size = new System.Drawing.Size(80, 20);
            this.nudSkalar.TabIndex = 1;
            // 
            // btnSkalar
            // 
            this.btnSkalar.Location = new System.Drawing.Point(333, 117);
            this.btnSkalar.Name = "btnSkalar";
            this.btnSkalar.Size = new System.Drawing.Size(75, 23);
            this.btnSkalar.TabIndex = 2;
            this.btnSkalar.Text = "Számol";
            this.btnSkalar.UseVisualStyleBackColor = true;
            this.btnSkalar.Click += new System.EventHandler(this.btnSkalar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 248);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Mátrix Tabcontrol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPageSkalar.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranszponal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTranszponal;
        private System.Windows.Forms.TabPage tabPageSkalar;
        private System.Windows.Forms.DataGridView dgvSkalar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblLegkisebb;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblLegnagyobb;
        private System.Windows.Forms.NumericUpDown nudSkalar;
        private System.Windows.Forms.Button btnSkalar;
    }
}


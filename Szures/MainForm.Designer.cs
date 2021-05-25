namespace Szures
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
            this.lbxBal = new System.Windows.Forms.ListBox();
            this.lbxJobb = new System.Windows.Forms.ListBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.clbSzures = new System.Windows.Forms.CheckedListBox();
            this.btnSzur = new System.Windows.Forms.Button();
            this.lblStatisztika = new System.Windows.Forms.Label();
            this.cbxTorol = new System.Windows.Forms.CheckBox();
            this.cbxDupla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxBal
            // 
            this.lbxBal.FormattingEnabled = true;
            this.lbxBal.Location = new System.Drawing.Point(27, 40);
            this.lbxBal.Name = "lbxBal";
            this.lbxBal.Size = new System.Drawing.Size(120, 303);
            this.lbxBal.TabIndex = 0;
            // 
            // lbxJobb
            // 
            this.lbxJobb.FormattingEnabled = true;
            this.lbxJobb.Location = new System.Drawing.Point(355, 40);
            this.lbxJobb.Name = "lbxJobb";
            this.lbxJobb.Size = new System.Drawing.Size(172, 303);
            this.lbxJobb.TabIndex = 1;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(46, 362);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "Generál";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // clbSzures
            // 
            this.clbSzures.FormattingEnabled = true;
            this.clbSzures.Items.AddRange(new object[] {
            "Prímek",
            "Páros számok",
            "Páratlan számok",
            "Hárommal osztható számok",
            "Hattal osztható számok",
            "Kilencel osztható számok",
            "Négyzetszámok"});
            this.clbSzures.Location = new System.Drawing.Point(175, 122);
            this.clbSzures.Name = "clbSzures";
            this.clbSzures.Size = new System.Drawing.Size(154, 109);
            this.clbSzures.TabIndex = 3;
            this.clbSzures.SelectedIndexChanged += new System.EventHandler(this.clbSzures_SelectedIndexChanged);
            // 
            // btnSzur
            // 
            this.btnSzur.Location = new System.Drawing.Point(213, 251);
            this.btnSzur.Name = "btnSzur";
            this.btnSzur.Size = new System.Drawing.Size(75, 23);
            this.btnSzur.TabIndex = 4;
            this.btnSzur.Text = "Szűr";
            this.btnSzur.UseVisualStyleBackColor = true;
            this.btnSzur.Click += new System.EventHandler(this.btnSzur_Click);
            // 
            // lblStatisztika
            // 
            this.lblStatisztika.AutoSize = true;
            this.lblStatisztika.Location = new System.Drawing.Point(418, 362);
            this.lblStatisztika.Name = "lblStatisztika";
            this.lblStatisztika.Size = new System.Drawing.Size(55, 13);
            this.lblStatisztika.TabIndex = 5;
            this.lblStatisztika.Text = "Statisztika";
            // 
            // cbxTorol
            // 
            this.cbxTorol.AutoSize = true;
            this.cbxTorol.Location = new System.Drawing.Point(55, 391);
            this.cbxTorol.Name = "cbxTorol";
            this.cbxTorol.Size = new System.Drawing.Size(57, 17);
            this.cbxTorol.TabIndex = 6;
            this.cbxTorol.Text = "Új lista";
            this.cbxTorol.UseVisualStyleBackColor = true;
            // 
            // cbxDupla
            // 
            this.cbxDupla.AutoSize = true;
            this.cbxDupla.Location = new System.Drawing.Point(193, 280);
            this.cbxDupla.Name = "cbxDupla";
            this.cbxDupla.Size = new System.Drawing.Size(117, 17);
            this.cbxDupla.TabIndex = 7;
            this.cbxDupla.Text = "Duplázás kiszűrése";
            this.cbxDupla.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxDupla);
            this.Controls.Add(this.cbxTorol);
            this.Controls.Add(this.lblStatisztika);
            this.Controls.Add(this.btnSzur);
            this.Controls.Add(this.clbSzures);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.lbxJobb);
            this.Controls.Add(this.lbxBal);
            this.Name = "MainForm";
            this.Text = "Lista Szűrés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBal;
        private System.Windows.Forms.ListBox lbxJobb;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.CheckedListBox clbSzures;
        private System.Windows.Forms.Button btnSzur;
        private System.Windows.Forms.Label lblStatisztika;
        private System.Windows.Forms.CheckBox cbxTorol;
        private System.Windows.Forms.CheckBox cbxDupla;
    }
}


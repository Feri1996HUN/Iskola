
namespace SzeptHazi4
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
            this.ltbArray = new System.Windows.Forms.ListBox();
            this.lblMegoldas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbArray
            // 
            this.ltbArray.FormattingEnabled = true;
            this.ltbArray.Location = new System.Drawing.Point(12, 38);
            this.ltbArray.Name = "ltbArray";
            this.ltbArray.Size = new System.Drawing.Size(68, 264);
            this.ltbArray.TabIndex = 0;
            // 
            // lblMegoldas
            // 
            this.lblMegoldas.AutoSize = true;
            this.lblMegoldas.Location = new System.Drawing.Point(97, 38);
            this.lblMegoldas.Name = "lblMegoldas";
            this.lblMegoldas.Size = new System.Drawing.Size(0, 13);
            this.lblMegoldas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.lblMegoldas);
            this.Controls.Add(this.ltbArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbArray;
        private System.Windows.Forms.Label lblMegoldas;
    }
}


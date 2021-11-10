
namespace iktat
{
    partial class iktatform
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
            this.components = new System.ComponentModel.Container();
            this.dtpErkezett = new System.Windows.Forms.DateTimePicker();
            this.cbxCimzett = new System.Windows.Forms.ComboBox();
            this.tbxTargy = new System.Windows.Forms.TextBox();
            this.rtbleiras = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.letterDS = new iktat.letterDS();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new iktat.letterDSTableAdapters.usersTableAdapter();
            this.iktatDataSet = new iktat.iktatDataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new iktat.iktatDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.letterDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpErkezett
            // 
            this.dtpErkezett.Location = new System.Drawing.Point(12, 38);
            this.dtpErkezett.Name = "dtpErkezett";
            this.dtpErkezett.Size = new System.Drawing.Size(200, 20);
            this.dtpErkezett.TabIndex = 0;
            // 
            // cbxCimzett
            // 
            this.cbxCimzett.FormattingEnabled = true;
            this.cbxCimzett.Location = new System.Drawing.Point(12, 80);
            this.cbxCimzett.Name = "cbxCimzett";
            this.cbxCimzett.Size = new System.Drawing.Size(200, 21);
            this.cbxCimzett.TabIndex = 1;
            this.cbxCimzett.ValueMember = "id_user";
            // 
            // tbxTargy
            // 
            this.tbxTargy.Location = new System.Drawing.Point(12, 129);
            this.tbxTargy.Name = "tbxTargy";
            this.tbxTargy.Size = new System.Drawing.Size(200, 20);
            this.tbxTargy.TabIndex = 2;
            // 
            // rtbleiras
            // 
            this.rtbleiras.Location = new System.Drawing.Point(12, 179);
            this.rtbleiras.Name = "rtbleiras";
            this.rtbleiras.Size = new System.Drawing.Size(200, 96);
            this.rtbleiras.TabIndex = 3;
            this.rtbleiras.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Érkezett";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Címzett";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tárgy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leírás";
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(15, 300);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 5;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(137, 300);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // letterDS
            // 
            this.letterDS.DataSetName = "letterDS";
            this.letterDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.letterDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // iktatDataSet
            // 
            this.iktatDataSet.DataSetName = "iktatDataSet";
            this.iktatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.iktatDataSet;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // iktatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 399);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbleiras);
            this.Controls.Add(this.tbxTargy);
            this.Controls.Add(this.cbxCimzett);
            this.Controls.Add(this.dtpErkezett);
            this.Name = "iktatform";
            this.Text = "iktatform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.iktatform_FormClosed);
            this.Load += new System.EventHandler(this.iktatform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letterDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpErkezett;
        private System.Windows.Forms.ComboBox cbxCimzett;
        private System.Windows.Forms.TextBox tbxTargy;
        private System.Windows.Forms.RichTextBox rtbleiras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnOk;
        private letterDS letterDS;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private letterDSTableAdapters.usersTableAdapter usersTableAdapter;
        private iktatDataSet iktatDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private iktatDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
    }
}
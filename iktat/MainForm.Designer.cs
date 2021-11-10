
namespace iktat
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
            this.components = new System.ComponentModel.Container();
            this.iktatDataSet = new iktat.iktatDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new iktat.iktatDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new iktat.iktatDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iktatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levélToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levélListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valami1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valami2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iktatDataSet
            // 
            this.iktatDataSet.DataSetName = "iktatDataSet";
            this.iktatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.iktatDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = iktat.iktatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználókToolStripMenuItem,
            this.levelekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valami1ToolStripMenuItem,
            this.valami2ToolStripMenuItem});
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            // 
            // levelekToolStripMenuItem
            // 
            this.levelekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iktatásToolStripMenuItem,
            this.levélToolStripMenuItem,
            this.levélListaToolStripMenuItem});
            this.levelekToolStripMenuItem.Name = "levelekToolStripMenuItem";
            this.levelekToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.levelekToolStripMenuItem.Text = "Levelek";
            // 
            // iktatásToolStripMenuItem
            // 
            this.iktatásToolStripMenuItem.Name = "iktatásToolStripMenuItem";
            this.iktatásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iktatásToolStripMenuItem.Text = "Iktatás";
            this.iktatásToolStripMenuItem.Click += new System.EventHandler(this.iktatásToolStripMenuItem_Click);
            // 
            // levélToolStripMenuItem
            // 
            this.levélToolStripMenuItem.Name = "levélToolStripMenuItem";
            this.levélToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.levélToolStripMenuItem.Text = "levél";
            this.levélToolStripMenuItem.Click += new System.EventHandler(this.levélToolStripMenuItem_Click);
            // 
            // levélListaToolStripMenuItem
            // 
            this.levélListaToolStripMenuItem.Name = "levélListaToolStripMenuItem";
            this.levélListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.levélListaToolStripMenuItem.Text = "levelek lista";
            this.levélListaToolStripMenuItem.Click += new System.EventHandler(this.levélListaToolStripMenuItem_Click);
            // 
            // valami1ToolStripMenuItem
            // 
            this.valami1ToolStripMenuItem.Name = "valami1ToolStripMenuItem";
            this.valami1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.valami1ToolStripMenuItem.Text = "valami1";
            // 
            // valami2ToolStripMenuItem
            // 
            this.valami2ToolStripMenuItem.Name = "valami2ToolStripMenuItem";
            this.valami2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.valami2ToolStripMenuItem.Text = "valami2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 252);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Felhasználó";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iktatDataSet iktatDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private iktatDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private iktatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iktatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levélToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levélListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valami1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valami2ToolStripMenuItem;
    }
}


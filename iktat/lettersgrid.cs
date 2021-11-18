using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktat
{
    public partial class lettersgrid : Form
    {
        public lettersgrid()
        {
            InitializeComponent();
        }

        private void lettersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void lettersgrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktato2LevelDS.letters' table. You can move, or remove it, as needed.
            this.lettersTableAdapter.Fill(this.iktato2LevelDS.letters);

        }

        private void lettersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lettersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktato2LevelDS);

        }
    }
}

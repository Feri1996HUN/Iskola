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
    public partial class usertetel : Form
    {
        public usertetel()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iktato2UsersDS);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                
            }
            

        }

        private void usertetel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktato2UsersDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktato2UsersDS.users);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktato2UsersDS);

        }
    }
}

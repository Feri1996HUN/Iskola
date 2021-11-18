using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktat
{
    public partial class iktatform : Form
    {
        // Osztályváltozók
        private SqlConnection sqlConn;
        private string letterInstert = "letterInstert";
        private string userstocbx = "userstocbx";
        //public string insert = "INSERT INTO letters (erkezett, targy, leiras, id_user) VALUES (@erkezett, @targy, @leiras, @user) RETURN 0";


        public iktatform()
        {
            InitializeComponent();
        }

        private void iktatform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktato2LevelekDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktato2LevelekDS.users);
            // TODO: This line of code loads data into the 'iktato2LevelekDS.letters' table. You can move, or remove it, as needed.
            this.lettersTableAdapter.Fill(this.iktato2LevelekDS.letters);
            // TODO: This line of code loads data into the 'iktato2LevelekDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktato2LevelekDS.users);
            // TODO: This line of code loads data into the 'iktato2LevelekDS.letters' table. You can move, or remove it, as needed.
            this.lettersTableAdapter.Fill(this.iktato2LevelekDS.letters);
            sqlConnect();

            UserCbxFill(userstocbx, sqlConn);


        }

        private void sqlConnect()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "(localdb)\\MSSQlLocalDB";
            sb.InitialCatalog = "iktato2";

            try
            {
                sqlConn = new SqlConnection(sb.ToString());
                sqlConn.Open();
                MessageBox.Show("A kapcsolódás sikeres!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("A kapcsolódás sikertelen \n{0}", ex.Message);
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            insertletter();
        }

        /*  MEGOLDVA   MEGOLDVA  !!!
         stored procedure létrehozni ->
        CREATE PROCEDURE [dbo].letterInstert
	@erkezett date,
	@targy nchar(50),
	@leiras text,
	@user int
AS
	INSERT INTO letters (erkezett, targy, leiras, id_user) VALUES (@erkezett, @targy, @leiras, @user)
RETURN 0
         */

        /*
         hiba : ->
        Update cannot proceed due to validation errors.  
Please correct the following errors and try again.

SQL00000 :: The target database schema could not be retrieved. Cannot open database "C:\USERS\2020532\SOURCE\REPOS\ISKOLA\IKTAT\IKTAT.MDF" requested by the login. The login failed.
Login failed for user 'BP\2020532'.
         */

        //Kipróbálni: make sure that the .mdf file is not readonly; and try to run the VS in administrator.
        
        private void UserCbxFill(string userstocbx, SqlConnection sqlConn)
        {
            try
            {
                //Datatable feltöltése az adatbázisból
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlConn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //Az első sor közvetlen bevitele
                DataRow rowItem = dtbl.NewRow();
                rowItem[0] = 0;
                rowItem[1] = "- Válasszon -";
                dtbl.Rows.InsertAt(rowItem, 0);

                // A combobox komponens bekötése a datatablehöz
                id_userComboBox.ValueMember = "id_user";
                id_userComboBox.DisplayMember = "nev";
                id_userComboBox.DataSource = dtbl;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }



        private void insertletter()
        {
            using (SqlCommand sqlCom = new SqlCommand(letterInstert, sqlConn))
            {
               
              sqlCom.Parameters.AddWithValue("erkezett", erkezettDateTimePicker.Value);
              sqlCom.Parameters.AddWithValue("targy", targyTextBox.Text);
              sqlCom.Parameters.AddWithValue("leiras", leirasTextBox.Text);
              sqlCom.Parameters.AddWithValue("user", Convert.ToInt32(id_userComboBox.SelectedValue));

                try
                {
                    // Felvitel a táblába
                    sqlCom.ExecuteNonQuery();
                    MessageBox.Show("Rekord felvitele sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }

            // Beviteli mezők törlése
            clearfields();



        }

        private void clearfields()
        {
            //Beviteli mezők kiürítése      
            targyTextBox.Text = String.Empty;
            leirasTextBox.Text = String.Empty;
        }

        private void iktatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConn.Close();
        }

        private void lettersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lettersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktato2LevelekDS);

        }

        private void lettersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lettersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktato2LevelekDS);

        }
    }

        
    
}

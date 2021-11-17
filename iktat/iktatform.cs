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
        //private string letterInstert = "letterInstert";
        public string insert = "INSERT INTO letters (erkezett, targy, leiras, id_user) VALUES (@erkezett, @targy, @leiras, @user) RETURN 0";


        public iktatform()
        {
            InitializeComponent();
        }

        private void iktatform_Load(object sender, EventArgs e)
        {
            sqlConnect();


            
        }

        private void sqlConnect()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "(localdb)\\MSSQlLocalDB";
            sb.InitialCatalog = "iktat";

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

        /*
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

        private void insertletter()
        {
            using (SqlCommand sqlCom = new SqlCommand(insert, sqlConn))
            {
                // JAVíTANI !!!!!!!!!!!!
                //sqlCom.Parameters.AddWithValue("erkezett", dtpErkezett.Value);
               // sqlCom.Parameters.AddWithValue("targy", tbxTargy.Text);
                //sqlCom.Parameters.AddWithValue("leiras", rtbleiras.Text);
               // sqlCom.Parameters.AddWithValue("user", cbxCimzett.SelectedValue);

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
            //Beviteli mezők kiürítése      JAVÍTANI
           // tbxTargy.Text = String.Empty;
           // rtbleiras.Text = String.Empty;
        }

        private void iktatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConn.Close();
        }
    }

        
    
}

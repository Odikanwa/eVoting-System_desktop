using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E_voting_Nigeria
{
    /// <summary>
    /// Interaction logic for RegisterElection_page.xaml
    /// </summary>
    public partial class RegisterElection_page : Page
    {
        public RegisterElection_page()
        {
            InitializeComponent();
        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        private void create_election_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (election_name.Text == "" || election_description.Text == "" || election_date.Text == "")
                {
                    MessageBox.Show("Unable to Register Election! Please fill all fields");
                }
                else
                {
                    db_connection.Open();
                    DateTime Today = DateTime.Today;
                    string query = " INSERT INTO registerElection(Date_Registered, Election_Name, Election_Description, Election_Date)" +
                        " values ('" + Today + "','" + election_name.Text + "','" + election_description.Text + "','" + election_date.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, db_connection);
                    sqlCommand.ExecuteNonQuery();
                    db_connection.Close();



                    MessageBox.Show("New Election Registered Sucessfully! Countdown already Initiated");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db_connection.Close();
            }
        }

        private void ClearFields()
        {
            election_name.Text = election_description.Text = election_date.Text = " ";
        }
    }
}

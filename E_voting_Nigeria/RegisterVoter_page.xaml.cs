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
    /// Interaction logic for RegisterVoter_page.xaml
    /// </summary>
    public partial class RegisterVoter_page : Page
    {
        public RegisterVoter_page()
        {
            InitializeComponent();
        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        private void Register_voter_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (first_name.Text == "" || last_name.Text == "" || dob.Text == "" || perm_address.Text == "" || lga.Text == "" || soo.Text == "" || nationality.Text == "" || phone_no.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Unable to Register Voter! Please fill all fields");
                }
                else
                {
                    db_connection.Open();
                    DateTime Today = DateTime.Today;
                    string query = " INSERT INTO registerVoter(First_Name, Last_Name, Date_of_Birth, Perm_Address, LGA_of_Origin, State_of_Origin, Nationality, Phone_number, Email, Date_Registered)" +
                        " values ('" + first_name.Text + "', '" + last_name.Text + "', '" + dob.Text + "', '" + perm_address.Text + "', '" + lga.Text + "', '" + soo.Text + "', '" + nationality.Text + "', '" + phone_no.Text + "', '" + email.Text + "', '" + Today + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, db_connection);
                    sqlCommand.ExecuteNonQuery();
                    db_connection.Close();



                    MessageBox.Show("New Voter Registered Sucessfully! All Voter Priviledges granted");
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
            first_name.Text = last_name.Text = dob.Text =  perm_address.Text = lga.Text = soo.Text = nationality.Text = phone_no.Text = email.Text = " " ;
        }
    }

}


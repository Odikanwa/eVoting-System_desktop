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
    /// Interaction logic for RegisterParty_page.xaml
    /// </summary>
    public partial class RegisterParty_page : Page
    {
        public RegisterParty_page()
        {
            InitializeComponent();
        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        private void Enroll_party_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (party_name.Text == "" || party_abbreviation.Text == "" || head_office.Text == "" || party_slogan.Text == "" || party_mission.Text == "" || party_vision.Text == "")
                {
                    MessageBox.Show("Unable to Enroll Party! Please fill all fields");
                }
                else
                {
                    db_connection.Open();
                    DateTime Today = DateTime.Today;
                    string query = " INSERT INTO registerParty(Party_Name, Party_Abbreviation, Head_Office, Party_Slogan, Party_Mission, Party_Vision, Date_Registered)" +
                        " values ('" + party_name.Text + "','" + party_abbreviation.Text + "','" + head_office.Text + "','" + party_slogan.Text + "', '" + party_mission.Text + "','" + party_vision.Text + "', '" + Today + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, db_connection);
                    sqlCommand.ExecuteNonQuery();
                    db_connection.Close();



                    MessageBox.Show("New Party Enrolled Sucessfully! All Party Regulations Apply");
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
            party_name.Text = party_abbreviation.Text = head_office.Text = party_slogan.Text = party_mission.Text = party_vision.Text = " ";
        }
    }
}

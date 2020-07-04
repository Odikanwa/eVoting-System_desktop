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
    /// Interaction logic for RegisterCandidate_page2.xaml
    /// </summary>
    public partial class RegisterCandidate_page2 : Page
    {

        public RegisterCandidate_page2()
        {
            InitializeComponent();
        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        private void register_candidate_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (first_name.Text == "" || last_name.Text == "" || party_list.Text == "" || offices_list.Text == "")
                {
                    MessageBox.Show("Unable to register! Please fill all fields");
                }
                else
                {
                    db_connection.Open();
                    DateTime Today = DateTime.Today;
                    string query = " INSERT INTO registerCandidate(First_Name, Last_Name, Party, Office, Created_on)" +
                        " values ('" + first_name.Text + "','" + last_name.Text + "','" + party_list.Text + "','" + offices_list.Text + "', '" + Today + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, db_connection);
                    sqlCommand.ExecuteNonQuery();
                    db_connection.Close();



                    MessageBox.Show("New Candidate Registered Sucessfully! All Candidates Priviledges granted");
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
            first_name.Text = last_name.Text = party_list.Text = offices_list.Text = " ";
        }



        public class Display : RegisterCandidate_page2
        {


            ///SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");


            public void Delete_Candidates()
            {

                try
                {
                    db_connection.Open();

                    string query = "DELETE FROM registerCandidate where First_Name = '" + first_name.Text + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    db_connection.Close();

                    MessageBox.Show("Candidate Deleted Successfully!");

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
        }
    }
}

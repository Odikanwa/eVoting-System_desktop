using E_voting_Nigeria;
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
    /// Interaction logic for ViewCandidates_page.xaml
    /// </summary>
    public partial class ViewCandidates_page : Page
    {
        //RegisterCandidate_page2 registerCandidate_Page2 = null;
        //private E_voting_Nigeria.RegisterCandidate_page2 registerCandidate_Page2 = new E_voting_Nigeria.RegisterCandidate_page2();
        RegisterCandidate_page2.Display display = new RegisterCandidate_page2.Display();
        public ViewCandidates_page()
        {
            // Initialize all important objects

            InitializeComponent();
            DisplayCandidates_DB();


            //RegisterCandidate_page2 registerCandidate_Page2 = new RegisterCandidate_page2();
            //registerCandidate_Page2 = delete;
            //registerCandidate_Page2 = delete;



        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");


        private void DisplayCandidates_DB()
        {


            db_connection.Open();
            DateTime Today = DateTime.Today;
            string query = "Select * from registerCandidate";
            SqlCommand sqlCommand = new SqlCommand(query, db_connection);
            sqlCommand.ExecuteNonQuery();

            DataTable candidates_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(candidates_table);

            ViewCandidates_page_datagrid.ItemsSource = candidates_table.DefaultView;
            db_connection.Close();
        }

        //public class DisplayCandidates : ViewCandidates_page
       // {


            private void Delete_button_Click(object sender, RoutedEventArgs e)
            {

                //db_connection.Open();
                RegisterCandidate_page2.Display display = new RegisterCandidate_page2.Display();
                display.Delete_Candidates();
                
                //RegisterCandidate_page2 registerCandidate_Page2 = new RegisterCandidate_page2();
                // registerCandidate_Page2 = null;
                //registerCandidate_Page2.Delete_Candidates();
            }
       // }
    }
}              //  db_connection.Close();
            
                //string first_name = null;
                //string last_name = null;
                //string party_list = null;
                //string offices_list = null;
                //string id = null;
                //registerCandidate_Page2.first_name.Text = first_name;
                //registerCandidate_Page2.last_name.Text = last_name;
                //registerCandidate_Page2.party_list.Text = party_list;
                //registerCandidate_Page2.offices_list.Text = offices_list;

            //db_connection.Open();


            //string query = "DELETE FROM registerCandidate where First_Name = '" + first_name + "'";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, db_connection);
            ////SqlCommand sqlCommand = new SqlCommand(query, db_connection);
            //// sqlCommand.ExecuteNonQuery();
            //sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            //db_connection.Close();

            //MessageBox.Show("Candidate Deleted Successfully!");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    db_connection.Close();
            //}
            //DisplayData();
            //ClearData();

        
        //}
        //private void Update_button_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {


        //    RegisterCandidate_page2 registerCandidate_Page2 = new RegisterCandidate_page2();
        //    string first_name = null;
        //    string last_name = null;
        //    string party_list = null;
        //    string offices_list = null;
        //    string ID = null;
        //    registerCandidate_Page2.first_name.Text = first_name; 
        //    registerCandidate_Page2.last_name.Text = last_name;
        //    registerCandidate_Page2.party_list.Text = party_list;
        //    registerCandidate_Page2.offices_list.Text = offices_list;
        //    db_connection.Open();

        //    string query = "Update registerCandidate  First_Name='" + first_name + "',Last_Name='" + last_name + "',Party='" + party_list + "',Office='" + offices_list + "' where id=" + ID + "";
        //    SqlCommand sqlCommand = new SqlCommand(query, db_connection);
        //    sqlCommand.ExecuteNonQuery();
        //    db_connection.Close();

        //    MessageBox.Show("Party Successfully Updated!");
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        db_connection.Close();
        //    }

        //}
        //First_Name, Last_Name, Party, Office, Created_on)"

        //first_name.Text + "','" + last_name.Text + "','" + party_list.Text + "','" + offices_list.Text + "', '" + Today + "')";
        //    else
        //    {
        //        MessageBox.Show("Please Select Party to Edit");
        //    }
        //}

        //private void delete_button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ID != 0)
        //    {

        //        db_connection.Open();
        //        sql_command.CommandText = "Delete from parties where id= '" + ID + "'";
        //        sql_command.ExecuteNonQuery();
        //        db_connection.Close();

        //        MessageBox.Show("Party Deleted Successfully!");
        //        DisplayData();
        //        ClearData();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select Party to Delete");
        //    }
        //}


        //private void certify_button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ID != 0 && !(party_name.Text == "" || party_slogan.Text == "") && !(party_vision.Text == "" || party_mission.Text == ""))
        //    {
        //        //I am using another method to access the db
        //        SqlCommand cmd = new SqlCommand(" Update parties set certified = '1' where id = @ID", db_connection);
        //        db_connection.Open();
        //        cmd.Parameters.AddWithValue("@ID", ID);
        //        cmd.ExecuteNonQuery();
        //        db_connection.Close();

        //        MessageBox.Show("Party Certified For Election");

        //        DisplayData();
        //        ClearData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select Record to Update");
        //    }
        //}

        //private void uncertify_button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ID != 0 && !(party_name.Text == "" || party_slogan.Text == "") && !(party_vision.Text == "" || party_mission.Text == ""))
        //    {
        //        //I am using another method to access the db
        //        SqlCommand cmd = new SqlCommand(" Update parties set certified = '0' where id = @ID", db_connection);
        //        db_connection.Open();
        //        cmd.Parameters.AddWithValue("@ID", ID);
        //        cmd.ExecuteNonQuery();
        //        db_connection.Close();

        //        MessageBox.Show("Party UnCertified For Election");

        //        DisplayData();
        //        ClearData();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select Record to Update");
        //    }


    

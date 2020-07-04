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
    /// Interaction logic for viewUsers_page.xaml
    /// </summary>
    public partial class viewUsers_page : Page
    {
        public viewUsers_page()
        {
            InitializeComponent();
            DisplayAdmins_DB();
        }


        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");
        
        //display Admins table from database when View Admins is clicked on SuperAdminDashboard
        private void DisplayAdmins_DB()
        {           
            db_connection.Open();
            DateTime Today = DateTime.Today;
            string query = "Select * From registerAdmin";
            SqlCommand sqlCommand = new SqlCommand(query, db_connection);
            sqlCommand.ExecuteNonQuery();

            DataTable Admins_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(Admins_table);

            ViewAdmins_page_datagrid.ItemsSource = Admins_table.DefaultView;
            db_connection.Close();
        }

        private void Active_users_button_Click(object sender, RoutedEventArgs e)
        {

            // Find the frame.
            Frame pageFrame = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(this);
            while (currParent != null && pageFrame == null)
            {
                pageFrame = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            // Change the page of the frame.
            if (pageFrame != null)
            {
                pageFrame.Source = new Uri("ViewUsers_page.xaml", UriKind.Relative);
            }
        }

        

        //private void edit_button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ID != 0 && !(party_name.Text == "" || party_slogan.Text == "") && !(party_vision.Text == "" || party_mission.Text == ""))
        //    {
        //        db_connection.Open();
        //        sql_command.CommandText = "Update parties SET party_name='" + party_name.Text + "',party_slogan='" + party_slogan.Text + "',party_vision='" + party_vision.Text + "',party_mission='" + party_mission.Text + "' where id=" + ID + "";
        //        sql_command.ExecuteNonQuery();
        //        db_connection.Close();

        //        MessageBox.Show("Party successfully updated");

        //        DisplayData();
        //        ClearData();
        //    }
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

        }
    
}

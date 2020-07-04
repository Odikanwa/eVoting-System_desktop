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
    /// Interaction logic for ViewUsers_page.xaml
    /// </summary>
    public partial class ViewUsers_page : Page
    {
        public ViewUsers_page()
        {
            InitializeComponent();
            DisplayUsers_DB();
        }
        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        //display Admins table from database when View Admins is clicked on SuperAdminDashboard
        private void DisplayUsers_DB()
        {
            db_connection.Open();
            DateTime Today = DateTime.Today;
            string query = "Select * From users";
            SqlCommand sqlCommand = new SqlCommand(query, db_connection);
            sqlCommand.ExecuteNonQuery();

            DataTable users_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(users_table);

            ViewUsers_page_datagrid.ItemsSource = users_table.DefaultView;
            db_connection.Close();
        }
    }
}

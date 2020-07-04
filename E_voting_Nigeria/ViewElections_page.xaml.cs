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
    /// Interaction logic for ViewElections_page.xaml
    /// </summary>
    public partial class ViewElections_page : Page
    {
        public ViewElections_page()
        {
            InitializeComponent();
            DisplayElections_DB();
        }

        SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");

        //display Admins table from database when View Admins is clicked on SuperAdminDashboard
        private void DisplayElections_DB()
        {
            db_connection.Open();
            DateTime Today = DateTime.Today;
            string query = "Select * From registerElection";
            SqlCommand sqlCommand = new SqlCommand(query, db_connection);
            sqlCommand.ExecuteNonQuery();

            DataTable Elections_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.Fill(Elections_table);

            ViewElections_page_datagrid.ItemsSource = Elections_table.DefaultView;
            db_connection.Close();
        }
    }
}


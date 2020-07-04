using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace E_voting_Nigeria
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Home_screen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            
        }

        private void Sign_in_as_SuperAdmin_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminLogin superAdminLogin = new SuperAdminLogin();
            superAdminLogin.Show();
            this.Close();
            
        }

        private void Authenticate_admin_Click(object sender, RoutedEventArgs e)
        {
            //Create connection to the database
            SqlConnection db_connection = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");
            try
            {
                if (db_connection.State == ConnectionState.Closed)
                    db_connection.Open();
                string query = "SELECT COUNT(1) FROM users WHERE UserName=@username AND Password=@password";
                SqlCommand sqlCommand = new SqlCommand(query, db_connection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Username", username.Text);
                sqlCommand.Parameters.AddWithValue("@Password", password.Text);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Unauthorized User! All Offenders are purnishable by law");
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
        
    }
}

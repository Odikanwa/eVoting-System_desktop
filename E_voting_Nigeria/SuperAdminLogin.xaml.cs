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
    /// Interaction logic for SuperAdminLogin.xaml
    /// </summary>
    public partial class SuperAdminLogin : Window
    {
        public SuperAdminLogin()
        {
            InitializeComponent();
        }
        private void Home_screen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            
        }
        private void Sign_in_as_Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();

        }

        private void Authenticate_superAdmin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-916AI4J\SQLEXPRESS;Initial Catalog=Nigeria_Evoting_System_DB;Integrated Security=True; MultipleActiveResultSets=true;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM users WHERE UserName=@username AND Password=@password";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Username", username.Text);
                sqlCommand.Parameters.AddWithValue("@Password", password.Text);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    SuperAdmin_Dashboard superAdmin_Dashboard = new SuperAdmin_Dashboard();
                    superAdmin_Dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unauthorized User! All Offenders are Purnishable by Law");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }


    }
}

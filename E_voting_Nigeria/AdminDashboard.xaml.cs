using System;
using System.Collections.Generic;
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
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void Logout_admin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Close();
            adminLogin.Show();
        }

        private void Register_voter_Click(object sender, RoutedEventArgs e)
        {


            AdminDashboard_frames.Content = new RegisterVoter_page();

            //RegisterVoter registerVoter = new RegisterVoter();
            //this.Close();

            //registerVoter.Show();
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            AdminDashboard_frames.Content = new AdminDashboard_mainPage();
        }
    }
}

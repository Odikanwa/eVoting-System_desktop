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
    /// Interaction logic for SuperAdmin_Dashboard.xaml
    /// </summary>
    public partial class SuperAdmin_Dashboard : Window
    {
        public SuperAdmin_Dashboard()
        {
            InitializeComponent();
        }

        private void Logout_SuperAdmin_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminLogin superAdminLogin = new SuperAdminLogin();
            this.Close();
            superAdminLogin.Show();
        }

        private void Create_admin_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminDashboard_frames.Content = new RegisterAdmin_page();

        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminDashboard_frames.Content = new SuperAdminDashboard_mainPage();
        }

        private void Register_candidate_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminDashboard_frames.Content = new RegisterCandidate_page1();
        }

        private void Register_party_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminDashboard_frames.Content = new RegisterParty_page();
        }

        private void Create_election_Click(object sender, RoutedEventArgs e)
        {
            SuperAdminDashboard_frames.Content = new RegisterElection_page();
        }
    }
}

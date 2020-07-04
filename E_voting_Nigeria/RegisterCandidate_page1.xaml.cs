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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E_voting_Nigeria
{
    /// <summary>
    /// Interaction logic for RegisterCandidate_page1.xaml
    /// </summary>
    public partial class RegisterCandidate_page1 : Page
    {
        public RegisterCandidate_page1()
        {
            InitializeComponent();
        }

        private void Verify_candidate_Click(object sender, RoutedEventArgs e)
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
                pageFrame.Source = new Uri("RegisterCandidate_page2.xaml", UriKind.Relative);
            }
        }
    }
}

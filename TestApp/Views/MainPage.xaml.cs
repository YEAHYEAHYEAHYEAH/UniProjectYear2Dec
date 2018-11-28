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
using TrainFinder.DataLayer;
using TrainFinder.Models;
using TrainFinder.Services;

namespace TrainFinder.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private NavigationService navigation;

        public MainPage()
        {
            InitializeComponent();
        }

        private void adminMode_Click(object sender, RoutedEventArgs e)
        {
            navigation = NavigationService.GetNavigationService(this);
            navigation.Navigate(TrainFinderNavigation.Instance.GetAdminPage());
        }

        private void userMode_Click(object sender, RoutedEventArgs e)
        {
            navigation = NavigationService.GetNavigationService(this);
            navigation.Navigate(TrainFinderNavigation.Instance.GetUserPage());
        }
    }
}

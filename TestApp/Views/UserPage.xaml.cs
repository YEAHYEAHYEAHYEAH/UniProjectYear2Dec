using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TrainFinder.Services;

namespace TrainFinder.Views
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private NavigationService navigation;

        public UserPage()
        {
            InitializeComponent();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            string bestValue = closestPossibleString(((TextBox)sender).Text);
            ((TextBox)sender).Text = bestValue;
        }

        private string closestPossibleString(string input)
        {
            int lowestValue = 99999999;
            IReadOnlyCollection<string> stations = new List<string>() {"test"};
            string closestValue = stations.First();

            foreach (string possibleString in stations)
            {
                int value = LevenshteinDistance.Calculate(input, possibleString);
                if (value < lowestValue)
                {
                    lowestValue = value;
                    closestValue = possibleString;
                }
            }
            return closestValue;
        }

        private void searchTrainsButton_Click(object sender, RoutedEventArgs e)
        {
            navigation = NavigationService.GetNavigationService(this);
            navigation.Navigate(TrainFinderNavigation.Instance.GetTrainsPage());
        }
    }
}

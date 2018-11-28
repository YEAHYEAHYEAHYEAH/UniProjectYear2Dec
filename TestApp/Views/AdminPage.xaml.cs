using System;
using System.Windows;
using System.Windows.Controls;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;
using TrainFinder.Services;
/* * */


namespace TrainFinder.Views
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.BottomRight,
                offsetX: 20,
                offsetY: 0);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });
        public AdminPage()
        {
            InitializeComponent();
        }

        private void testDataButton_Click(object sender, RoutedEventArgs e)
        {
            notifier.ShowSuccess("Successfully created test data.");
        }

        private void createTrainButton_Click(object sender, RoutedEventArgs e)
        {
            notifier.ShowSuccess("Successfully created train.");
        }

        private void createPassengerButton_Click(object sender, RoutedEventArgs e)
        {
            notifier.ShowSuccess("Successfully created passenger.");
        }
    }
}

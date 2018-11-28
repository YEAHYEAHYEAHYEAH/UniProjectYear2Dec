using System;
using System.Windows.Navigation;
using TrainFinder.Views;

namespace TrainFinder.Services
{
    public class TrainFinderNavigation
    {
        private static TrainFinderNavigation instance;
        private SeatingPage seatingPage;
        private TrainsPage trainsPage;
        private AdminPage adminPage;
        private UserPage userPage;
        private NavigationService navigationService;

        private TrainFinderNavigation()
        {
            seatingPage = new SeatingPage();
            trainsPage = new TrainsPage();
            adminPage = new AdminPage();
            userPage = new UserPage();
        }

        public static TrainFinderNavigation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrainFinderNavigation();
                }
                return instance;
            }
        }

        public TrainsPage GetTrainsPage()
        {
            return instance.trainsPage;
        }

        public SeatingPage GetSeatingPage()
        {
            return instance.seatingPage;
        }

        public AdminPage GetAdminPage()
        {
            return instance.adminPage;
        }

        public UserPage GetUserPage()
        {
            return instance.userPage;
        }
    }
}
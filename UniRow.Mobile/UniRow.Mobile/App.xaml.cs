using System;
using UniRow.Library.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniRow.Mobile
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public static UserModel User;
        public static void SetUser(UserModel profile)
        {
            User = profile;
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new ProfilePage());
            //MainPage = new NavigationPage(new AddTrainingLog());
        }
        public App(string DBConnection)
        {
            InitializeComponent();
            DatabaseLocation = DBConnection;
            MainPage = new NavigationPage(new LoginPage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

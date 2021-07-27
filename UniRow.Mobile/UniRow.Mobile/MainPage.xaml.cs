using System;
using UniRow.Library;
using Xamarin.Forms;
using XamarinPlatform;

namespace UniRow.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolBox_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new C2Calculators());
        }

        private void TrainingLogAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrainingLog()) ;
        }

        private void Users_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsersPage());
        }
    }
}

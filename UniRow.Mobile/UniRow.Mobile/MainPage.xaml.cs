using System;
using UniRow.Library;
using Xamarin.Forms;

namespace UniRow.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new C2Calculators());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniRow.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateNewUser : ContentPage
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
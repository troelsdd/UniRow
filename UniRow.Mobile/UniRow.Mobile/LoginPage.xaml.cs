using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRow.Library.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniRow.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CreateUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateNewUser());
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(LoginName.Text);
            if (isEmailEmpty == false)
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<UserModel>();
                    var users = conn.Table<UserModel>().ToList();

                    var user = (from u in users
                                where (u.Email == LoginName.Text.Trim())
                                select u).ToList();
                    UserModel profile = new UserModel();
                    foreach (UserModel u in user)
                    {
                        profile = u;
                    }
                    //var user = users.Where(x => x.Email == LoginName.Text).ToList();
                    if (!(user.Count() > 1) && user.Count() > 0 & profile != null)
                    {
                        DisplayAlert("Access granted!", "User logged in succesfully", "Ok");
                        App.SetUser(profile);
                        Navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        DisplayAlert("Access Denied!", "User failed to login", "Ok");
                    }

                    //var user = users.Where(x => x.Email == LoginName.Text).ToList();
                }
            }
            else
            {
                DisplayAlert("Failure", "It appears no login information was provided?", "ok");
                //Navigation.PushAsync(new MainPage());
            }
        }
    }
}
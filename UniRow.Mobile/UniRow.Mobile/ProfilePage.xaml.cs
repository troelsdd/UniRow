using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRow.Library.Models;
using UniRow.Mobile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        UserModel profile;
        public ProfilePage()
        {
            InitializeComponent();
        }
        public ProfilePage(UserModel profile, bool visible)
        {
            InitializeComponent();

            this.profile = profile;
            Id.Text = profile.Id.ToString();
            Email.Text = profile.Email;
            FirstName.Text = profile.Firstname;
            LastName.Text = profile.Lastname;
            Address.Text = profile.Address;
            Zip.Text = profile.Postalcode.ToString();
            City.Text = profile.City;
            Country.Text = profile.Country;
            Phonenumber.Text = profile.PhoneNumber;
            if(profile.Gender == "Female")
            {
                Female.IsChecked = true;
            }
            else if (profile.Gender == "Male")
            {
                Male.IsChecked = true;
            }
            Birthday.Date = profile.Birthday;



        }
        private void UpdateUserinfo_Clicked(object sender, EventArgs e)
        {
            if (DeleteUser.IsChecked == true)
            { //Sakset fra stackoverflow
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Bekræftelse", "Er du sikker på du vil slette brugeren?", "Ja!", "Nej!");

                    if (result)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                        {
                            conn.Delete(profile);
                        }
                        //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow(); // Or anything else
                        //EndSaks
                        await Navigation.PopAsync();
                    }

                });

            }
            else if (DeleteUser.IsChecked == false)
            {
                profile.Firstname = FirstName.Text;
                profile.Lastname = LastName.Text;
                profile.Address = Address.Text;
                profile.Postalcode = int.Parse(Zip.Text);
                profile.City = City.Text;
                profile.Country = Country.Text;
                profile.PhoneNumber = Phonenumber.Text;
                profile.Birthday = Birthday.Date;
                if (Female.IsChecked)
                {
                    profile.Gender = "Female";
                }
                else if (Male.IsChecked)
                {
                    profile.Gender = "Male";
                }
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.Update(profile);
                }
                Navigation.PopAsync();
            }
        }
    }
}
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
    public partial class CreateNewUser : ContentPage
    {

        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Clicked(object sender, EventArgs e)
        {
            UserModel newuser = new UserModel();
            List<string> flag = new List<string>();

            if (!string.IsNullOrEmpty(email.Text) && email.Text.Contains("@"))
            {
                newuser.Username = email.Text;
            }
            else { flag.Add("Username invalid"); }
            if (!string.IsNullOrEmpty(firstName.Text))
            {
                newuser.Firstname = firstName.Text;
            }
            else { flag.Add("Firstname invalid"); }
            if (!string.IsNullOrEmpty(lastName.Text))
            {
                newuser.Lastname = lastName.Text;
            }
            else { flag.Add("Lastname invalid"); }
            if (!string.IsNullOrEmpty(address.Text))
            {
                newuser.Address = address.Text;
            }
            else { flag.Add("Address invalid"); }
            if (!string.IsNullOrEmpty(zip.Text))
            {
                newuser.Postalcode = int.Parse(zip.Text);
            }
            else { flag.Add("Zip invalid"); }
            if (!string.IsNullOrEmpty(city.Text))
            {
                newuser.City = city.Text;
            }
            else { flag.Add("City invalid"); }

            newuser.Country = CountrySelector.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(phonenumber.Text))
            {
                newuser.PhoneNumber = phonenumber.Text;
            }
            else { flag.Add("Phonenumber invalid"); }
            newuser.Accesright = "Rower";
            if (!string.IsNullOrEmpty(email.Text) && email.Text.Contains("@"))
            {
                newuser.Email = email.Text;
            }
            else { flag.Add("Email invalid"); }
            if (Female.IsChecked)
            {
                newuser.Gender = "Female";
            }
            else if (Male.IsChecked)
            {
                newuser.Gender = "Male";
            }
            newuser.Enrollment = DateTime.Now;
            if (flag.Count > 0)
            {
                string message = "Kan ikke oprette bruger grundet disse fejl \n\n";
                foreach (var error in flag)
                {
                    message += error;
                    message += "\n";
                }
                DisplayAlert("Fejl!", message, "ok");
            }
            else if (flag.Count == 0)
            {
                /**           if(flag.Count > 0) {
                               string msg = "Errorlist:\n\n";
                               foreach (var flags in flag)
                               {
                                    msg += "\n" + flags;
                               }
                               DisplayAlert("Errorlist", msg, "ok");
                           }
                
                           else { 

                           string msg = @"" +
                               "\nUsername: " + user.Username +
                               "\nPassword: " + user.Password +
                               "\nFirstname: " + user.Firstname +
                               "\nLastname: " + user.Lastname +
                               "\nAddress: " + user.Address +
                               "\nPostalcode: " + user.Postalcode +
                               "\nCity: " + user.City +
                               "\nCountry: " + user.Country +
                               "\nGender: " + user.Gender +
                               "\nPhonenumber: " + user.PhoneNumber +
                               "\nEmail: " + user.Email +
                               "\nDate of user creation: " + user.Enrollment +
                           "";
                           DisplayAlert("Tranfered Data", msg, "ok");
                           Navigation.PopAsync();
                           }
                **/
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {

                    conn.CreateTable<UserModel>();
                    int rows = conn.Insert(newuser);

                    if (rows > 0)
                    {
                        DisplayAlert("Bruger oprettet:", "Brugeren blev oprettet. Du kan nu logge ind", "ok");
                        Navigation.PopAsync();
                    }
                }

            }
            else
            {
                DisplayAlert("Fejl i brugeroprettelsen!", "Der skete desværre en fejl. Kontakt venligst troels@aalborgroklub.dk for hjælp!", "ok");
            }
        }
    }
}
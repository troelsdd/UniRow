
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
    public partial class UsersPage : ContentPage
    {
        public UsersPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<UserModel>();
                var users = conn.Table<UserModel>().ToList();
                Userlist.ItemsSource = users;
            }
        }
        private void LstOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Userlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            var ItemTapped = e.Item as UserModel;
            if (ItemTapped != null)
            {
                Navigation.PushAsync(new ProfilePage(ItemTapped, true));
            }
            

        }
    }
}
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRow.Library.Models.Logmonitor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniRow.Mobile.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoggedExercises : ContentPage
    {
        public LoggedExercises()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<CustomLog>();
                var logentries = conn.Table<CustomLog>().ToList();

                var loggedentries = (from l in logentries
                            where l.UserId == App.User.Id
                            select l).ToList();
                Loglist.ItemsSource = loggedentries;
            }
        }
    }
}


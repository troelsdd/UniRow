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
    public partial class AddTrainingLog : ContentPage
    {

        public AddTrainingLog()
        {
            InitializeComponent();
        }

        private void AddTrainingLog_Clicked(object sender, EventArgs e)
        {
            CustomLog newLog = new CustomLog();
            newLog.UserId = App.User.Id;
            newLog.LogDate = LogDate.Date;
            newLog.Category = CategoryTypePicker.SelectedItem.ToString();
            newLog.Activity = Activity.Text;
            newLog.count = int.Parse(Bouts.Text);
            newLog.ActivityTime = TimeSpan.Parse(Duration.Text);
            newLog.PhysicalExperience = PhysicalExperiencePicker.SelectedItem.ToString();
            newLog.PsysicalExperience = PsysicalExperiencePicker.SelectedItem.ToString();
            newLog.Comments = Comment.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {

                conn.CreateTable<CustomLog>();
                int rows = conn.Insert(newLog);

                if (rows > 0)
                {
                    DisplayAlert("Træningspas tilføjet!", "Træningspasset blev tilføjet loggen!", "ok");
                    Navigation.PopAsync();
                }
            }
            // int ID = App.User.Id;
            // DisplayAlert("" + ID, "This is the id of the user: " + ID, "ok");
            // Navigation.PopAsync();
        }
    }
}
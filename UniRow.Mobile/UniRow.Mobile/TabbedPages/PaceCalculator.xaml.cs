using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRow.Library.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniRow.Mobile.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaceCalculator : ContentPage
    {
        C2Calculations Calc = new C2Calculations();
        private bool bike;
        public PaceCalculator()
        {
            bike = false;
            InitializeComponent();
            
        }
        //TODO LORTET VIRKER IKKE. EnTEN ER DEN HELT GAL HER ELLER OGSÅ I C2Calculations!!!
        private void CalculateTime_Clicked(object sender, EventArgs e) // DEn her er faulty
        {
            int Distance = 0;
            TimeSpan SplitTime = new TimeSpan();
            if (!string.IsNullOrWhiteSpace(MinuteValueSplit.Text))
            {
                SplitTime += TimeSpan.FromMinutes(double.Parse(MinuteValueSplit.Text));
            }
            else
            {
                MinuteValueTotaltime.Text = "0";
            }
            if (!string.IsNullOrWhiteSpace(SecondsValueSplit.Text))
            {
                SplitTime += TimeSpan.FromSeconds(double.Parse(SecondsValueSplit.Text));
            }
            else { SecondsValueTotaltime.Text = "0"; }
            if (string.IsNullOrWhiteSpace(SecondsValueSplit.Text) && string.IsNullOrWhiteSpace(MinuteValueSplit.Text))
            {
                SplitTime = TimeSpan.FromSeconds(0);
            }
            if (string.IsNullOrWhiteSpace(DistanceValue.Text))
            {
                DistanceValue.Text = "0";
                Distance = 0;
            }
            {
                Distance = int.Parse(DistanceValue.Text);
            }
            TimeSpan TotalTime = new TimeSpan();
            TotalTime = Calc.TotalTime(SplitTime, Distance, bike);
            MinuteValueTotaltime.Text = ((int)TotalTime.TotalMinutes).ToString();
            SecondsValueTotaltime.Text = (TotalTime.Seconds + "." + (TotalTime.Milliseconds) / 100).ToString();
            Console.WriteLine("Split before text: " + SplitTime + " TotalTime: " + TotalTime + " Distance: " + Distance);

        }

        private void CalculateSplit_Clicked(object sender, EventArgs e) //Virker/Virkede!
        {
            int Distance = 0;
            TimeSpan TotalTime = new TimeSpan();
            if (!string.IsNullOrWhiteSpace(MinuteValueTotaltime.Text))
            {
                TotalTime += TimeSpan.FromMinutes(double.Parse(MinuteValueTotaltime.Text));
            }
            else
            {
                MinuteValueTotaltime.Text = "0";
            }
            if (!string.IsNullOrWhiteSpace(SecondsValueTotaltime.Text))
            {
                TotalTime += TimeSpan.FromSeconds(double.Parse(SecondsValueTotaltime.Text));
            }
            else { SecondsValueTotaltime.Text = "0"; }
            if (string.IsNullOrWhiteSpace(SecondsValueTotaltime.Text) && string.IsNullOrWhiteSpace(MinuteValueTotaltime.Text))
            {
                TotalTime = TimeSpan.FromSeconds(0);
            }
            if (string.IsNullOrWhiteSpace(DistanceValue.Text))
            {
                DistanceValue.Text = "0";
                Distance = 0;
            }
            {
                Distance = int.Parse(DistanceValue.Text);
            }
            TimeSpan SplitTime = new TimeSpan();
            SplitTime = Calc.SplitTime(TotalTime, Distance, bike);
            MinuteValueSplit.Text = ((int)SplitTime.TotalMinutes).ToString();
            SecondsValueSplit.Text = (SplitTime.Seconds + "." + (SplitTime.Milliseconds)).ToString();
            Console.WriteLine("Split before text: " + SplitTime + " TotalTime: " + TotalTime + " Distance: " + Distance);
        }

        private void CalculateDistance_Clicked(object sender, EventArgs e)
        {
            TimeSpan SplitTime = new TimeSpan();
            TimeSpan TotalTime = new TimeSpan();
            if (!string.IsNullOrWhiteSpace(MinuteValueTotaltime.Text)){            
                TotalTime += TimeSpan.FromMinutes(double.Parse(MinuteValueTotaltime.Text));
            }
            else {
                MinuteValueTotaltime.Text = "0";
            } 
            if (!string.IsNullOrWhiteSpace(SecondsValueTotaltime.Text)) {
                TotalTime += TimeSpan.FromSeconds(double.Parse(SecondsValueTotaltime.Text));
            } 
            else { SecondsValueTotaltime.Text = "0"; }
            if (!string.IsNullOrWhiteSpace(MinuteValueSplit.Text)){
                SplitTime += TimeSpan.FromMinutes(double.Parse(MinuteValueSplit.Text));
            }
            else { MinuteValueSplit.Text = "0"; } 
            if (!string.IsNullOrWhiteSpace(SecondsValueSplit.Text)) {
                SplitTime += TimeSpan.FromSeconds(double.Parse(SecondsValueSplit.Text));
            } 
            else { SecondsValueSplit.Text = "0"; }
            if (string.IsNullOrWhiteSpace(SecondsValueSplit.Text) && string.IsNullOrWhiteSpace(MinuteValueSplit.Text))
            {
                SplitTime = TimeSpan.FromSeconds(0);
            }
            else if (string.IsNullOrWhiteSpace(SecondsValueTotaltime.Text) && string.IsNullOrWhiteSpace(MinuteValueTotaltime.Text))
            {
                TotalTime = TimeSpan.FromSeconds(0);
            }
                DistanceValue.Text = (Calc.Distance(TotalTime, SplitTime, bike)).ToString();
            Console.WriteLine("Split before text: " + SplitTime + " TotalTime: " + TotalTime + " Distance: " + Calc.Distance(TotalTime, SplitTime, bike));
        }

        private void Rower_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Rower.IsChecked)
            {
                bike = false;
                SplitLabel.Text = "500m Split:";
            }
            else if (BikeErg.IsChecked)
            {
                bike = true;
                SplitLabel.Text = "1000m Split:";
            }
        }
    }
}
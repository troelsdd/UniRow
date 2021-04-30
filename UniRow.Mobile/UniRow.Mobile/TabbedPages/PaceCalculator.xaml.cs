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
        TimeSpan TotalTime;
        TimeSpan SplitTime;
        public PaceCalculator()
        {
            bike = false;
            TotalTime = new TimeSpan();
            SplitTime = new TimeSpan();
            InitializeComponent();
            
        }

        private void CalculateTime_Clicked(object sender, EventArgs e) // DEn her er faulty
        {
            TotalTime = TimeSpan.Zero;
            SplitTime = TimeSpan.Zero;

            SplitTime = TimeSpan.FromMinutes(double.Parse(MinuteValueSplit.Text));
            SplitTime += TimeSpan.FromSeconds(double.Parse(SecondsValueSplit.Text));
            Console.WriteLine("TotalTime: " + TotalTime);
            //Console.WriteLine("Splittime: " + SplitTime);
            Console.WriteLine("TotalTimeMiliseconds: " + TotalTime.Milliseconds);
            int Distance = int.Parse(DistanceValue.Text);
            TotalTime = Calc.TotalTime(SplitTime.Minutes, SplitTime.Seconds, (SplitTime.Milliseconds / 100), Distance, bike);
            Console.WriteLine("Splittime: " + SplitTime);
            MinuteValueTotaltime.Text = TotalTime.Minutes.ToString();
            SecondsValueTotaltime.Text = (SplitTime.Seconds + "." + SplitTime.Milliseconds / 100);
        }

        private void CalculateSplit_Clicked(object sender, EventArgs e) //Virker/Virkede!
        {
            TotalTime = TimeSpan.Zero;
            SplitTime = TimeSpan.Zero;

            TotalTime = TimeSpan.FromMinutes(double.Parse(MinuteValueTotaltime.Text));
            TotalTime += TimeSpan.FromSeconds(double.Parse(SecondsValueTotaltime.Text));
            Console.WriteLine("TotalTime: " + TotalTime);
            Console.WriteLine("Splittime: " + SplitTime);
            Console.WriteLine("TotalTimeMiliseconds: " + TotalTime.Milliseconds);
            int Distance = int.Parse(DistanceValue.Text);
            SplitTime = Calc.AverageSplit(TotalTime.Minutes, TotalTime.Seconds, (TotalTime.Milliseconds/100), Distance, bike);
            Console.WriteLine("Splittime: " + SplitTime);
            MinuteValueSplit.Text = SplitTime.Minutes.ToString();
            SecondsValueSplit.Text = (SplitTime.Seconds + "." + SplitTime.Milliseconds / 100);
        }

        private void CalculateDistance_Clicked(object sender, EventArgs e)
        {
            TotalTime = TimeSpan.FromTicks(0);
            SplitTime = TimeSpan.FromTicks(0);

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
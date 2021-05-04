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
    public partial class WattCalculator : ContentPage
    {
        C2Calculations Calc = new C2Calculations();
        public WattCalculator()
        {
            InitializeComponent();
        }

        private void CalculatePace_Clicked(object sender, EventArgs e)
        {
            int precision = 1; //How many digits to a timespan I want
            const int TIMESPAN_SIZE = 7; //Timespan is always 7 digits!
            int factor = (int)Math.Pow(10, (TIMESPAN_SIZE - precision));
            int Watt = 0;
            //TimeSpan Split = new TimeSpan(((long)Math.Round((1.0 * Calc.WattCalc(double.Parse(WattValueInput.Text)).Ticks / factor)) * factor));

            //CalcWattValue.Text = Split.ToString(@"mm\:ss\.f");
            if (!string.IsNullOrWhiteSpace(WattValueInput.Text))
            {
                Watt = int.Parse(WattValueInput.Text);
            }
            else
            {
                WattValueInput.Text = "0";
            }

            TimeSpan Split = new TimeSpan(((long)Math.Round((1.0 * (Calc.Watt(Watt)).Ticks / factor)) * factor));
            CalcWattValue.Text = Split.ToString(@"mm\:ss\.f");


        }

        private void CalculateWatt_Clicked(object sender, EventArgs e)
        {
            TimeSpan PaceTime = new TimeSpan();
            // WattValueResult.Text = Calc.WattCalc(PaceTime);
            if (!string.IsNullOrWhiteSpace(MinValuePace.Text))
            {
                PaceTime += TimeSpan.FromMinutes(double.Parse(MinValuePace.Text));
            }
            else
            {
                MinValuePace.Text = "0";
            }
            if (!string.IsNullOrWhiteSpace(SecValuePace.Text))
            {
                PaceTime += TimeSpan.FromSeconds(double.Parse(SecValuePace.Text));
            }
            else { SecValuePace.Text = "0"; }

            WattValueResult.Text = (Calc.Watt(PaceTime)).ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Services
{
    //Distance Calc- DONE
    //AvgSplit Calc- DONE
    //TotalTIme Calc
    //Watt Calc- DONE
    //SplitFromWatt Calc - DONE
    public class C2Calculations
    {
        public double SplitDistance(bool bike)
        {
            double SplitDist = 500.0;
            if (bike)
            {
                SplitDist = 1000.0;
            }
            else if (!bike)
            {
                SplitDist = 500.0;
            }
            return SplitDist;
        }
        public double Distance(TimeSpan TotalTime, TimeSpan SplitTime, bool Bike)
        {
            //distance = (time/split) * 500;
            double SplitDist = SplitDistance(Bike);
            double Distance = (Math.Round((TotalTime.TotalSeconds / SplitTime.TotalSeconds) * SplitDist));
            return Distance;
        }
        public TimeSpan SplitTime(TimeSpan TotalTime, int Distance, bool Bike)
        {
            //split = 500 * (time/distance)
            double SplitDist = SplitDistance(Bike);
            TimeSpan SplitTime = new TimeSpan();
            SplitTime = TimeSpan.FromSeconds((SplitDist * (TotalTime.TotalSeconds / Distance)));
            return SplitTime;
        }
        public TimeSpan TotalTime(TimeSpan SplitTime, int Distance, bool Bike)
        {
            //time = split * (distance/500)
            double SplitDist = SplitDistance(Bike);
            TimeSpan TotalTime = new TimeSpan();
            TotalTime = TimeSpan.FromSeconds((SplitTime.TotalSeconds * (Distance / SplitDist)));
            return TotalTime;
        }
        public Double Watt (TimeSpan SplitTime)
        {
            //watts = 2.80/pace³
            double Watt = (Math.Round(2.80 / (Math.Pow((SplitTime.TotalSeconds / 500), 3)),1));
            return Watt;
        }
        public TimeSpan Watt(int Watt)
        {


            //pace = ³√(2.80/watts)
            TimeSpan Split = new TimeSpan();
            Split = TimeSpan.FromSeconds((Math.Pow(2.80 / Watt, 1.0 / 3.0))*500);
            return Split;
        }

    }
}

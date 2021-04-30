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
        double splitdistance = 500.0;
        /// <summary>
        /// Method to calculte the total distance from formula derived from the Concept2 website
        /// Formula: distance = (time/split) * 500
        /// </summary>
        /// <param name="Totaltime">The total time used on the erg. either as an result of a distance (2k) or a fixed time to row in.</param>
        /// <param name="Avgminutes">Avg split minutes</param>
        /// <param name="Avgseconds">Avg split seconds</param>
        /// <param name="Avgtenths">Avg split miliseconds</param>
        /// <returns></returns>
        public string Distance(int Totalminutes, int TotalSeconds, int TotalTenths, int Avgminutes, int AvgSeonds, int Avgtenths, bool bike)
        {
            if (bike == true)
            {
                splitdistance = 1000.0;
            }
            else if (bike == false)
            {
                splitdistance = 500.0;
            }
            TimeSpan TotalTime = new TimeSpan(0, 0, Totalminutes, TotalSeconds, TotalTenths * 100);
            TimeSpan AvgSplit = new TimeSpan(0, 0, Avgminutes, AvgSeonds, Avgtenths * 100);
            double Distance = ((TotalTime.TotalSeconds / AvgSplit.TotalSeconds) * splitdistance);
            return String.Format("{0:0}", Distance);
        }
        /// <summary>
        /// Method to calculate the overall avg. split from totaldistance and totaltime. Formula is derived from the Concept2 website
        /// Formula: split = 500 * (time/distance)
        /// </summary>        
        /// <param name="Totalminutes">Avg split minutes</param>
        /// <param name="Totalseconds">Avg split seconds</param>
        /// <param name="TotalDistance">The total distance in meters rowed as a result of the total time or the fixed distance (eg. 2k)</param>
        /// <returns></returns>
        public TimeSpan AverageSplit(int Totalminutes, int TotalSeconds, int TotalTenth, int TotalDistance, bool bike)
        {
            if (bike == true)
            {
                splitdistance = 1000.0;
            }
            else if (bike == false)
            {
                splitdistance = 500.0;
            }
            TimeSpan TotalTime = new TimeSpan(0, 0, Totalminutes, TotalSeconds, TotalTenth * 100);
            TimeSpan AverageSplit = new TimeSpan();

            AverageSplit = TimeSpan.FromSeconds((splitdistance * (TotalTime.TotalSeconds / TotalDistance)));
            return AverageSplit;
        }
        /// <summary>
        /// Method to calculate the overall avg. split from average watt. Formula is derived from the Concept2 website
        /// </summary>
        /// <param name="Watt">The average watt</param>
        /// <returns></returns>

        public string WattCalc(int Watt)
        {
            /*
            Formula: 
            pace = ³√(2.80/watts) & watts = 2.80/pace³
            where pace is time in seconds over distance in meters.
            For example: a 2:05/500m split = 125 seconds/500 meters or a 0.25 pace. Watts are then calculated
            as (2.80/0.25 ^ 3) or (2.80/0.015625), which equals 179.2.
            
            Psudocode: I know that:
            Pace = Split/500 eg. 2.00.0/500 <=> 120sec/500m <=> 0.24      PACE = 0.24 (Eksempel hvor split omregnes til pace
            Split = P*500 eg. Split = 0.24 * 500 <=> Split = 120 sec / 500 <=> 2.00.0/500m
            Therefore:
            eg. Pace = ³√(2.80/watts) <=> ³√(2.80/120) <=> Pace = 0.285754 so SPLIT = 0.285754 * 500 <=> 142.8s/500m <=> 2.22.9/500m
             */
            double pace; double split; TimeSpan AverageSplit = new TimeSpan();
            pace = Math.Pow(2.80 / Watt, 1.0 / 3.0);
            split = pace * 500;
            AverageSplit = TimeSpan.FromSeconds(split);
            Console.WriteLine(AverageSplit);
            //int Pace = (int)Math.Pow(2.80/Watt,3);
            //TimeSpan AverageSplit = (2.80 * (Math.Pow(Pace, (1.0 / 3.0))));
            //(timeSpan.Ticks).ToString("HH:mm");
            return AverageSplit.ToString(@"mm\:ss\.f");

        }
        /// <summary>
        /// Method to calculate the watt from formula derived from the concept 2 website
        /// Formula: watts = 2.8/(split/500)³
        /// </summary>
        /// <param name="Avgminutes">Avg split minutes</param>
        /// <param name="Avgseconds">Avg split seconds</param>
        /// <param name="Avgmiliseconds">Avg split miliseconds</param>
        /// <returns></returns>
        public string WattCalc(int Avgminutes, int Avgseconds, int Avgtenths)
        {
            int miliseconds = Avgtenths * 100;
            TimeSpan AverageSplit = new TimeSpan(0, 0, Avgminutes, Avgseconds, miliseconds);
            double Pace = (AverageSplit.TotalSeconds / 500);
            double Watt = (2.80 / (Math.Pow(Pace, 3)));

            return String.Format("{0:0.0}", Watt);
        }
        /// <summary>
        /// Method to calculate the overall total time from formula derived from the concept 2 website
        /// Formula: time = split * (distance/500)
        /// </summary>
        /// <param name="TotalDistance">The total distance in meters rowed as a result of the total time or the fixed distance (eg. 2k)</param>
        /// <param name="Avgminutes">Avg split minutes</param>
        /// <param name="Avgseconds">Avg split seconds</param>
        /// <param name="Avgtenths">Avg split .0</param>
        /// <returns></returns>
        public TimeSpan TotalTime(int Avgminutes, int Avgseconds, int Avgtenths, int TotalDistance, bool bike)
        {
            if (bike == true)
            {
                splitdistance = 1000.0;
            }
            else if (bike == false)
            {
                splitdistance = 500.0;
            }
            int sptdst = Convert.ToInt32(splitdistance);
            int miliseconds = Avgtenths * 100;
            TimeSpan AverageSplit = new TimeSpan(0, 0, Avgminutes, Avgseconds, miliseconds);
            long totalTicks = AverageSplit.Ticks * (TotalDistance / sptdst);
            TimeSpan TotalTime = new TimeSpan(totalTicks);
            return TotalTime;
        }
        /*
         The formulas used in this calculator are as follows:
        True Calories/hour burned = Calories on the PM - 300 + (1.714 * weight)
        Calorie burn for your workout = (True Calories/hour burned * duration in seconds)/3600
        */
        public int TrueCalc(int Calories, int Bodyweight)
        {
            return 0;
        }

    }
}

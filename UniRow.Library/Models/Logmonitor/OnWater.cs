using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    class OnWater : Logmonitor
    {
        /// <summary>
        /// Name of the boat which in which the trainingpiece were done
        /// </summary>
        public string BoatName { get; set; }
        public List<string> Crewmates { get; set; }
        /// <summary>
        /// Total amount of time during the trainingpiece
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Total amount of Kilomiters rowed during the trainingpiece
        /// </summary>
        public int KMRowed { get; set; }
        /// <summary>
        /// accumulated average of the strokerates during the pieces
        /// </summary>
        public int AverageStrokerate { get; set; }
        /// <summary>
        /// GPS Location data for GoogleMaps
        /// </summary>
        //public int[,] GoogleMaps {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models
{
    class ExerciseBoat : RowingBoat
    {
        /// <summary>
        /// Må båden bruges til langtur?
        /// </summary>
        public bool Longjourneyboat { get; set; }
        /// <summary>
        /// Er båden god til konkurrenceformål?
        /// </summary>
        public bool CompetitionBoat { get; set; }
    }
}

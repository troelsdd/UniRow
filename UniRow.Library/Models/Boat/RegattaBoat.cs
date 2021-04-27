using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models
{
    public struct Lightweightboat
    {
        const int mininumweight = 65;
        const int averageweight = 70;
        const int maxinumweight = 75;
    }
    public struct Mediumboat
    {
        const int mininumweight = 75;
        const int averageweight = 80;
        const int maxinumweight = 85;
    }
    public struct Heavyweightboat
    {
        const int mininumweight = 85;
        const int averageweight = 90;
        const int maxinumweight = 100;
    }
    class RegattaBoat : RowingBoat
    {        
        /// <summary>
        /// Letvægt, mediumvægt, eller tungvægtsbåd.
        /// </summary>
        //TODO Lav vægtklasserne "Letvægt", "medium" og "Heavyvægt" ala struct ovenfor til assignment af "Weightclass"
        public string Weightclass { get; set; }

    }
}

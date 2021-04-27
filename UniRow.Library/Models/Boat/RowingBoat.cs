using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models
{
    class RowingBoat : Boat
    {
        /// <summary>
        /// Whether the boat requires a cox or not
        /// </summary>
        public bool RequiresCox { get; set; }
        /// <summary>
        /// Hvor mange km en båd samlet har roet.
        /// </summary>
        public int KMSum { get; set; }
        /// <summary>
        /// Er det en 4x, 4- eller 8x?
        /// </summary>
        public string Boattype { get; set; }
        /// <summary>
        /// Er det en A, B, eller C båd? Klassificeringen af båd.
        /// </summary>
        public int Boatclass { get; set; }
    }
}

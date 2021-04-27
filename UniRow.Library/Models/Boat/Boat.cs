using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library
{
    public class Boat
    {
        /// <summary>
        /// ID nummeret som hver båd får når de bliver oprettet i systemet. Autogenereres
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Navn for båd for identifikation.
        /// </summary>
        public string BoatName { get; set; }
        /// <summary>
        /// Boughtdate bliver angivet når en båd oprettes i systemet.
        /// </summary>
        public DateTime BoughtDate { get; set; }
        /// <summary>
        /// Hvor mange sæder der er tilgængelige i båden.
        /// </summary>
        public int Numberofseats { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    class ErgRowing : Logmonitor
    {
        /// <summary>
        /// Which ergtype was the trainingpiece done on? Rowing Erg, BikeErg, or Ski-Erg?
        /// </summary>
        public string ErgType { get; set; }
        /// <summary>
        /// How long did each Bout take do do?
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// What was the dampersetting during the trainingPiece?
        /// </summary>
        public int DamperSetting { get; set; }
        /// <summary>
        /// What was the total amount of meters done during the trainingpiece?
        /// </summary>
        public int MeterSum { get; set; }
        /// <summary>
        /// What was the average watt of the trainingpiece?
        /// </summary>
        public int AverateWatt { get; set; }
        /// <summary>
        /// What was the Average Strokerate of the Training Piece.
        /// </summary>
        public int AverageStrokeRate { get; set; }
    }
}

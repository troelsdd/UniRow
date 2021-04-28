using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    class StrengthTraining : Logmonitor
    {
        /// <summary>
        /// How many repetitions do you do of each set(bout)
        /// </summary>
        public int Repetitions { get; set; }
        /// <summary>
        /// The weights used during the strength-training Session.
        /// </summary>
        public int WeightAmount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    class Alternative : Logmonitor 
    {
        /// <summary>
        /// Duration of the trainingpiece
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Description of the trainingpiece, and why it did not fit in the normal category
        /// </summary>
       public string Description { get; set; }
    }
}

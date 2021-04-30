using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.User
{
    class Boardmember : User
    {
        /// <summary>
        /// Which groups/settlements the boardmember in question got responsibility for.
        /// </summary>
        public List<string> Responsibilities { get; set; }
    }
}

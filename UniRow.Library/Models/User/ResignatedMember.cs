using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models
{
    class ResignatedMember : User
    {
        /// <summary>
        /// The date the member resignated from the club
        /// </summary>
        public DateTime Resignation { get; set; }
    }
}

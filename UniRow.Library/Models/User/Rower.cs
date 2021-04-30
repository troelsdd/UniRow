using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models
{
    class Rower : User
    {
        /// <summary>
        /// Which lockers do the rower have access to? // Keys
        /// </summary>
        public List<int> lockernumbers { get; set; }
        /// <summary>
        /// Which doorbrick does the rower use?
        /// </summary>
        public int Doorkeynumber { get; set; }
        /// <summary>
        /// Which social/training group does the rower belong to?
        /// </summary>
        public List<string> SocialGroup { get; set; }

    }
}

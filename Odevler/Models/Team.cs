using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odevler.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Symbol { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}

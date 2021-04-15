using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odevler.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}

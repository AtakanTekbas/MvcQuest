using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odevler.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Value { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }

    }
}

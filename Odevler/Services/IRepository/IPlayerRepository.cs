using System.Collections.Generic;
using Odevler.Models;

namespace Odevler.Services.IRepository
{
    public interface IPlayerRepository : IRepository<Player>
    {
        IEnumerable<Player> PlayerstoTeam();
        IEnumerable<Player> PlayerstoCountry();
        IEnumerable<Player> PlayerstoPosition();
    }
}
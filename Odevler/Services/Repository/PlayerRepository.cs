using Odevler.Data;
using System.Collections.Generic;
using System.Linq;
using Odevler.Models;
using Odevler.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Odevler.Services.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public IEnumerable<Player> PlayerstoTeam()
        {
            return ApplicationDbContext.Players.Include(x => x.Team).ToList();
        }
        public IEnumerable<Player> PlayerstoCountry()
        {
            return ApplicationDbContext.Players.Include(c => c.Country).ToList();
        }
        public IEnumerable<Player> PlayerstoPosition()
        {
            return ApplicationDbContext.Players.Include(o => o.Position).ToList();
        }
    }
}
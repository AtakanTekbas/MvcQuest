using Odevler.Data;
using System.Collections.Generic;
using System.Linq;
using Odevler.Models;
using Odevler.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Odevler.Services.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public IEnumerable<Team> TeamstoCountry()
        {
            return ApplicationDbContext.Teams.Include(c => c.Country).ToList();
        }
    }
}
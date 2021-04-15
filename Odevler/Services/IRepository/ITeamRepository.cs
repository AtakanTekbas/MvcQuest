using System.Collections.Generic;
using Odevler.Models;

namespace Odevler.Services.IRepository
{
    public interface ITeamRepository : IRepository<Team>
    {
        IEnumerable<Team> TeamstoCountry();
    }
}
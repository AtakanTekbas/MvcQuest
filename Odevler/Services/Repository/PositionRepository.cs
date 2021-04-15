using Odevler.Data;
using Odevler.Models;
using Odevler.Services.IRepository;


namespace Odevler.Services.Repository
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
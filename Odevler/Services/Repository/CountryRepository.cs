using Odevler.Data;
using System.Collections.Generic;
using System.Linq;
using Odevler.Models;
using Odevler.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Odevler.Services.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
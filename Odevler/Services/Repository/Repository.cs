using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Odevler.Models;
using Microsoft.EntityFrameworkCore;
using Odevler.Services.IRepository;                     //bu eklenmeli        (IRepository)
using Odevler.Data;                                             //bu da eklenmeli   (ApplicationDbContext)

namespace Odevler.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext ApplicationDbContext;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }
        

        public IEnumerable<T> GetAll()
        {
            return ApplicationDbContext.Set<T>().ToList();  
        }

        public IEnumerable<T> GetByFilter(Func<T, bool> predicate)
        {
            return ApplicationDbContext.Set<T>().Where(predicate).ToList();
        }
        public T GetById(int id)
        {
            return ApplicationDbContext.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            ApplicationDbContext.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            ApplicationDbContext.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            ApplicationDbContext.Remove(entity);
            Save();
        }

        public int Count(Func<T, bool> predicate)
        {
            return ApplicationDbContext.Set<T>().Where(predicate).Count();
        }
        private void Save() => ApplicationDbContext.SaveChanges();
    }
}

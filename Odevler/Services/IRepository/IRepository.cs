using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Odevler.Models;

namespace Odevler.Services.IRepository
{
   public interface IRepository<T> where T : class
    {
        // find object
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(Func<T, bool> predicate);

        // other functions

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);


    }
}

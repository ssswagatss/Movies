using Movies.Data.Interfaces;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected MovieContext Context;
        protected DbSet<T> DbSet;
        public GenericRepository(MovieContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public T Add(T entity)
        {
           return DbSet.Add(entity);
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

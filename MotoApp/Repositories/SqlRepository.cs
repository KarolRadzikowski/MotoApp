using Microsoft.EntityFrameworkCore;
using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public  class SqlRepositor<T> : IReposytory<T> where T : class, IEntitis, new()
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepositor(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll() 
        { 
            return _dbSet.OrderBy(item => item.Id).ToList();
        }
        public T GetById(int id) 
        {
            return _dbSet.Find(id);
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save() 
        {
        _dbContext.SaveChanges();
        }
    }

}

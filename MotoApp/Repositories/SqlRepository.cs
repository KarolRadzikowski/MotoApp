using Microsoft.EntityFrameworkCore;
using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public  class SqlRepositor
    {
        private readonly DbSet<Employee> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepositor(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Employee>();
        }
        public Employee? GetById(int id) 
        {
            return _dbSet.Find(id);
        }

        public void Add(Employee item)
        {
            _dbSet.Add(item);
        }
        public void Remove(Employee item)
        {
            _dbSet.Remove(item);
        }

        public void Save(Employee item) 
        {
        _dbContext.SaveChanges();
        }
    }

}

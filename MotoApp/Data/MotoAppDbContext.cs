using Microsoft.EntityFrameworkCore;
using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Data
{
    public class MotoAppDbContext: DbContext
    {
        public DbSet<Employee> empoloyees => Set<Employee>();
        
        
        public DbSet<Bussines_Partner > BussinsesPartner => Set<Bussines_Partner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}

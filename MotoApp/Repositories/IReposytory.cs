using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public interface IReposytory<T> : IReadRepository<T>, IWriteRepository<T>
        where T : class, IEntitis 
    {
    }
}

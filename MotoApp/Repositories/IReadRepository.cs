using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntitis
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}

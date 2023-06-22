using MotoApp.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public interface IWriteRepository <in T> where T : class, IEntitis 
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}

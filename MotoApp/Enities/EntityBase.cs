using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Enities
{
    public abstract class EntityBase : IEntitis
    {
        public int Id { get; set; }
    }
}

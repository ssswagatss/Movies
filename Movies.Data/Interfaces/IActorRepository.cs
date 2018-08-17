using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Interfaces
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        Actor GetActorByActorName(string name);
    }
}

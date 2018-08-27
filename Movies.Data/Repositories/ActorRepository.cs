using Movies.Data.Interfaces;
using Movies.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        private MovieContext _context;

        public ActorRepository(MovieContext context):base (context)
        {
            _context = context;
        }
        public Actor GetActorByActorName(string name)
        {
            return _context.Users.FirstOrDefault(x => x.Name.ToLower() == name.ToLower()) as Actor;
        }
    }
}

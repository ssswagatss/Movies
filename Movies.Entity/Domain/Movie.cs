using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entity
{
    public class Movie
    {
        public Movie()
        {
            Actors = new List<Actor>();
        }
        [Key]
        public int MovieId { get; set; }

        [MaxLength(255)]
        public string MovieName { get; set; }
        public int YearOfRelease { get; set; }

        public string Plot { get; set; }
        public string PosterURL { get; set; }
        
        [Required]
        public Producer Producer { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
    }
}

using Movies.Entity.Domain;
using Movies.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Domain.Entity
{
    public class Actor : User
    {
        public Actor()
        {
            this.UserProfile = UserProfile.Actor;
            this.Movies = new List<Movie>();
        }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

using Movies.Entity.Domain;
using Movies.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Domain.Entity
{
    public class Producer : User
    {
        public Producer()
        {
            this.UserProfile = UserProfile.Producer;
        }

        //public int MovieId { get; set; }

        //[ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
    }
}

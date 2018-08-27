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
        }

        public virtual Movie Movie { get; set; }
    }
}

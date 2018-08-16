using Movies.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Domain.Entity
{
    public class Producer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProducerId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public Gender Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}

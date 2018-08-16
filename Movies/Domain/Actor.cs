﻿using Movies.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActorId { get; set; }

        [MaxLength(255)]
        public string  Name { get; set; }

        public Gender  Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }
    }
}

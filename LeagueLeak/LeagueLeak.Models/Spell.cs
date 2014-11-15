﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LeagueLeak.Models
{
    public class Spell
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [MinLength(10)]
        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}

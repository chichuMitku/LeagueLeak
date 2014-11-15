﻿namespace LeagueLeak.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Champion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }


        [Required]
        [Range(1, 10)]
        public int Defense { get; set; }

        [Required]
        [Range(1, 10)]
        public int Magic { get; set; }

        [Required]
        [Range(1, 10)]
        public int Difficulty { get; set; }

        [Required]
        [Range(1, 10)]
        public int Attack { get; set; }
    }
}

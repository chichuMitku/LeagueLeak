﻿namespace LeagueLeak.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Feedback
    {
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        public DateTime CreationDate { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        [MinLength(5)]
        public string Content { get; set; }
    }
}

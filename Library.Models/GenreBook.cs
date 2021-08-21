﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class GenreBook : Base<int>
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

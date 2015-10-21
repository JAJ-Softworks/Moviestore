﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Model
{
   public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> movies { get; set;}
    }
}

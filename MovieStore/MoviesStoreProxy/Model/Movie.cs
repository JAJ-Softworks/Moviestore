﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesStoreProxy.Context;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MoviesStoreProxy.Model
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string TralierUrl { get; set; }
       
        public virtual List<OrderLine> orderLines { get; set; }
        public virtual Genre Genre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string TrailerURL { get; set; }
        public string Genre { get; set; }
    }
}
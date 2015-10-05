using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesStoreProxy.Context;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesStoreProxy.Model
{
    [Table("Movie")]
    public class Movie
    {
         [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string TralierUrl { get; set; }
        public virtual Genre genre { get; set; }

        
    }
}

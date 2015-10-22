using System.Collections.Generic;
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

        public virtual List<OrderLine> orderLines { get; set; }

        public virtual Genre Genre { get; set; }

    }
}

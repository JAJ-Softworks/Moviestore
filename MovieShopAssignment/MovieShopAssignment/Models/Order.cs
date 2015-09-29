using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<Movie> Movies { get; set; }
        public Customer Customer { get; set; }
    }
}
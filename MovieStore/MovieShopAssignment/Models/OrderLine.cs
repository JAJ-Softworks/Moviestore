using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShopAssignment.Models
{
    public class OrderLine
    {
        private OrderLine()
        {

        }
        public OrderLine(Movie movie, uint amount)
        {
            Movie = movie;
            Amount = amount;
        }
        public Movie Movie { get; set; }

        public uint Amount { get; set; }
    }
}

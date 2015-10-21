using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieShopAssignment.Models;

namespace MovieShopAssignment.ViewModels
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

        public uint Amount {get; set; }

        public double Total { get; private set; }
 
        public double getTotal()
        {
            Total = Movie.Price * Amount;
            return Total;
        }
    }
}
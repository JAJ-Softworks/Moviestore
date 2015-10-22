using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieShopAssignment.Models;

namespace MovieShopAssignment.ViewModels
{
    public class OrderLineViewModel
    {
        private OrderLineViewModel()
        {

        }
        public OrderLineViewModel(MovieViewModel movie, int amount)
        {
            MovieVM = movie;
            Amount = amount;
        }

        public MovieViewModel MovieVM { get; set; }

        public int Amount {get; set; }

        public double Total { get; private set; }
 
        public double getTotal()
        {
            Total = MovieVM.Movie.Price * Amount;
            return Total;
        }
    }
}
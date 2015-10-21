using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class ShoppingCart
    {
        public List<OrderLine> orderLines { get; set; }

        public ShoppingCart()
        {
            orderLines = new List<OrderLine>();
        }

        public void AddOrderLine(OrderLine line)
        {
            orderLines.Add(line);
        }

        public void RemoveOrderLine(OrderLine line)
        {
            orderLines.Remove(line);
        }
    }
}
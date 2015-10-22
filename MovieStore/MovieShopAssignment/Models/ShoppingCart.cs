using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.Models
{
    public class ShoppingCart
    {
        public double totalPrice { get; private set; }
        public List<OrderLine> OrderLines { get; set; }
        public ShoppingCart()
        {
            OrderLines = new List<OrderLine>();
        }
        public void AddOrderLine(OrderLine line)
        {
            OrderLines.Add(line);
            totalPrice += (line.Movie.Price * line.Amount);
        }
        public void RemoveOrderLine(OrderLine line)
        {
            totalPrice -= (line.Movie.Price * line.Amount);
            OrderLines.Remove(line);
        }
    }
}
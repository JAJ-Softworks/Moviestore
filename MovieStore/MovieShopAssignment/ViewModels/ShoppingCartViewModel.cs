using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.ViewModels
{
    public class ShoppingCart
    {
        public double Total { get; private set; }
        public List<OrderLine> OrderLines { get; set; }
        public ShoppingCart()
        {
            OrderLines = new List<OrderLine>();
        }
        public void AddOrderLine(OrderLine line)
        {
            OrderLines.Add(line);
        }
        public void RemoveOrderLine(OrderLine line)
        {
            OrderLines.Remove(line);
        }
        public double getTotal()
        {
            Total = 0;
            foreach(OrderLine line in OrderLines)
            {
                Total += line.getTotal();
            }
            return Total;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.ViewModels
{
    public class ShoppingCart
    {
        public double Total { get; private set; }
        public List<OrderLineViewModel> OrderLines { get; set; }
        public ShoppingCart()
        {
            OrderLines = new List<OrderLineViewModel>();
        }
        public void AddOrderLine(OrderLineViewModel line)
        {
            OrderLines.Add(line);
        }
        public void RemoveOrderLine(OrderLineViewModel line)
        {
            OrderLines.Remove(line);
        }
        public double getTotal()
        {
            Total = 0;
            foreach(OrderLineViewModel line in OrderLines)
            {
                Total += line.getTotal();
            }
            return Total;
        }
    }
}
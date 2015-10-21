using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class OrderRepository
    { 
    public void Add(Order order)
    {

        using (var ctx = new MovieStoreContext())
        {

            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }
    }

    public List<Order> GetOrders()
    {
        using (var ctx = new MovieStoreContext())
        {

            return ctx.Orders.ToList();
        }
    }

    public List<Order> GetOrdersFromCustomer(int id)
        {
            using (var ctx = new MovieStoreContext())
            {
                return ctx.Orders.Where(x => x.CustomerId == id).ToList();
            }
        }

    public Order GetOrder(int id)
    {
        using (var ctx = new MovieStoreContext())
        {
            return ctx.Orders.Where(x => x.OrderId == id).FirstOrDefault();
        }
    }

    public void UpdateOrder(Order order)
    {

        using (var ctx = new MovieStoreContext())
        {
            Order m = ctx.Orders.Where(x => x.OrderId == order.OrderId).First();
            m.customer = order.customer;
            m.orderLines = order.orderLines;
            m.date = order.date;
            m.OrderId = order.OrderId;
            ctx.SaveChanges();
        }
    }

    public void DeleteOrder(int id)
    {
        using (var ctx = new MovieStoreContext())
        {

            Order m = ctx.Orders.Where(x => x.OrderId == id).First();
            if (m != null)
                ctx.Orders.Remove(m);
            ctx.SaveChanges();
        }
    }
  }
}


using MoviesStoreProxy.Context;
using MovieStoreTest;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class OrderLineRepository
    {
        public void Add(OrderLine orderLine)
        {

            using (var ctx = new MovieStoreContext())
            {

                ctx.OrderLines.Add(orderLine);
                ctx.SaveChanges();
            }
        }

        public List<OrderLine> GetOrderLines()
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.OrderLines.ToList();
            }
        }

        public OrderLine GetOrderLine(int id)
        {
            using (var ctx = new MovieStoreContext())
            {
                return ctx.OrderLines.Where(x => x.OrderId == id).FirstOrDefault();
            }
        }

        public void UpdateOrderLine(OrderLine orderLine)
        {

            using (var ctx = new MovieStoreContext())
            {
                OrderLine m = ctx.OrderLines.Where(x => x.OrderId == orderLine.OrderId).First();
                m.Amount = orderLine.Amount;
                m.OrderId = orderLine.OrderId;
                m.MovieId = orderLine.MovieId;
                m.Movie = orderLine.Movie;
                m.Order = orderLine.Order;
                ctx.SaveChanges();
            }
        }

        public void DeleteOrderLine(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                OrderLine m = ctx.OrderLines.Where(x => x.OrderId == id).First();
                if (m != null)
                    ctx.OrderLines.Remove(m);
                ctx.SaveChanges();
            }
        }
    }
}


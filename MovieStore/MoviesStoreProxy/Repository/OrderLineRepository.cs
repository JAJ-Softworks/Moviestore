using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class OrderLineRepository
    {
        public void Add(OrderLine OL)
        {

            using (var ctx = new MovieStoreContext())
            {

                ctx.OrderLines.Add(OL);
                ctx.SaveChanges();
            }
        }

        public List<OrderLine> ReadAll()
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.OrderLines.ToList();
            }
        }

        public List<OrderLine> GetOrderLines(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.OrderLines.Where(x => x.OrderId == id).Include(x => x.Movie).ToList();
            }
        }


        public void UpdateOrderLine(OrderLine OL)
        {

            using (var ctx = new MovieStoreContext())
            {
                ctx.Entry(OL).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteOrderLine(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                OrderLine m = ctx.OrderLines.Where(x => x.OrderId == id).FirstOrDefault();
                if (m != null)
                    ctx.OrderLines.Remove(m);
                ctx.SaveChanges();
            }
        }

    }
}



using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context
{
    public class OrderDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {

        protected override void Seed(MovieStoreContext context)
        {
            IList<Order> orders = new List<Order>();

            orders.Add(new Order() {OrderId = 1, date = DateTime.Now.AddYears(-25), });
            orders.Add(new Order() {OrderId = 2 , date = DateTime.Now.AddYears(-15), });
            orders.Add(new Order() {OrderId = 3, date = DateTime.Now.AddYears(-10), });


            foreach (Order o in orders)
                context.Orders.Add(o);

            base.Seed(context);
        }
    }
}

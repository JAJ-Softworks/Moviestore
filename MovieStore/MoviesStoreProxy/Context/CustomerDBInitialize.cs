using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context
{
    public class CustomerDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {

        protected override void Seed(MovieStoreContext context)
        {
            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer() { });
            customers.Add(new Customer() { });
            customers.Add(new Customer() { });
            customers.Add(new Customer() { });


            foreach (Customer c in customers)
                context.Customers.Add(c);

            base.Seed(context);
        }
    }
}


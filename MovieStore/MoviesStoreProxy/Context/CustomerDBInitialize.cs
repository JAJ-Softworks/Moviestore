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
            //IList<Customer> customers = new List<Customer>();

            //customers.Add(new Customer() {FirstName = "Abdirahman", LastName = "Yusuf",Address = " Spangsbjerg Kirkevej 101, 6700 Aarhus", Email = "abdi1500@easv365.dk" });
            //customers.Add(new Customer() { FirstName = "Joakim", LastName = "Christensen", Address = " Spangsbjerg 104, 6700 Esbjerg", Email = "joakim1234@easv365.dk" });
            //customers.Add(new Customer() { FirstName = "Joseif", LastName = "Gharib", Address = " Kirkevej 91, 6700 Esbjerg", Email = "josef452@easv365.dk" });


            //foreach (Customer c in customers)
            //    context.Customers.Add(c);

            //base.Seed(context);
        }
    }
}


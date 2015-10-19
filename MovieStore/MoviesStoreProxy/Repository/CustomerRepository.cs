using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class CustomerRepository
    {

        public void Add(Customer customer)
        {

            using (var ctx = new MovieStoreContext())
            {

                ctx.Customers.Add(customer);
                ctx.SaveChanges();
            }
        }

        public List<Customer> ReadAll()
        {
            using (var ctx = new MovieStoreContext())
            {
                return ctx.Customers.ToList();
            }
        }
        public Customer ReadAll(int? id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.Customers.Where(x => x.Id == id).FirstOrDefault();
            }
        }

       

        public void UpdateCustomer(Customer customer)
        {

            using (var ctx = new MovieStoreContext())
            {
                Customer m = ctx.Customers.Where(x => x.Id == customer.Id).First();
                m.FirstName = customer.FirstName;
                m.LastName = customer.LastName;
                m.Address = customer.Address;
                m.Email = customer.Email;
                m.orders = customer.orders;
                ctx.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                Customer m = ctx.Customers.Where(x => x.Id == id).First();
                if (m != null)
                    ctx.Customers.Remove(m);
                ctx.SaveChanges();
            }
        }
    }
    }

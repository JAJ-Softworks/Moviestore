using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context
{

    public class MovieStoreContext : DbContext
    {
        public MovieStoreContext() : base("name=MovieStoreDb")
        {
            Database.SetInitializer(new MovieDBInitialize());
           
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

    }
}
    



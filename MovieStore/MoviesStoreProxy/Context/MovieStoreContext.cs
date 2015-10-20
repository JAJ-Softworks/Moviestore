using MoviesStoreProxy.Model;
using MovieStoreTest;
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
        public MovieStoreContext() : base("MovieStore")
        {
            Database.SetInitializer(new MovieDBInitialize());
            Database.SetInitializer(new CustomerDBInitialize());
            Database.SetInitializer(new OrderDBInitialize());
            Database.SetInitializer(new GenreDBInitialize());


        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }

    }
}
    



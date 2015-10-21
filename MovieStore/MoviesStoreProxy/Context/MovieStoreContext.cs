using MoviesStoreProxy.Model;
using MovieStoreTest;
using System;
using System.Collections.Generic;

using System.Data.Entity;

namespace MoviesStoreProxy.Context
{

    public class MovieStoreContext : DbContext
    {
        public MovieStoreContext() : base("MovieStore")
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
    



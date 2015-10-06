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
        public MovieStoreContext() : base("MovieStore")
        {
            Database.SetInitializer(new MovieDBInitialize());
            Database.SetInitializer(new CustomerDBInitialize());
            Database.SetInitializer(new GenreDBInitialize());
            Database.SetInitializer(new OrderDBInitialize());
        }

        //     protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movie>().HasMany(x => x.genre).WithMany(y => y.Movies);
        //}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}

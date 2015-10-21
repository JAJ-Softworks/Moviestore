using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context
{
    public class MovieDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {

        protected override void Seed(MovieStoreContext context)
        {
          //  IList<Movie> movies = new List<Movie>();

            Genre g1 = context.Genres.Add(new Genre() { GenreId = 1,Name = "Action" });
            Genre g2 = context.Genres.Add(new Genre() {GenreId = 2, Name = "Horror" });
            Genre g3 = context.Genres.Add(new Genre() { GenreId = 3, Name = "Romance" });

            context.Movies.Add(new Movie() { Price = 102, Genre = g1, Title = "Taken 3", Year = 2013 ,ImageUrl = "" , TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 103, Genre = g1, Title = "Terminator 4", Year = 2014 , ImageUrl = "", TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 110, Genre = g3, Title = "Love you", Year = 2015 , ImageUrl = "", TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 130, Genre = g2, Title = "Die", Year = 2015 , ImageUrl = "", TralierUrl = ""});

            context.Customers.Add(new Customer() { FirstName = "Abdirahman", LastName = "Yusuf", Address = " Spangsbjerg Kirkevej 101, 6700 Aarhus", Email = "abdi1500@easv365.dk" });
            context.Customers.Add(new Customer() { FirstName = "Joakim", LastName = "Christensen", Address = " Spangsbjerg 104, 6700 Esbjerg", Email = "joakim1234@easv365.dk" });
            context.Customers.Add(new Customer() { FirstName = "Josef", LastName = "Gharib", Address = " Kirkevej 91, 6700 Esbjerg", Email = "josef452@easv365.dk" });

            context.Orders.Add(new Order() { OrderId = 1, CustomerId= 1, date = DateTime.Now.AddYears(-25), });
            context.Orders.Add(new Order() { OrderId = 2, CustomerId = 2, date = DateTime.Now.AddYears(-15), });
            context.Orders.Add(new Order() { OrderId = 3, CustomerId = 3, date = DateTime.Now.AddYears(-10), });

            //    foreach (Movie m in movies)
            //      context.Movies.Add(m);

            base.Seed(context);
        }
    }
}
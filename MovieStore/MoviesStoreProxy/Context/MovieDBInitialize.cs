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
    public class MovieDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {

        protected override void Seed(MovieStoreContext context)
        {
            //IList<Movie> movies = new List<Movie>();


            context.Genres.Add(new Genre() { Id = 1, Name = "Action" });
            context.Genres.Add(new Genre() { Id = 2, Name = "Horror" });
            context.Genres.Add(new Genre() { Id = 3, Name = "Romance" });

            context.Movies.Add(new Movie() {Id = 1, Price = 102, Genre = 1 , Title = "Taken 3", Year = 2013, ImageUrl = "", TralierUrl = "" });
            context.Movies.Add(new Movie() { Id = 2, Price = 103, Genre = 1, Title = "Terminator 4", Year = 2014, ImageUrl = "", TralierUrl = "" });
            context.Movies.Add(new Movie() { Id = 3, Price = 110, Genre = 3, Title = "Love you", Year = 2015, ImageUrl = "", TralierUrl = "" });
            context.Movies.Add(new Movie() { Id = 4, Price = 130, Genre = 2, Title = "Die", Year = 2015, ImageUrl = "", TralierUrl = "" });

            context.Customers.Add(new Customer() {Id = 1, FirstName = "Abdirahman", LastName = "Yusuf", Address = " Spangsbjerg Kirkevej 101, 6700 Aarhus", Email = "abdi1500@easv365.dk" });
            context.Customers.Add(new Customer() {Id = 2, FirstName = "Joakim", LastName = "Christensen", Address = " Spangsbjerg 104, 6700 Esbjerg", Email = "joakim1234@easv365.dk" });
            context.Customers.Add(new Customer() {Id = 3, FirstName = "Josef", LastName = "Gharib", Address = " Kirkevej 91, 6700 Esbjerg", Email = "josef452@easv365.dk" });

            context.OrderLines.Add(new OrderLine(){OrderId = 2, MovieId = 1,   Amount = 15,});
            context.OrderLines.Add(new OrderLine() { Amount = 10,});
            context.OrderLines.Add(new OrderLine() { Amount = 25, });

            context.Orders.Add(new Order() { Id = 1, date = DateTime.Now.AddYears(-25), Customer = 3,});
            context.Orders.Add(new Order() { Id = 2, date = DateTime.Now.AddYears(-15), Customer = 2, });
            context.Orders.Add(new Order() { Id = 3, date = DateTime.Now.AddYears(-10), Customer = 1});

           

            

            //foreach (Movie m in movies)
            //    context.Movies.Add(m);

            base.Seed(context);
        }
    }
}
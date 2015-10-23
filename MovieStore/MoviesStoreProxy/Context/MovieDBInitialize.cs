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
            //IList<Movie> movies = new List<Movie>();

            Genre g1 = context.Genres.Add(new Genre() { Id = 1, Name = "Action" });
            Genre g2 = context.Genres.Add(new Genre() { Id = 2, Name = "Horror" });
            Genre g3 = context.Genres.Add(new Genre() { Id = 3, Name = "Romance" });

            context.Movies.Add(new Movie() { Id = 1, Price = 102, Genre = g1, Title = "Taken 3", Year = 2013, ImageUrl = "", TralierUrl = "" });
            context.Movies.Add(new Movie() { Id = 2, Price = 103, Genre = g1, Title = "Terminator 4", Year = 2014, ImageUrl = "http://www.chud.com/wp-content/uploads/2015/06/T2-Poster.jpg", TralierUrl = "https://www.youtube.com/watch?v=IcYdjHpJUV8" });
            context.Movies.Add(new Movie() { Id = 3, Price = 110, Genre = g3, Title = "Love you", Year = 2015, ImageUrl = "", TralierUrl = "" });
            context.Movies.Add(new Movie() { Id = 4, Price = 130, Genre = g2, Title = "Die", Year = 2015, ImageUrl = "", TralierUrl = "" });

            Customer c1 =  context.Customers.Add(new Customer() { Id = 1, FirstName = "Abdirahman", LastName = "Yusuf", Address = " Spangsbjerg Kirkevej 101, 6700 Aarhus", Email = "abdi1500@easv365.dk" });
            Customer c2 = context.Customers.Add(new Customer() { Id = 2, FirstName = "Joakim", LastName = "Christensen", Address = " Spangsbjerg 104, 6700 Esbjerg", Email = "joakim1234@easv365.dk" });
            Customer c3 = context.Customers.Add(new Customer() { Id = 3, FirstName = "Josef", LastName = "Gharib", Address = " Kirkevej 91, 6700 Esbjerg", Email = "josef452@easv365.dk" });

            context.OrderLines.Add(new OrderLine() {Id = 1,OrderId = 2, MovieId = 1 , Amount = 15, });
            context.OrderLines.Add(new OrderLine() {Id = 2,OrderId = 3, MovieId = 4 , Amount = 10, });
            context.OrderLines.Add(new OrderLine() {Id = 3,OrderId = 1, MovieId = 3 , Amount = 25, });

            context.Orders.Add(new Order() { Id = 4, date = DateTime.Now.AddYears(-25), Customer = c3, });

            context.Orders.Add(new Order() { Id = 1, date = DateTime.Now.AddYears(-25), Customer = c3, });
            context.Orders.Add(new Order() { Id = 2, date = DateTime.Now.AddYears(-15), Customer = c2, });
            context.Orders.Add(new Order() { Id = 3, date = DateTime.Now.AddYears(-10), Customer = c1 });

            //foreach (Movie m in movies)
            //    context.Movies.Add(m);

            base.Seed(context);
        }
    }
}
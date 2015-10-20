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
            IList<Movie> movies = new List<Movie>();

            Genre g1 = context.Genres.Add(new Genre() { Name = "Action" });
            Genre g2 = context.Genres.Add(new Genre() { Name = "Horror" });
            Genre g3 = context.Genres.Add(new Genre() { Name = "Romance" });

            context.Movies.Add(new Movie() { Price = 102, Genre = g1, Title = "Taken 3", Year = 2013 ,ImageUrl = "" , TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 103, Genre = g1, Title = "Terminator 4", Year = 2014 , ImageUrl = "", TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 110, Genre = g3, Title = "Love you", Year = 2015 , ImageUrl = "", TralierUrl = ""});
            context.Movies.Add(new Movie() { Price = 130, Genre = g2, Title = "Die", Year = 2015 , ImageUrl = "", TralierUrl = ""});

            foreach (Movie m in movies)
                context.Movies.Add(m);

            base.Seed(context);
        }
    }
}
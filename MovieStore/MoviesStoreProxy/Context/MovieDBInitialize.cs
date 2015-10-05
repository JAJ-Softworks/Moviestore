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

            movies.Add(new Movie() { Title = "Taken 3", Year = 2014, Price = 59.99, ImageUrl = "", TralierUrl = "" });
            movies.Add(new Movie() { Title = "Taken 3", Year = 2014, Price = 59.99, ImageUrl = "", TralierUrl = "" });
            movies.Add(new Movie() { Title = "Taken 3", Year = 2014, Price = 56.99, ImageUrl = "", TralierUrl = "" });
            movies.Add(new Movie() { Title = "Taken 3", Year = 2014, Price = 67.99, ImageUrl = "", TralierUrl = "" });


            foreach (Movie m in movies)
                context.Movies.Add(m);

            base.Seed(context);
        }
    }
}
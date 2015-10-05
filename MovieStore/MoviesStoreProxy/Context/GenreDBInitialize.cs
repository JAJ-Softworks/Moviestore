using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context
{
    public class GenreDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {

        protected override void Seed(MovieStoreContext context)
        {
            IList<Genre> genres = new List<Genre>();

            genres.Add(new Genre() { Name = "Action" });
            genres.Add(new Genre() { Name = "Romance" });
            genres.Add(new Genre() { Name = "Comadi" });
            genres.Add(new Genre() { Name = "Action" });


            foreach (Genre g in genres)
                context.Genres.Add(g);

            base.Seed(context);
        }
    }
}



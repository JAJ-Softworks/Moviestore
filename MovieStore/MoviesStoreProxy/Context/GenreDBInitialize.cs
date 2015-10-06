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

            genres.Add(new Genre() {Id = 1, Name = "Action"});
            genres.Add(new Genre() {Id = 2, Name = "Romance" });
            genres.Add(new Genre() {Id = 3, Name = "Comedy" });
           
            foreach (Genre g in genres)
                context.Genres.Add(g);

            base.Seed(context);
        }
    }
}



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

            Genre g = (new Genre() { Id =1, Name = "Action" });
            Genre g1 = (new Genre() { Id = 2, Name = "Drama " });
            Genre g2 = (new Genre() { Id = 3, Name = "romance " });


            foreach (Genre std in defaultGenres)
                context.Genres.Add(std);

            base.Seed(context);
        }
    }
}
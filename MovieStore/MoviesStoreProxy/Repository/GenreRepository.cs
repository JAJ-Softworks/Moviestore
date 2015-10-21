using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
 public class GenreRepository
    {

        public void Add(Genre genre)
        {

            using (var ctx = new MovieStoreContext())
            {

                ctx.Genres.Add(genre);
                ctx.SaveChanges();
            }
        }

        public List<Genre> ReadAll()
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.Genres.ToList();
            }
        }

        public Genre GetGenre(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.Genres.Where(x => x.GenreId == id).FirstOrDefault();
            }
        }


        public void UpdateGenre(Genre genre)
        {

            using (var ctx = new MovieStoreContext())
            {
                Genre m = ctx.Genres.Where(x => x.GenreId == genre.GenreId).First();
                m.GenreId = genre.GenreId;
                m.Name = genre.Name;
                ctx.SaveChanges();
            }
        }

        public void DeleteGenre(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                Genre m = ctx.Genres.Where(x => x.GenreId == id).First();
                if (m != null)
                    ctx.Genres.Remove(m);
                ctx.SaveChanges();
            }
        }

    }
}


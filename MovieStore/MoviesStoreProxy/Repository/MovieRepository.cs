﻿using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class MovieRepository
    {
        public void Add(Movie movie)
        {
            using (var ctx = new MovieStoreContext())
            {
                ctx.Movies.Add(movie);
                ctx.SaveChanges();
            }
        }

        public List<Movie> ReadAll()
        {
            using (var ctx = new MovieStoreContext())
            {
                return ctx.Movies.Include(a => a.Genre).ToList();
            }

        }
       
        public Movie GetMovie(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                return ctx.Movies.Where(x => x.MovieId == id).Include(a => a.Genre).FirstOrDefault();
            }
        }
        public void UpdateMovie(Movie movie)
        {

            using (var ctx = new MovieStoreContext())
            {
                /* Movie m = ctx.Movies.Where(x => x.MovieId == movie.MovieId).First();
                 m.ImageUrl = movie.ImageUrl;
                 m.Title = movie.Title;
                 m.Price = movie.Price;
                 m.Year = movie.Year;
                 m.TralierUrl = movie.TralierUrl;
                 m.Genre = movie.Genre;*/
                ctx.Entry(movie).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            using (var ctx = new MovieStoreContext())
            {

                Movie m = ctx.Movies.Where(x => x.MovieId == id).First();
                if (m != null)
                    ctx.Movies.Remove(m);
                ctx.SaveChanges();
            }
        }

    }
}


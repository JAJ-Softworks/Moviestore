using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesStoreProxy.Model;

namespace MovieShopAssignment.Repository
{
    public class GenreRepository
    {
        private static GenreRepository Instance;
        private List<Genre> Genres;
        private GenreRepository()
        {


        }
        public List<Genre> GetAll()
        {
            Genres = new List<Genre>();
            Genres = new MoviesStoreProxy.Repository.Facade().GetGenryRepository().ReadAll();
            return Genres;
        }
        public static GenreRepository getInstance()
        {
            if (Instance == null)
                Instance = new GenreRepository();
            return Instance;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieShopAssignment.ViewModels;
using MoviesStoreProxy.Model;

namespace MovieShopAssignment
{
    public class MovieRepository
    {
        private static MovieRepository Instance;
        private List<MovieViewModel> MovieViewModels;
        private MovieRepository()
        {
            

        }
        public List<MovieViewModel> GetAll()
        {
            MovieViewModels = new List<MovieViewModel>();
            List<Movie> Movies = new MoviesStoreProxy.Repository.Facade().GetMovieRepository().ReadAll();
            List<Genre> Genres = new MoviesStoreProxy.Repository.Facade().GetGenryRepository().ReadAll();
            foreach (Movie mov in Movies)
            {
                MovieViewModel newViewModel = new MovieViewModel() { Movie = mov, Genre = Genres.FirstOrDefault(x => x.Id == mov.Genre.Id) };
                MovieViewModels.Add(newViewModel);
            }
            return MovieViewModels;
        }
        public static MovieRepository getInstance()
        {
            if (Instance == null)
                Instance = new MovieRepository();
            return Instance;
        }
    }
}
using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using MovieStore.Models;
using MovieStoreTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {

        private Facade facade = new Facade();
     
        // GET: Movie
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddOrderLine(new OrderLine());
            {

                var Movie  = new Movie() { Id = 1, Title = "Bog Foot" };
               //Amount = 10;
            };

            cart.AddOrderLine(new OrderLine());
            // orderLines.Add(OrderLine);

            {
                var Movie = new Movie() { Id = 2, Title = "Taken 2" };
                //Amount = 12;
            };
            Session["ShoppingCart"] = cart;
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }
    
        [HttpGet]
        public ActionResult Create()
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            facade.GetMovieRepository().Add(movie);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Movie m = facade.GetMovieRepository().GetMovie(Id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            facade.GetMovieRepository().UpdateMovie(movie);
            return Redirect("Index");
        }

        [HttpGet]
        ///HTTPGet Delete only returns a html page with the yes/no button
        public ActionResult Delete(int movieId)
        {
            Movie m = facade.GetMovieRepository().GetMovie(movieId);
            return View(movieId);
        }

        [HttpPost]
        [ActionName("Delete")]
        ///HTTPPost DeleteAccepted will be hit if the user presses yes on the delete page above.
        public ActionResult DeleteAccepted(int movieId)
        {
            facade.GetMovieRepository().DeleteMovie(movieId);

            return Redirect("Index");
        }
    }
}
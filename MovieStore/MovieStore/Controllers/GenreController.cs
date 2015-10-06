using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class GenreController : Controller
    {
        private Facade facade = new Facade();

        // GET: Movie
        public ActionResult Index()
        {
            List<Genre> genres = facade.GetGenryRepository().ReadAll();
            return View(genres);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            facade.GetGenryRepository().Add(genre);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Genre g = facade.GetGenryRepository().GetGenre(Id);
            return View(g);
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            facade.GetGenryRepository().UpdateGenre(genre);
            return Redirect("Index");
        }

        [HttpGet]
        ///HTTPGet Delete only returns a html page with the yes/no button
        public ActionResult Delete(int genreId)
        {
            Genre g = facade.GetGenryRepository().GetGenre(genreId);
            return View(genreId);
        }

        [HttpPost]
        [ActionName("Delete")]
        ///HTTPPost DeleteAccepted will be hit if the user presses yes on the delete page above.
        public ActionResult DeleteAccepted(int genreId)
        {
            facade.GetGenryRepository().DeleteGenre(genreId);

            return Redirect("Index");
        }
    }
}
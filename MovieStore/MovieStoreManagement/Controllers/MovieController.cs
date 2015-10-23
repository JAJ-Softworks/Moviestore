using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesStoreProxy.Repository;
using MoviesStoreProxy.Model;

namespace MovieStoreManagement.Controllers
{
    public class MovieController : Controller
    {
        Facade fac = new Facade();
        // GET: Movie
        public ActionResult Index()
        {
            return View(fac.GetMovieRepository().ReadAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(fac.GetGenryRepository().ReadAll(), "Id", "Name");
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie mov,FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetMovieRepository().Add(mov);
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(fac.GetGenryRepository().ReadAll(), "Id", "Name");
            return View();
        }

        // GET: Movie/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = fac.GetMovieRepository().GetMovie(id);
            ViewBag.GenreId = new SelectList(fac.GetGenryRepository().ReadAll(), "Id", "Name", movie);
            return View(movie);
        }

        // POST: Movie/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                fac.GetMovieRepository().UpdateMovie(movie);
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(fac.GetGenryRepository().ReadAll(), "GenreId", "Name", movie);
            return View();
            
        }

        // GET: Movie/Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var movie = fac.GetMovieRepository().GetMovie(id);
            return View(movie);
        }
        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                fac.GetMovieRepository().DeleteMovie(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

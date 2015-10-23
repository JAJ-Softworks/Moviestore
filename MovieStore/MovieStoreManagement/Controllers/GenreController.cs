using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreManagement.Controllers
{
    public class GenreController : Controller
    {
        Facade fac = new Facade();
        public ActionResult Index()
        {
            return View(fac.GetGenryRepository().ReadAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre genre, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetGenryRepository().Add(genre);
                return RedirectToAction("Index");
            }
            
                return View();
            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(fac.GetGenryRepository().GetGenre(id));
        }

        // POST: Genre/Edit/5
        [HttpPost]
        public ActionResult Edit(Genre genre, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetGenryRepository().UpdateGenre(genre);
                return RedirectToAction("Index");
            }
                return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(fac.GetGenryRepository().GetGenre(id));
        }

        // POST: Genre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetGenryRepository().DeleteGenre(id);
                return RedirectToAction("Index");
            }

            return View();
            
        }
    }
}

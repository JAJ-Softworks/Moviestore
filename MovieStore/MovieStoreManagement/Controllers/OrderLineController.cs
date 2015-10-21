using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreManagement.Controllers
{
    public class OrderLineController : Controller
    {
        Facade fac = new Facade();
        public ActionResult Index(int id)
        {
            return View(fac.GetOrderLineRepository().GetOrderLines(id));
        }

        public ActionResult Edit(int id)
        {

            var OL = fac.GetOrderLineRepository().GetOrderLine(id);
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "MovieId", "Title", OL);
            return View(OL);
        }

        // POST: OrderLine/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderLine OL, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetOrderLineRepository().UpdateOrderLine(OL);
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "MovieId", "Title", OL);

            return View();
        }

        // GET: OrderLine/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var OL = fac.GetOrderLineRepository().GetOrderLine(id);
            return View(OL);
        }

        // POST: OrderLine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                fac.GetOrderLineRepository().DeleteOrderLine(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "MovieId", "Title");
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrderLine OL)
        {
            if (ModelState.IsValid)
            {
                fac.GetOrderLineRepository().Add(OL);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}

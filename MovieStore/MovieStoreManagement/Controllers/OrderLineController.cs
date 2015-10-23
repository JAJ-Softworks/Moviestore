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
            return View(fac.GetOrderLineRepository().ReadAll(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            var OL = fac.GetOrderLineRepository().GetOrderLine(id);
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "Id", "Title", OL);
            return View(OL);
        }

        // POST: OrderLine/Edit
        [HttpPost]
        public ActionResult Edit(OrderLine OL, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetOrderLineRepository().UpdateOrderLine(OL);
                return RedirectToAction("Index", new {id = OL.OrderId });
            }
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "Id", "Title", OL);

            return View();
        }

        // GET: OrderLine/Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var OL = fac.GetOrderLineRepository().GetOrderLine(id);
            return View(OL);
        }

        // POST: OrderLine/Delete
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            int OrderID = fac.GetOrderLineRepository().GetOrderLine(id).OrderId;
            if (ModelState.IsValid)
            {
                fac.GetOrderLineRepository().DeleteOrderLine(id);
                return RedirectToAction("Index", new {id =  OrderID});
            }
                return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrderLine OL, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetOrderLineRepository().Add(OL);
                return RedirectToAction("Index", new {id = OL.Id });
            }
            ViewBag.MovieId = new SelectList(fac.GetMovieRepository().ReadAll(), "Id", "Title");
            return View();
        }

    }
}

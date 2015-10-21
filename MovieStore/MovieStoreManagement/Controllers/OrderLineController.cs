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
            var OL = fac.GetOrderLineRepository().GetOrderLines(id);
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
                return View();
        }

        // GET: OrderLine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderLine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

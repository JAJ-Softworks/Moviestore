using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreManagement.Controllers
{
    public class OrderController : Controller
    {
        Facade fac = new Facade();
        public ActionResult Index(int id)
        {
            return View(fac.GetOrderRepository().GetOrders(id));
        }

        // GET: Order/Details
        public ActionResult Details(int Id)
        {
            return RedirectToAction("Index","OrderLine", new { id = Id});
        }

        // GET: Order/Delete
        public ActionResult Delete(int id)
        {
            var order = fac.GetOrderRepository().GetOrder(id);
            return View(order);
        }

        // POST: Order/Delete
        [HttpPost]
        public ActionResult Delete(int Id, FormCollection collection)
        {
            if(ModelState.IsValid)
            {
                fac.GetOrderRepository().DeleteOrder(Id);
                return RedirectToAction("Index", new {id = Id });
            }
                return View();
        }
    }
}

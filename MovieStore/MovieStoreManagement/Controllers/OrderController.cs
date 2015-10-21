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
            return View(fac.GetOrderRepository().GetOrdersFromCustomer(id));
        }

        // GET: Order/Details/5
        public ActionResult Details(int Id)
        {
            return RedirectToAction("Index","OrderLine", new { id = Id});
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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

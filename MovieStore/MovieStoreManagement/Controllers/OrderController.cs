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
        public ActionResult Index(Customer cus)
        {
            return View(fac.GetOrderRepository().ReadAll().Where(x => x.Id == cus.Id));
        }

        // GET: Order/Details/5
        public ActionResult Details(int Id)
        {
            return RedirectToAction("Index","OrderLine", new { id = Id});
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            var order = fac.GetOrderRepository().GetOrder(id);
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                fac.GetOrderRepository().DeleteOrder(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movies()
        {
            return RedirectToAction("Index","Movie");
        }

        public ActionResult Customers()
        {
            return RedirectToAction("Index", "Customer");
        }
    }
}
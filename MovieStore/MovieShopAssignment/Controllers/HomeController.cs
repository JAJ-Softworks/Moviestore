using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;
namespace MovieShopAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "In case you wanted to know more about our shop.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You are of course welcome to contact us at any of the following emails.";

            return View();
        }
    }
}
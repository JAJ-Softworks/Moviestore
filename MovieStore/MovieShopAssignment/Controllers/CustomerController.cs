using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;

namespace MovieShopAssignment.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index(Customer customer)
        {
            return View(customer);
        }
        public ActionResult Search()
        {
            return RedirectToAction("Index", FakeDB.GetInstance().FindCustomerByMail("janetisabitch@bitch.com"));
        }
        //public ActionResult Confirm(Order order)
        //{
        //    return View();
        //}
	}
}
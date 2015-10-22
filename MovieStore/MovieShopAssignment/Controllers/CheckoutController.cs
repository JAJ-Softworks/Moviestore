using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Repository;
using MovieShopAssignment.ViewModels;

namespace MovieShopAssignment.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index(string CustomerMail)
        {
            if(CustomerMail.Count() > 0)
            {
                if(CustomerRepository.getInstance().GetAll().FirstOrDefault(x => x.Email == CustomerMail) != null)
                return View(CustomerRepository.getInstance().GetAll().FirstOrDefault(x => x.Email == CustomerMail));
            }
            return View(new CustomerViewModel());
        }
    }
}
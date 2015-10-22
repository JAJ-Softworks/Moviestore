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
        public ActionResult CompleteCheckout(CustomerViewModel CustomerVM)
        {
            //This try catch does not catch anything, it is merely a precaution against total failure - if it cannot place the order / get/create the customer / clear the shoppingcart, it will just redirect you to the failure page.
            try
            {
                ShoppingCart Cart = Session["ShoppingCart"] as ShoppingCart;
                if (CustomerRepository.getInstance().GetAll().FirstOrDefault(x => x.Email == CustomerVM.Email) == null)
                {
                    CustomerRepository.getInstance().AddCustomer(CustomerVM);
                }
                OrderRepository.getInstance().AddOrder(Cart, CustomerVM.Email);
                Session["ShoppingCart"] = new ShoppingCart();
                return View();
            }
            catch
            {
                return RedirectToAction("Failure");
            }
            
        }
    }
}
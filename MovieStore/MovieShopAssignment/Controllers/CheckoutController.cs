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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CompleteCheckout(string CustomerMail)
        {
            if(CustomerRepository.getInstance().GetAll().FirstOrDefault(x => x.Email == CustomerMail) != null)
            {
                //This try catch does not catch any exceptions, it is merely a precaution against total failure - if it cannot place the order / get the customer's ID / clear the shoppingcart, it will just redirect you to the failure page.
                try
                {
                    ShoppingCart Cart = Session["ShoppingCart"] as ShoppingCart;
                    OrderRepository.getInstance().AddOrder(Cart, CustomerRepository.getInstance().GetAll().FirstOrDefault(x => x.Email == CustomerMail).ID);
                    Session["ShoppingCart"] = new ShoppingCart();
                    return View();
                }
                catch
                {
                    return RedirectToAction("Failure");
                }                
            }
            else
            {
                //It would be nice if it told you that the mail you typed in did not match a database entry, but for now it just sends you to the form to register a new customer without a warning
                return RedirectToAction("AddCustomer");
            }
        }
        public ActionResult Failure()
        {
            return View();
        }
        public ActionResult AddCustomer()
        {
            return View(new CustomerViewModel());
        }
        public ActionResult CompleteAddCustomer(CustomerViewModel CustomerVM)
        {
            CustomerRepository.getInstance().AddCustomer(CustomerVM);
            return RedirectToAction("CompleteCheckout", CustomerVM.Email);
        }
    }
}
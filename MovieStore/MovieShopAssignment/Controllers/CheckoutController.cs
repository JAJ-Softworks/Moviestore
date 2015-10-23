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
            //This try catch will attempt to create your order and clear the shopping cart for a new order, if it fails, it will just redirect you to a failure page.
            try
            {
                ShoppingCart Cart = Session["ShoppingCart"] as ShoppingCart;
                OrderRepository.getInstance().AddOrder(Cart, CustomerRepository.getInstance().GetAll().Where(x => x.Email.ToLower() == CustomerMail.ToLower()).FirstOrDefault().ID);
                Session["ShoppingCart"] = new ShoppingCart();
                return View(CustomerRepository.getInstance().GetAll().Where(x => x.Email.ToLower() == CustomerMail.ToLower()).FirstOrDefault());
            }
            catch
            {
                return RedirectToAction("Failure");
            }
        }
        public ActionResult GetCustomer(string CustomerMail)
        {
            if(CustomerRepository.getInstance().GetAll().Where(x => x.Email.ToLower() == CustomerMail.ToLower()).FirstOrDefault() != null)
            {
                return RedirectToAction("CompleteCheckout","Checkout", new { CustomerMail });
            }
            return RedirectToAction("AddCustomer");
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
            if(CustomerRepository.getInstance().GetAll().Where(x => x.Email.ToLower() == CustomerVM.Email.ToLower()).FirstOrDefault() == null)
            {
                CustomerRepository.getInstance().AddCustomer(CustomerVM);
            }
            return RedirectToAction("CompleteCheckout","Checkout", CustomerVM.Email);
        }
    }
}
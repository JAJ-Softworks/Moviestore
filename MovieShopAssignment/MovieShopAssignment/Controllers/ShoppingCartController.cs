using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;

namespace MovieShopAssignment.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            if(Session["ShoppingCart"] == null)
            {
                Session["ShoppingCart"] = new ShoppingCart();
            }
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            return View(cart);
        }
        public ActionResult Checkout()
        {
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Clear()
        {
            Session["ShoppingCart"] = new ShoppingCart();
            return RedirectToAction("Index");
        }
        public ActionResult Return()
        {
            return RedirectToAction("Index", "Movie");
        }
        public ActionResult Remove()
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            cart.RemoveOrderLine(cart.OrderLines.FirstOrDefault()); //Obviously not right, just testing
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
	}
}
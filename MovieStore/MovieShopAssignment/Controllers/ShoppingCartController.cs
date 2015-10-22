using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.ViewModels;

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
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Clear()
        {
            //We just clear the session when you clear the cart
            //Obviously not the smartest thing to do, but since the only thing the session saves is the cart, it works
            Session["ShoppingCart"] = new ShoppingCart(); 
            return RedirectToAction("Index");
        }
        public ActionResult Return()
        {
            return RedirectToAction("Index", "Movie");
        }
        public ActionResult Remove(int MovID)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            cart.RemoveOrderLine(cart.OrderLines.FirstOrDefault(x => x.MovieVM.Movie.Id == MovID));
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
        public ActionResult EditView(int Index)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            OrderLineViewModel Line = cart.OrderLines[Index];
            return View(Line);
        }
        public ActionResult Edit(int MovID, uint Amount)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            //The only accepted change is if the new amount is greater than 1. If not, it discards the change.
            if(Amount > 0)
            {
                cart.OrderLines.FirstOrDefault(x => x.MovieVM.Movie.Id == MovID).Amount = Amount;
            }
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
	}
}
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
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            Order newOrder = new Order() { OrderLines = cart.OrderLines, Date = DateTime.Now };
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
        public ActionResult Remove()
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            cart.RemoveOrderLine(cart.OrderLines.FirstOrDefault()); //Obviously not right, just testing
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditView(int Index)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            OrderLine Line = cart.OrderLines[Index];
            return View(Line);
        }
        [HttpPost]
        public ActionResult Edit(OrderLine Line)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            cart.OrderLines.FirstOrDefault(x => x.Movie == Line.Movie).Amount = Line.Amount;
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
	}
}
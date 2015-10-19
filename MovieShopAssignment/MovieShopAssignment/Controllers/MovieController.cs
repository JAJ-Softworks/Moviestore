using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;
//using MovieShopAssignment.ViewModels;

namespace MovieShopAssignment.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Index()
        {
            return View(Models.FakeDB.GetInstance().GetAllMovies());
        }
        public ActionResult AddToCart(int movID)
        {
            if (Session["ShoppingCart"] == null)
            {
                Session["ShoppingCart"] = new ShoppingCart();
            }
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            cart.OrderLines.Add(new OrderLine(FakeDB.GetInstance().FindMovieByID(movID), 1));
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
        
	}
}
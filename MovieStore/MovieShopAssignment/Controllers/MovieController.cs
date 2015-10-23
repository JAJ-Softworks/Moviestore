using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using MovieShopAssignment.Models;
using MovieShopAssignment.ViewModels;
//using MovieShopAssignment.ViewModels;
using MoviesStoreProxy.Repository;

namespace MovieShopAssignment.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        [ActionName("Index")]
        public ActionResult Index(int? GenreID)
        {
            if (GenreID != null)
            {
                return View(MovieRepository.getInstance().GetAll().Where(m => m.Genre.Id == GenreID));
            }
            return View(MovieRepository.getInstance().GetAll());
        }
        public ActionResult AddToCart(int movID)
        {
            if (Session["ShoppingCart"] == null)
            {
                Session["ShoppingCart"] = new ShoppingCart();
            }
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            if(cart.OrderLines.FirstOrDefault(x => x.MovieVM.Movie.Id == movID) != null)
            {
                cart.OrderLines.FirstOrDefault(x => x.MovieVM.Movie.Id == movID).Amount += 1;
            }
            else
            {
                cart.OrderLines.Add(new OrderLineViewModel(MovieRepository.getInstance().GetAll().FirstOrDefault(x => x.Movie.Id == movID),1));
            }
            Session["ShoppingCart"] = cart;
            return RedirectToAction("Index");
        }
        
	}
}
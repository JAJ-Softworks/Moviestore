using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;
//using MovieShopAssignment.ViewModels;
using MoviesStoreProxy.Repository;

namespace MovieShopAssignment.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Index(int? GenreID)
        {
            Facade fac = new Facade();
            if(GenreID != null)
            {
                //return View(Models.FakeDB.GetInstance().GetAllMovies().Where(m => m.Genre.ID == GenreID));
                return View(fac.GetMovieRepository().ReadAll().Where(m => m.Genre.Id == GenreID));
            }
            return View(fac.GetMovieRepository().ReadAll());
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
        //[HttpGet]
        //public ActionResult GenreChosen(int? GenreID)
        //{
        //    if(GenreID != null)
        //    {
        //        return View(Models.FakeDB.GetInstance().GetAllMovies().Where(g => g.Genre.ID == GenreID));
        //    }
        //    return RedirectToAction("Index");
        //}
        
	}
}
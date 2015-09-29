using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopAssignment.Models;

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
	}
}
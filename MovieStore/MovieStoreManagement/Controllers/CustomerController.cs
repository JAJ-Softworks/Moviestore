using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStoreManagement.Controllers
{
    public class CustomerController : Controller
    {
        Facade fac = new Facade();
        public ActionResult Index()
        {
            return View(fac.GetCustomerRepository().ReadAll());
        }

        // GET: Customer/Details
     //   public ActionResult Orders(int Id)
        //{
      //      return RedirectToAction("Index","Order", new  {cus= fac.GetOrderRepository().ReadAll().Where(x => x.CustomerId = fac.GetCustomerRepository().GetCustomer(Id) });
       // }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer cus, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetCustomerRepository().Add(cus);
                return RedirectToAction("Index");
            }
                return View();
            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cus = fac.GetCustomerRepository().GetCustomer(id);
            return View(cus);
        }

        // POST: Customer/Edit
        [HttpPost]
        public ActionResult Edit(Customer cus, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetCustomerRepository().UpdateCustomer(cus);
                return RedirectToAction("Index");
            }
            
                return View();
            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var cus = fac.GetCustomerRepository().GetCustomer(id);
            return View(cus);
        }

        // POST: Customer/Delete
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                fac.GetCustomerRepository().DeleteCustomer(id);
                return RedirectToAction("Index");
            }
                return View();
            
        }
    }
}

using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieStore.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customers
        private Facade facade = new Facade();

        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = facade.GetCustomerRepository().ReadAll();
            return View(customers);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            facade.GetCustomerRepository().Add(customer);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Customer c = facade.GetCustomerRepository().GetCustomer(Id);
            return View();

        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            facade.GetCustomerRepository().UpdateCustomer(customer);
            return Redirect("Index");

        }
        public ActionResult Delete(int customerId)
        {
            Customer c = facade.GetCustomerRepository().GetCustomer(customerId);
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        ///HTTPPost DeleteAccepted will be hit if the user presses yes on the delete page above.
        public ActionResult DeleteAccepted(int customerId)
        {
            facade.GetCustomerRepository().DeleteCustomer(customerId);
            return Redirect("index");
        }
    }
}
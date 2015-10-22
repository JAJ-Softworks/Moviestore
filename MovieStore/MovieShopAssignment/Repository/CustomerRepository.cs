using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieShopAssignment.ViewModels;
using MoviesStoreProxy.Repository;
using MoviesStoreProxy.Model;

namespace MovieShopAssignment.Repository
{
    public class CustomerRepository
    {
        private static CustomerRepository Instance;
        private List<CustomerViewModel> CustomerViewModels;
        private CustomerRepository()
        {


        }
        public List<CustomerViewModel> GetAll()
        {
            CustomerViewModels = new List<CustomerViewModel>();
            List<Customer> Customers = new MoviesStoreProxy.Repository.Facade().GetCustomerRepository().ReadAll();
            foreach (Customer cus in Customers)
            {
                CustomerViewModel newViewModel = new CustomerViewModel() { ID = cus.Id, FirstName = cus.FirstName, LastName = cus.LastName, Email = cus.Email, Address = cus.Address };
                CustomerViewModels.Add(newViewModel);
            }
            return CustomerViewModels;
        }
        public void AddCustomer(CustomerViewModel newViewCustomer)
        {
            Customer newCustomer = new Customer() { FirstName = newViewCustomer.FirstName, LastName = newViewCustomer.LastName, Address = newViewCustomer.Address, Email = newViewCustomer.Email, orders = new List<Order>() };
            new MoviesStoreProxy.Repository.Facade().GetCustomerRepository().Add(newCustomer);
        }
        public static CustomerRepository getInstance()
        {
            if (Instance == null)
                Instance = new CustomerRepository();
            return Instance;
        }
    }
}
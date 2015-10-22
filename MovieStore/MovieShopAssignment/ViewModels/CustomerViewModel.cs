using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopAssignment.ViewModels
{
    public class CustomerViewModel
    {
        //This view model exists only so that the CheckoutController would not have a reference to MovieStoreProxy.Model;
        //It functions exactly like the Customer in MovieStoreProxy.Model;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
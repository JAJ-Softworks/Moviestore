using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieShopAssignment.ViewModels;
using MoviesStoreProxy.Model;
using MoviesStoreProxy.Repository;

namespace MovieShopAssignment.Repository
{
    public class OrderRepository
    {
        private static OrderRepository Instance;
        private OrderRepository()
        {


        }
        public void AddOrder(ShoppingCart Cart, int CustomerID)
        {
            //Add the order
            Order newOrder = new Order() { Customer = new Facade().GetCustomerRepository().GetCustomer(CustomerID), date = DateTime.Now };
            new Facade().GetOrderRepository().Add(newOrder);
            //Add the orderlines
            int OrderID = new Facade().GetOrderRepository().ReadAll().Where(x => x.CustomerId == CustomerID).OrderBy(x => x.date).LastOrDefault().Id;
            List<OrderLine> OrderLines = new List<OrderLine>();
            foreach (OrderLineViewModel Line in Cart.OrderLines)
            {
                OrderLine newLine = new OrderLine() { MovieId = Line.MovieVM.Movie.Id, Amount = Line.Amount, OrderId = OrderID };
                new Facade().GetOrderLineRepository().Add(newLine);
            }
        }
        public static OrderRepository getInstance()
        {
            if (Instance == null)
                Instance = new OrderRepository();
            return Instance;
        }
    }
}
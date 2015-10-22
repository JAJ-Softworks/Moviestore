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
        public void AddOrder(ShoppingCart Cart)
        {
            List<OrderLine> OrderLines = new List<OrderLine>();
            foreach(OrderLineViewModel in Cart.OrderLines)
            {
                OrderLine
            }
            Order newOrder = new Order() { };
            new MoviesStoreProxy.Repository.Facade().GetOrderRepository().Add(newOrder);
        }
        public static OrderRepository getInstance()
        {
            if (Instance == null)
                Instance = new OrderRepository();
            return Instance;
        }
    }
}
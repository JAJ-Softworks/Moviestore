﻿using MoviesStoreProxy.Context;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MoviesStoreProxy.Repository
{
    public class OrderRepository
    { 
    public void Add(Order order)
    {

        using (var ctx = new MovieStoreContext())
        {

            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }
    }

        public List<Order> GetOrders(int id)
        {
            using (var ctx = new MovieStoreContext())
            {
                return ctx.Orders.Where(x => x.CustomerId == id).ToList();
            }
        }

        public List<Order> ReadAll()
    {
        using (var ctx = new MovieStoreContext())
        {

            return ctx.Orders.ToList();
        }
    }

    public Order GetOrder(int id)
    {
        using (var ctx = new MovieStoreContext())
        {
            return ctx.Orders.Include(x => x.Customer).Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public void UpdateOrder(Order order)
    {

        using (var ctx = new MovieStoreContext())
        {
            Order m = ctx.Orders.Where(x => x.Id == order.Id).First();
            m.Customer = order.Customer;
            m.CustomerId = order.CustomerId;
            m.orderLines = order.orderLines;
            m.date = order.date;
            m.Id = order.Id;
            ctx.SaveChanges();
        }
    }

    public void DeleteOrder(int id)
    {
        using (var ctx = new MovieStoreContext())
        {

            Order m = ctx.Orders.Where(x => x.Id == id).First();
            if (m != null)
                ctx.Orders.Remove(m);
            ctx.SaveChanges();
        }
    }
  }
}


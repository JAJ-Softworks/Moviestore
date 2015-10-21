using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Repository
{
    public class Facade {
        private MovieRepository movieRepo;

        public MovieRepository GetMovieRepository()
        {
            if (movieRepo == null)
            {
                movieRepo = new MovieRepository();
            }
            return movieRepo;
        }

        private CustomerRepository customerRepo;

        public CustomerRepository GetCustomerRepository()
        {
            if (customerRepo == null)
            {
                customerRepo = new CustomerRepository();
            }
            return customerRepo;
        }

        private GenreRepository genreRepo;

        public GenreRepository GetGenryRepository()
        {
            if (genreRepo == null)
            {
                genreRepo = new GenreRepository();
            }
            return genreRepo;
        }
    
        private OrderRepository orderRepo;

        public OrderRepository GetOrderRepository()
        {
            if (orderRepo == null)
            {
                orderRepo = new OrderRepository();
            }
            return orderRepo;
        }

        private OrderLineRepository orderLineRepo;
        public OrderLineRepository GetOrderLineRepository()
        {
            if(orderLineRepo == null)
            {
                orderLineRepo = new OrderLineRepository();
            }
            return orderLineRepo;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

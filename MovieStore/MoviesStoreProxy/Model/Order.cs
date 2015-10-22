using System;
using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using MoviesStoreProxy.Model;

namespace MoviesStoreProxy.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<OrderLine> orderLines { get; set; }
    }
}

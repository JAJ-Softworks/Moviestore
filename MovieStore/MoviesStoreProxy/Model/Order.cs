using MovieStoreTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime date{ get; set; }

        public int Customer { get; set; }

        public virtual List<OrderLine> orderLines { get; set; }
        public OrderLine OrderLine { get; internal set; }
    }
}

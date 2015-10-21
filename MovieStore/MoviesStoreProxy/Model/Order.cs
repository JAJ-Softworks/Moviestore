using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime date{ get; set; }

        public virtual Customer customer { get; set; }

        public virtual List<OrderLine> orderLines { get; set; }

    }
}

using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreProxy.Model
{
   public  class OrderLine
    {
        
        [Column(Order = 1), Key, ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int Amount { get; set; }
        [Column(Order = 2), Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }

}

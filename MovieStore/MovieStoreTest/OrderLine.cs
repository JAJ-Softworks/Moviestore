using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreTest
{
   public  class OrderLine
    {
        public Movie Movie { get;  set; }
        public int Amount { get; set; }
    }
}

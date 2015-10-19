using MoviesStoreProxy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesStoreProxy.Context 
{
   public class GenreDBInitialize : DropCreateDatabaseAlways<MovieStoreContext>
    {
        protected override void Seed(MovieStoreContext context)
        {
            IList<Genre> geners = new List<Genre>();

          
            
            foreach (Genre g in geners)
               context.Gernes.Add(g);

            base.Seed(context);
        }
    }
}
    }
}

using MoviesStoreProxy.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreTest
{
    [TestFixture]
    public class OrderLineTest
    {
        [Test]
        public void orderline_properties_set_test()
        { 
            OrderLine line = new OrderLine();
            var movie = new Movie() { Id = 1, Title = "Bog Foot" };
            line.Movie = movie;
            line.Amount = 10;

            Assert.AreEqual(line.Movie, movie, "My movie ");
            Assert.AreEqual(line.Amount, 10, "Amount should be 10");

    }
 }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MovieShopAssignment.Models;

namespace MovieShopAssignmentTest
{
    [TestFixture]
    public class OrderLineTester
    {
        [Test]
        public void OrderLinePropertiesSetTest()
        {
            Movie mov = new Movie() { ID = 0, Title = "Tits Galore", Genre = FakeDB.GetInstance().FindGenreByName("Comedy"), ImageURL = null, TrailerURL = null, Price = (59.99), Year = 1993 };
            OrderLine line = new OrderLine(mov, 1);

            Assert.AreEqual(line.Movie, mov);
            Assert.AreEqual(line.Amount,1);
        }
    }
}

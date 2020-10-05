using BusinessObjects;
using NUnit.Framework;
using System.IO;
using System.Linq;

namespace NUnitTestProject1
{
    public class OrderListTests
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OrderList_DeserialiseCorrectly()
        {
            var incoming = File.ReadAllText("testData.OrderCollection.json");
            var actual = OrderList.FromJson(incoming);
            Assert.AreEqual(5, actual.Orders.Count);
            var first = actual.Orders.First();
            OrderTests.AssertOrderFromCustomerIdAsExpected(first);
        }
    }
}
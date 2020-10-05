using BusinessObjects;
using NUnit.Framework;
using System.IO;
using System.Linq;

namespace NUnitTestProject1
{
    public class OrderTests
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Order_DeserialisesCorrectly()
        {
            var incoming = File.ReadAllText("testData.SingleOrder.json");
            var actual = Order.FromJson(incoming);
            AssertOrderFromCustomerIdAsExpected(actual);

        }

        internal static void AssertOrderFromCustomerIdAsExpected(Order actual)
        {
            Assert.AreEqual(1, actual.Customer.Id);
            Assert.AreEqual("US", actual.Customer.Country);
            Assert.AreEqual("TX", actual.Customer.State);
            Assert.AreEqual("Fedex", actual.Customer.Carrier);
            Assert.AreEqual(2, actual.OrderLines.Length);
            Assert.AreEqual(Product.Gas, actual.OrderLines[0].Product);
            Assert.AreEqual(100, actual.OrderLines[0].Cost);
            Assert.AreEqual(Product.Tv, actual.OrderLines[1].Product);
            Assert.AreEqual(200, actual.OrderLines[1].Cost);
        }       
    }
}
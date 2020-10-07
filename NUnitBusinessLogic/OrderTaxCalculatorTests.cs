using BusinessLogic;
using BusinessLogic.Factory;
using BusinessObjects;
using NUnit.Framework;
using System.IO;

namespace NUnitBusinessLogic
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        

        [Test]
        public void GivenSingleOrderFromTestData_TaxCalculatorCalculatesTaxOf_10_Dollars()
        {
            
            var incoming = File.ReadAllText("testData.SingleOrder.json");
            var actual = Order.FromJson(incoming);
            IOrderTaxCalculator taxCalculator = new OrderTaxCalculator();

            Assert.That(taxCalculator.CalculateTaxForOrder(actual), Is.EqualTo(10));
        }

        [Test]
        public void GivenOrderCollectionFromTestData_TaxCalculatorCalculatesTaxOf_183_Dollars()
        {

            var incoming = File.ReadAllText("testData.OrderCollection.json");
            var actual = OrderList.FromJson(incoming);
            IOrderTaxCalculator taxCalculator = new OrderTaxCalculator();

            Assert.That(taxCalculator.CalculateTaxForOrders(actual.Orders), Is.EqualTo(183));
        }
    }
}
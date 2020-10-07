using BusinessLogic;
using BusinessLogic.Interfaces;
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
        public void GivenValue_200_And_Rate_10_TaxCalculator_CalculateTax_Returns_20()
        {
            ITaxCalculator taxCalculator = new BaseTaxCalculator();

            Assert.AreEqual(20, taxCalculator.CalculateTax(200, 10));


        }

        public void GivenSingleOrderFromTestData_TaxCalculatorCalculatesTaxOf_10_Dollars()
        {
            ITaxCalculator taxCalculator = new BaseTaxCalculator();
            var incoming = File.ReadAllText("testData.SingleOrder.json");
            var actual = Order.FromJson(incoming);

            Assert.That(taxCalculator.CalculateTaxForOrder(actual), Is.EqualTo(10));
        }
    }
}
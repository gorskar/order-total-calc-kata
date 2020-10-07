using BusinessLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitBusinessLogic
{
    [TestFixture]
    public class BaseTaxCalculatorTests
    {
        [Test]
        public void GivenValue_200_And_Rate_10_TaxCalculator_CalculateTax_Returns_20()
        {
            ITaxCalculator taxCalculator = new BaseTaxCalculator();

            Assert.AreEqual(20, taxCalculator.CalculateTaxBasedOnValueAndTaxRate(200, 10));


        }
    }
}

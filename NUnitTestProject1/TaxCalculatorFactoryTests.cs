using BusinessLogic;
using BusinessLogic.Factory;
using BusinessObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    public class TaxCalculatorFactoryTests
    {
        [Test]
        public void Given_Order_For_Texas_TaxCalculatorFactory_Gives_TexasTaxCalculator()
        {

            var customer = new Customer() { Country = "US", State = "TX" };

            var taxCalc = TaxCalculatorFactory.Create(customer);

            Assert.That(taxCalc, Is.InstanceOf<TexasTaxCalculator>());
        }
    }
}

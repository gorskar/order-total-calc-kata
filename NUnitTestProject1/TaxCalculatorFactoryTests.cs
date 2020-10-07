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
            var incoming = File.ReadAllText("testData.SingleOrder.json");
            var actual = Order.FromJson(incoming);

            var taxCalc = TaxCalculatorFactory.Create(actual);

            Assert.That(taxCalc, Is.InstanceOf<TexasTaxCalculator>());
        }
    }
}

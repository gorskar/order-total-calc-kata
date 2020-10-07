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
        public void Given_Order_Customer_In_Texas_TaxCalculatorFactory_Gives_TexasTaxCalculator()
        {

            var customer = new Customer() { Country = "US", State = "TX" };

            var taxCalc = TaxCalculatorFactory.Create(customer);

            Assert.That(taxCalc, Is.InstanceOf<TexasTaxCalculator>());
        }

        [Test]
        public void Given_Order_Customer_In_NewYork_TaxCalculatorFactory_Gives_NewYorkTaxCalculator()
        {

            var customer = new Customer() { Country = "US", State = "NY" };

            var taxCalc = TaxCalculatorFactory.Create(customer);

            Assert.That(taxCalc, Is.InstanceOf<NewYorkTaxCalculator>());
        }

        [Test]
        public void Given_Order_Customer_In_UK_TaxCalculatorFactory_Gives_TexasUKCalculator()
        {

            var customer = new Customer() { Country = "UK", State = "Lancs" };

            var taxCalc = TaxCalculatorFactory.Create(customer);

            Assert.That(taxCalc, Is.InstanceOf<UkTaxCalculator>());
        }

        [Test]
        public void Given_Order_Customer_In_France_TaxCalculatorFactory_Gives_TexasFranceCalculator()
        {

            var customer = new Customer() { Country = "FR", State = "Paris" };

            var taxCalc = TaxCalculatorFactory.Create(customer);

            Assert.That(taxCalc, Is.InstanceOf<FranceTaxCalculator>());
        }
    }
}

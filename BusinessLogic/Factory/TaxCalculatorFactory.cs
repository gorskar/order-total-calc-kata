using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Factory
{
    public static class TaxCalculatorFactory
    {
        public static ITaxCalculator Create(Customer customer)
        {
            
            switch(customer.Country)
            {
                case "US":
                    switch (customer.State)
                    {
                        case "TX": return new TexasTaxCalculator();
                        case "NY": return new NewYorkTaxCalculator();
                        default: return new UsTaxCalculator();
                    }
                case "UK":
                    return new UkTaxCalculator();
                case "FR":
                    return new FranceTaxCalculator();
            }
            throw new ArgumentException("order had invalid region");
        }
    }
}

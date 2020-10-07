using BusinessLogic.Interfaces;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Factory
{
    public static class TaxCalculatorFactory
    {
        public static ITaxCalculator Create(Order order)
        {
            ITaxCalculator result;
            switch(order.Customer.Country)
            {
                case "US":
                    switch (order.Customer.State)
                    {
                        case "TX": return new TexasTaxCalculator(); 
                        default: return new UsTaxCalculator();
                    }
                    
            }
            throw new ArgumentException("order had invalid region");
        }
    }
}

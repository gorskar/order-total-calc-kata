using BusinessLogic.Interfaces;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class BaseTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(int value, int percentageRate)
        {
            double result = 0;
            result = value * percentageRate / 100;
            return result;
        }

        public bool CalculateTaxForOrder(Order actual)
        {
            throw new NotImplementedException();
        }
    }
}

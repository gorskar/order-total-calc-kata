using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface ITaxCalculator
    {
        double CalculateTax(int v1, int v2);
        bool CalculateTaxForOrder(Order actual);
    }
}

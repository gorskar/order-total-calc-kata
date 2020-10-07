using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class FranceTaxCalculator : BaseTaxCalculator
    {
        public override decimal GetTaxPercentageForProductCategory(ProductCategory productCategory)
        {
            decimal taxPercentage = 18;
            return taxPercentage;
        }
    }
}

using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class UkTaxCalculator : BaseTaxCalculator
    {
        public override decimal GetTaxPercentageForProductCategory(ProductCategory productCategory)
        {
            decimal taxPercentage = 0;
            switch (productCategory)
            {
                case ProductCategory.FossilFuels: taxPercentage = 5; break;
                case ProductCategory.Electronics: taxPercentage = 20; break;
            }
            return taxPercentage;
        }
    }
}

using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class UsTaxCalculator : BaseTaxCalculator
    {
        public override decimal GetTaxPercentageForProductCategory(ProductCategory productCategory)
        {
            decimal taxPercentage = 0;
            if (productCategory == ProductCategory.Electronics) { taxPercentage = 5; }
            return taxPercentage;
        }
    }
}

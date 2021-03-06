﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class TexasTaxCalculator : UsTaxCalculator
    {
        public override decimal GetTaxPercentageForProductCategory(ProductCategory productCategory)
        {
            decimal taxPercent = base.GetTaxPercentageForProductCategory(productCategory);
            if (productCategory == ProductCategory.FossilFuels) { taxPercent = 0; }
            return taxPercent;
        }
    }
}

using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BusinessLogic
{
    public class BaseTaxCalculator : ITaxCalculator
    {
        

        public decimal CalculateTaxForOrder(Order order)
        {
            decimal totalTax = 0;

            //perform the steps
            //1. Get the orderLines
            var orderLines = GetOrderLinesFromOrder(order);
            foreach( var orderLine in orderLines )
            {
                //2. Get the product Category
                ProductCategory category = GetProductCategory(orderLine.Product);

                //3. Get the taxPercentage
                decimal taxPercentage = GetTaxPercentageForProductCategory(category);

                //4. Calculate the tax
                decimal taxAmount = CalculateTaxBasedOnValueAndTaxRate(orderLine.Cost, taxPercentage);

                //5. Add tax to the total
                totalTax = AddTaxToTotal(totalTax, taxAmount);
            }
            return totalTax;
        }

        public OrderLine[] GetOrderLinesFromOrder(Order order)
        {
            return order.OrderLines;
        }

        public ProductCategory GetProductCategory(Product product)
        {
            switch (product)
            {
                case Product.Gas: return ProductCategory.FossilFuels;
                case Product.Tv: return ProductCategory.Electronics;
            }
            throw new ArgumentException("Product was not recognised");
        }

        public virtual decimal GetTaxPercentageForProductCategory(ProductCategory productCategory)
        {
            return 0;
        }


        public decimal CalculateTaxBasedOnValueAndTaxRate(long value, decimal percentageRate)
        {
            decimal result = 0;
            result = value * percentageRate / 100;
            return result;
        }

        public decimal AddTaxToTotal(decimal currentTotal, decimal taxToAdd)
        {
            return currentTotal + taxToAdd;
        }
    }
}

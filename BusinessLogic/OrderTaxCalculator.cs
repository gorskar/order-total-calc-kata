using BusinessLogic.Factory;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class OrderTaxCalculator : IOrderTaxCalculator
    {
        public decimal CalculateTaxForOrders(IEnumerable<Order> orders)
        {
            decimal totalTax = 0;
            totalTax = orders.Sum(o => CalculateTaxForOrder(o));
            return totalTax;
        }

        public decimal CalculateTaxForOrder(Order order)
        {
            ITaxCalculator calc = TaxCalculatorFactory.Create(order.Customer);
            return calc.CalculateTaxForOrder(order);
        }
    }
}

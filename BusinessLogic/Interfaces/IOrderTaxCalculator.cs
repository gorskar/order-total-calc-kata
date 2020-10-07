using BusinessObjects;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IOrderTaxCalculator
    {
        public decimal CalculateTaxForOrders(IEnumerable<Order> orders);
        public decimal CalculateTaxForOrder(Order order);
    }
}
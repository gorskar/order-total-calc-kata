using BusinessObjects;

namespace BusinessLogic
{
    public interface ITaxCalculator
    {
        decimal CalculateTaxForOrder(Order order);
        decimal CalculateTaxBasedOnValueAndTaxRate(long value, decimal percentageRate);
    }
}
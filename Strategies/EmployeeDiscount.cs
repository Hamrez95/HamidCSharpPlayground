using HamidCSharpPlayground.Strategies;

namespace HamidCSharpPlayground
{
    public class EmployeeDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.2m; // 20% تخفیف
        }
    }
}

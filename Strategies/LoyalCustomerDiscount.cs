namespace HamidCSharpPlayground.Strategies
{
    public class LoyalCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.05m; // 5% تخفیف
        }
    }
}

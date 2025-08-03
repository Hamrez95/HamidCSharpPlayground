namespace HamidCSharpPlayground.Strategies
{
    public class GoldCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.10m; // 10% تخفیف
        }
    }
}

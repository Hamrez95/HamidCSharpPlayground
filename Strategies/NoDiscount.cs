namespace HamidCSharpPlayground.Strategies
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return 0; // No discount applied
        }
    }
}

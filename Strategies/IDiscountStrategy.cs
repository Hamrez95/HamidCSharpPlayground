namespace HamidCSharpPlayground.Strategies
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal totalAmount);
    }
}


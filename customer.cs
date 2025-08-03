using HamidCSharpPlayground.Strategies;

namespace HamidCSharpPlayground
{
    public class Customer
    {
        public string Name { get; set; }
        private IDiscountStrategy _discountStrategy;

        public Customer(string name, IDiscountStrategy discountStrategy)
        {
            Name = name;
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            _discountStrategy = strategy;
        }

        public decimal GetPayableAmount(decimal totalAmount)
        {
            var discount = _discountStrategy.CalculateDiscount(totalAmount);
            return totalAmount - discount;
        }
    }
}

using HamidCSharpPlayground.Strategies;

namespace HamidCSharpPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 100m;

            Console.WriteLine("Enter your name :");
            var customerName = Console.ReadLine();

            Console.WriteLine("Please choose your Plan : Employee, Gold, Loyal");
            var plan = Console.ReadLine();

            IDiscountStrategy discountStrategy;

            if(plan == "Employee")
            {
                discountStrategy = new EmployeeDiscount();
            }
            else if (plan == "Gold")
            {
                discountStrategy = new GoldCustomerDiscount();
            }
            else if (plan == "Loyal")
            {
                discountStrategy = new LoyalCustomerDiscount();
            }
            else
            {
                discountStrategy = new NoDiscount();
            }

            var customer1 = new Customer(customerName, discountStrategy);
         

            Console.WriteLine($"{ customer1.Name} should pay { customer1.GetPayableAmount(total)} Toman");
        
        }
    }
}

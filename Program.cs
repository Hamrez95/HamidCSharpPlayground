using HamidCSharpPlayground.Strategies;

namespace HamidCSharpPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 100m;

            var customer1 = new Customer("Hamidreza", new NoDiscount());
            var customer2 = new Customer("Ali", new LoyalCustomerDiscount());
            var customer3 = new Customer("Sara", new GoldCustomerDiscount());
            var customer4 = new Customer("Reza", new EmployeeDiscount());

            Console.WriteLine($"{ customer1.Name} should pay { customer1.GetPayableAmount(total)} Toman");
            Console.WriteLine($"{ customer2.Name} should pay { customer2.GetPayableAmount(total)} Toman");
            Console.WriteLine($"{ customer3.Name} should pay { customer3.GetPayableAmount(total)} Toman");
            Console.WriteLine($"{ customer4.Name} should pay { customer4.GetPayableAmount(total)} Toman");
        }
    }
}

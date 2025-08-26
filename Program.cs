using HamidCSharpPlayground.Strategies;
using static HamidCSharpPlayground.Program;

namespace HamidCSharpPlayground
{
    internal class Program
    {
        internal enum Plan
        {
            Employee,
            Gold,
            Loyal
        }
        static void Main(string[] args)
        {
            var total = 100m;

            Console.WriteLine("Enter your name :");
            var customerName = Console.ReadLine();

            Console.WriteLine("Please choose your Plan : Employee, Gold, Loyal");
            var strPlan = Console.ReadLine();
            Plan plan = (Plan)Enum.Parse(typeof(Plan), strPlan);

            IDiscountStrategy strategy = PlanFactory.Create(plan);
            var customer1 = new Customer(customerName, strategy);

            Console.WriteLine($"{customer1.Name} should pay {customer1.GetPayableAmount(total)} Toman");
        }
    }

    internal static class PlanFactory
    {
        //public PlanFactory(string plan)
        //{
        //    switch (plan)
        //    {
        //        case "Employee":
        //            Strategy = new EmployeeDiscount();
        //            break;
        //        case "Gold":
        //            Strategy = new GoldCustomerDiscount();
        //            break;
        //        case "Loyal":
        //            Strategy = new LoyalCustomerDiscount();
        //            break;
        //        default:
        //            Strategy = new NoDiscount();
        //            break;
        //    }
        //}

        //public IDiscountStrategy Strategy { get; }


        public static IDiscountStrategy Create(Plan plan)
        {
            switch (plan)
            {
                case Plan.Employee:
                    return new EmployeeDiscount();
                case Plan.Gold:
                    return new GoldCustomerDiscount();
                case Plan.Loyal:
                    return new LoyalCustomerDiscount();
                default:
                    return new NoDiscount();
            }
        }
    }
}


using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int n = 2;
            double Total = 0;
            double priceForCoffee = 0;
            double priceForCoffee2 = 0;
            double totalWhileCycle = 0;
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            priceForCoffee = ((days * capsulesCount) * pricePerCapsule);
            Console.WriteLine($"The price for the coffee is: ${priceForCoffee:f2}");

            while (n <= N)
            {
                //((daysInMonth * capsulesCount) * pricePerCapsule)
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                priceForCoffee2 = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${priceForCoffee2:f2}");
                totalWhileCycle += priceForCoffee2; 
                n++;
            }

            Total += priceForCoffee + totalWhileCycle;
            Console.WriteLine($"Total: ${Total:f2}");
        }
    }
}

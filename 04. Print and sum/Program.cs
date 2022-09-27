namespace _04._Print_and_sum
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumer = int.Parse(Console.ReadLine());
            int endNumer = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumer; i <= endNumer; i++)
            {
                Console.Write($"{i} ");
                sum += i; 
            }
            Console.WriteLine("");
            int totalSum = sum;
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}

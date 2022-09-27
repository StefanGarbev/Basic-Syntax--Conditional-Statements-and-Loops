using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int facturial = 1;
            int numCopy = number;
            int sum = 0;

            while (numCopy > 0)
            {
                int digit = numCopy % 10;
                numCopy = numCopy / 10;
                facturial = 1;
                for (int i = 2; i <= digit; i++)
                {
                    facturial *= i;
                }
                
                sum += facturial;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoneyJohnHas = double.Parse(Console.ReadLine());
            int countOfStudent = int.Parse(Console.ReadLine());
            double priceOfLightsabers;
            double singleLightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice;
            double singleRobePrice = double.Parse(Console.ReadLine());
            double beltsPrice;
            double singleBeltPrice = double.Parse(Console.ReadLine());
            double Total;

            priceOfLightsabers = (countOfStudent + Math.Ceiling(countOfStudent * 0.1)) * singleLightsaberPrice;
            robesPrice = countOfStudent * singleRobePrice;
            beltsPrice = countOfStudent * singleBeltPrice - ((countOfStudent/6) * singleBeltPrice);

            Total = priceOfLightsabers + robesPrice + beltsPrice;
            if (amountOfMoneyJohnHas >= Total)
            {
                Console.WriteLine($"The money is enough - it would cost {Total:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Total - amountOfMoneyJohnHas:f2}lv more.");
            }
        }
    }
}

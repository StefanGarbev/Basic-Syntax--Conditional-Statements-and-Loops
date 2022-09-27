 using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double TotalPrice;

            double headsetCnt = lostGameCount / 2;
            double mouseCnt = lostGameCount / 3;
            double keyboardCnt = lostGameCount / 6;
            double displayCnt = lostGameCount / 12;

            double headsetPriceTotal = headsetPrice * headsetCnt;
            double mousePriceTotal = mousePrice * mouseCnt;
            double keyboardPriceTotal = keyboardPrice * keyboardCnt;
            double displayPriceTotal = displayPrice * displayCnt;

            TotalPrice = headsetPriceTotal + mousePriceTotal + keyboardPriceTotal + displayPriceTotal;

            Console.WriteLine($"Rage expenses: {TotalPrice:f2} lv.");
        }
    }
}

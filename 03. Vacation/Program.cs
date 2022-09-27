

namespace _03._Vacation
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroupe = Console.ReadLine();
            string dayofStay = Console.ReadLine();
            double price = 0;
            switch (typeOfGroupe)
            {
                case "Students":
                    if (countOfPeople >= 30 && dayofStay == "Friday")
                    {
                        price = ((countOfPeople * 8.45) - (countOfPeople * 8.45 * 0.15));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 30 && dayofStay == "Friday")
                    {
                        price = countOfPeople * 8.45;
                        Console.WriteLine($"Total price: {price:f2}");
                    }

                    else if (countOfPeople >= 30 && dayofStay == "Saturday")
                    {
                        price = ((countOfPeople * 9.8) - (countOfPeople * 9.8 * 0.15));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 30 && dayofStay == "Saturday")
                    {
                        price = countOfPeople * 9.8;
                        Console.WriteLine($"Total price: {price:f2}");
                    }

                    else if (countOfPeople >= 30 && dayofStay == "Sunday")
                    {
                        price = ((countOfPeople * 10.46) - (countOfPeople * 10.46 * 0.15));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 30 && dayofStay == "Sunday")
                    {
                        price = countOfPeople * 10.46;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Business":
                    if (countOfPeople >= 100 && dayofStay == "Friday")
                    {
                        price = ((countOfPeople * 10.90) - (10 * 10.90));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 100 && dayofStay == "Friday")
                    {
                        price = countOfPeople * 10.90;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople >= 100 && dayofStay == "Saturday")
                    {
                        price = ((countOfPeople * 15.60) - (10 * 15.60));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 100 && dayofStay == "Saturday")
                    {
                        price = countOfPeople * 15.60;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople >= 100 && dayofStay == "Sunday")
                    {
                        price = ((countOfPeople * 16) - (10 * 16));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 100 && dayofStay == "Sunday")
                    {
                        price = countOfPeople * 16;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Regular":
                    if (countOfPeople >= 10 && countOfPeople <= 20 && dayofStay == "Friday")
                    {
                        price = ((countOfPeople * 15) - (countOfPeople * 15 * 0.05));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 10 || countOfPeople > 20 && dayofStay == "Friday")
                    {
                        price = countOfPeople * 15;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople >= 10 && countOfPeople <= 20 && dayofStay == "Saturday")
                    {
                        price = ((countOfPeople * 20) - (countOfPeople * 20 * 0.05));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 10 || countOfPeople > 20 && dayofStay == "Saturday")
                    {
                        price = countOfPeople * 20;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople >= 10 && countOfPeople <= 20 && dayofStay == "Sunday")
                    {
                        price = ((countOfPeople * 22.5) - (countOfPeople * 22.5 * 0.05));
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else if (countOfPeople < 10 || countOfPeople > 20 && dayofStay == "Sunday")
                    {
                        price = countOfPeople * 22.5;
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
            }
        }
    }
}

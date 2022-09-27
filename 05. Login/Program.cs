using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            string reversedUsernameIsPassword = string.Empty;
            int totalFailTriesCnt = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                char DigitsfromName = userName[i];
                reversedUsernameIsPassword += DigitsfromName;
            }

            while (password != reversedUsernameIsPassword)
            {
                totalFailTriesCnt++;
                if (totalFailTriesCnt >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                password = Console.ReadLine();
            }
            if (password == reversedUsernameIsPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}

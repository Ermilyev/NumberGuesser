using System;

namespace NumberGuesser
{
    class Program
    {
        internal static void Main(string[] args)
        {
            AppInfo.getAppInfo();
            GreetUser();
            GameEngine.isGaming();
        }
        private static void GreetUser()
        {
            Console.WriteLine("What is your name");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello {inputName}, let's play the game...");
        }
    }
}


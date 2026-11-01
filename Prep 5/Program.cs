using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }

        // Displays a welcome message.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Asks the user for their name and returns it.
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine() ?? "";

            return name;
        }

        // Asks the user for an integer and safely checks the input.
        static int PromptUserNumber()
        {
            while (true)
            {
                Console.Write("Please enter your favorite number: ");
                string response = Console.ReadLine() ?? "";

                if (int.TryParse(response, out int number))
                {
                    return number;
                }

                Console.WriteLine("Please enter a valid whole number.");
            }
        }

        // Calculates and returns the square of a number.
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Displays the user's name and the square of their number.
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}
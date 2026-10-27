using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // Continue until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();

                // Check whether the input is a valid integer
                if (int.TryParse(userInput, out guess))
                {
                    // Make sure the guess is between 1 and 100
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                        guess = -1;
                        continue;
                    }

                    // Count each valid guess
                    guessCount++;

                    // Give the user a hint
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    guess = -1;
                }
            }

            // Display the total number of guesses
            Console.WriteLine($"It took you {guessCount} guesses.");
        }
    }
}

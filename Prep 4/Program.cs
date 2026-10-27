using System;
using System.Collections.Generic;
using System.Linq;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the numbers
            List<int> numbers = new List<int>();
            int userNumber = -1;

            Console.WriteLine("Enter a list of numbers.");
            Console.WriteLine("Type 0 when you are finished.");

            // Get numbers from the user
            while (userNumber != 0)
            {
                Console.Write("Enter number: ");
                string response = Console.ReadLine();

                if (int.TryParse(response, out userNumber))
                {
                    if (userNumber != 0)
                    {
                        numbers.Add(userNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    userNumber = -1;
                }
            }

            // Check whether the user entered any numbers
            if (numbers.Count > 0)
            {
                // Calculate the sum and average
                int sum = numbers.Sum();
                double average = (double)sum / numbers.Count;

                // Find the largest number
                int max = numbers.Max();

                // Find the smallest positive number
                int smallestPositive = numbers
                    .Where(number => number > 0)
                    .DefaultIfEmpty(-1)
                    .Min();

                // Sort the list
                numbers.Sort();

                // Display the results
                Console.WriteLine();
                Console.WriteLine("Results:");
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average:F2}");
                Console.WriteLine($"The largest number is: {max}");

                if (smallestPositive > 0)
                {
                    Console.WriteLine(
                        $"The smallest positive number is: {smallestPositive}");
                }
                else
                {
                    Console.WriteLine("There are no positive numbers in the list.");
                }

                Console.WriteLine("The sorted list is:");

                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
        }
    }
}
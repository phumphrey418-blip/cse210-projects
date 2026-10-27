using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print blank line for clean spacing
        Console.WriteLine();

        // Output formatted name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}

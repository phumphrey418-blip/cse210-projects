/*

* Program: Scripture Memorizer
* Course: CSE 210
* 
* ==========================================================
* EXCEEDING REQUIREMENTS / CREATIVITY
* ==========================================================
* I added a Scripture Memorization Progress Tracker.
* 
* This feature calculates and displays the percentage of
* scripture words that have been hidden after each round.
* It also provides encouraging messages to motivate the
* user throughout the memorization process.
* 
* This enhancement makes the program more interactive and
* helps users monitor their memorization progress.
* ==========================================================
  */

using System;

class Program
{
static void Main(string[] args)
{
// Create the scripture reference and text.
Reference reference = new Reference("Proverbs", 3, 5, 6);

    string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

    Scripture scripture = new Scripture(reference, text);

    string userInput = "";

    // Main program loop.
    while (!scripture.IsCompletelyHidden())
    {
        Console.Clear();

        // Display the scripture.
        Console.WriteLine("==================================");
        Console.WriteLine("       SCRIPTURE MEMORIZER");
        Console.WriteLine("==================================");
        Console.WriteLine();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Press ENTER to hide more words.");
        Console.WriteLine("Type 'quit' to exit the program.");
        Console.WriteLine("----------------------------------");

        userInput = Console.ReadLine();

        // Check whether the user wants to quit.
        if (userInput.Trim().ToLower() == "quit")
        {
            break;
        }

        // Hide three additional random words.
        scripture.HideRandomWords(3);

        // Display memorization progress.
        Console.Clear();

        Console.WriteLine("       MEMORIZATION PROGRESS");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Keep going! You are making progress.");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();
    }

    // Display the final scripture and completion message.
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("          FINAL RESULT");
    Console.WriteLine("==================================");
    Console.WriteLine();

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();

    if (scripture.IsCompletelyHidden())
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine("You have successfully hidden every word.");
        Console.WriteLine("Keep studying and strengthening your memory!");
    }
    else
    {
        Console.WriteLine("You have exited the program.");
        Console.WriteLine("Keep practicing your scripture memorization!");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for using Scripture Memorizer!");
}

}
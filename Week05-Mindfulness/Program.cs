using System;
using System.Collections.Generic;

// Creativity & Exceeding Requirements:
// 1. Tracks how many times each activity is completed during the current session and displays a summary on exit.
// 2. Uses non-repeating random selection for prompts and reflection questions so every item is shown at least once before repeating in a session.

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> activityCounts = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflection Activity", 0 },
            { "Listing Activity", 0 }
        };

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine()?.Trim() ?? "";

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityCounts["Breathing Activity"]++;
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    activityCounts["Reflection Activity"]++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityCounts["Listing Activity"]++;
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Session Activity Log:");
                    foreach (KeyValuePair<string, int> entry in activityCounts)
                    {
                        Console.WriteLine($"  {entry.Key}: {entry.Value}");
                    }
                    Console.Write("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Session Summary:");
                    foreach (KeyValuePair<string, int> entry in activityCounts)
                    {
                        Console.WriteLine($"  {entry.Key}: {entry.Value}");
                    }
                    Console.WriteLine("\nThank you for practicing mindfulness. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option (1-5).");
                    System.Threading.Thread.Sleep(1500);
                    break;
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("       STUDENT GRADE CALCULATOR");
        Console.WriteLine("==================================");

        // Ask the user to enter their grade percentage
        Console.Write("Enter your grade percentage (0-100): ");
        string input = Console.ReadLine();

        // Validate the user's input
        if (!int.TryParse(input, out int percent) ||
            percent < 0 || percent > 100)
        {
            Console.WriteLine("Invalid input. Please enter a whole number between 0 and 100.");
            return;
        }

        // Determine the letter grade
        string letter;

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine whether the grade receives a plus or minus
        string sign = "";
        int lastDigit = percent % 10;

        if (letter == "A" && percent < 93)
        {
            sign = "-";
        }
        else if (letter == "B" || letter == "C" || letter == "D")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Display the student's results
        Console.WriteLine();
        Console.WriteLine("========== GRADE REPORT ==========");
        Console.WriteLine($"Percentage: {percent}%");
        Console.WriteLine($"Letter Grade: {letter}{sign}");

        // Determine whether the student passed
        if (percent >= 70)
        {
            Console.WriteLine("Status: PASSED");
            Console.WriteLine("Congratulations! Keep up the good work.");
        }
        else
        {
            Console.WriteLine("Status: NOT PASSED");
            Console.WriteLine("Keep practicing and reviewing your lessons.");
        }

        // Give feedback based on the percentage
        if (percent >= 90)
        {
            Console.WriteLine("Feedback: Excellent performance!");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Feedback: Very good work!");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Feedback: Good job! Keep improving.");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Feedback: You are making progress. Keep studying.");
        }
        else
        {
            Console.WriteLine("Feedback: Review the course materials and seek help when needed.");
        }

        Console.WriteLine("==================================");
        Console.WriteLine("Thank you for using the Grade Calculator!");
    }
}
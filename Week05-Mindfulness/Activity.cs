using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        int seconds = 0;
        while (seconds <= 0)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out seconds) || seconds <= 0)
            {
                Console.WriteLine("Please enter a positive whole number of seconds.");
                seconds = 0;
            }
        }

        _duration = seconds;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[index % frames.Count]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            index++;
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            string digits = i.ToString();
            for (int d = 0; d < digits.Length; d++)
            {
                Console.Write("\b \b");
            }
        }
    }
}

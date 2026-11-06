using System;
using System.Collections.Generic;

public class PromptGenerator
{
private List<string> _prompts;
private Random _random;

public PromptGenerator()
{
    _random = new Random();

    _prompts = new List<string>
    {
        "What is something you are grateful for today?",
        "What was the best part of your day?",
        "What challenge did you overcome today?",
        "What new thing did you learn today?",
        "Who made a positive difference in your life?",
        "What is one thing you want to improve tomorrow?",
        "When did you feel closest to God today?",
        "What made you smile today?",
        "What lesson did you learn today?",
        "What is one goal you want to achieve?"
    };
}

public string GetRandomPrompt()
{
    int index = _random.Next(_prompts.Count);
    return _prompts[index];
}

public static void Main(string[] args)
{
    PromptGenerator generator = new PromptGenerator();

    Console.WriteLine("WELCOME TO YOUR JOURNAL PROMPT GENERATOR");
    Console.WriteLine("----------------------------------------");

    Console.WriteLine("Your journal question for today is:");

    Console.WriteLine(generator.GetRandomPrompt());

    Console.WriteLine("----------------------------------------");
}

}
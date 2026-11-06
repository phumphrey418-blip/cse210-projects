using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Response: " + _entryText);
        Console.WriteLine("----------------------------------");
    }

    public static void Main(string[] args)
    {
        Entry entry = new Entry(
            "November 6, 2026",
            "What is something you are grateful for today?",
            "I am grateful for the opportunity to learn programming."
        );

        entry.Display();
    }
}
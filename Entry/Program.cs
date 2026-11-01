using System;

public class Entry
{
// Member variables
public string _date;
public string _promptText;
public string _entryText;

// Constructor
public Entry(string date, string promptText, string entryText)
{
    _date = date;
    _promptText = promptText;
    _entryText = entryText;
}

// Display the journal entry
public void Display()
{
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Prompt: {_promptText}");
    Console.WriteLine($"Entry: {_entryText}");
    Console.WriteLine("-------------------------------");
}

}

public class Program
{
static void Main(string[] args)
{
Entry entry = new Entry(
DateTime.Now.ToShortDateString(),
"What was the best part of your day?",
"Today was a good day because I learned something new."
);

    entry.Display();
}

}
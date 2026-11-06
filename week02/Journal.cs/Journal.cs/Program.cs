using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new journal entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        Console.WriteLine("\n========== MY JOURNAL ==========");

        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        Console.WriteLine("Total Entries: " + _entries.Count);
        Console.WriteLine("================================");
    }

    // Save journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(
                    entry._date + "|" +
                    entry._promptText + "|" +
                    entry._entryText
                );
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    // Load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry newEntry = new Entry(
                    parts[0],
                    parts[1],
                    parts[2]
                );

                _entries.Add(newEntry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
        Console.WriteLine("Entries loaded: " + _entries.Count);
    }

    // Creative feature: Journal statistics
    public void DisplayStatistics()
    {
        Console.WriteLine("\n======= JOURNAL STATISTICS =======");
        Console.WriteLine("Total journal entries: " + _entries.Count);

        if (_entries.Count > 0)
        {
            Console.WriteLine("Keep writing! Every entry records part of your journey.");
        }
        else
        {
            Console.WriteLine("Start writing to build your journal history.");
        }

        Console.WriteLine("==================================");
    }
}
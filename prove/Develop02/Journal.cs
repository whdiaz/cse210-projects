using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        // Write the header row
        writer.WriteLine("Date,Prompt,Entry,Mood");

        foreach (var entry in _entries)
        {
            // Quote entries to handle commas and special characters
            writer.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\",\"{entry.Mood}\"");
        }
    }
}


    public void LoadFromFile(string filePath)
{
    _entries.Clear();
    try
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Skip the header row
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values.Length == 4)
                {
                    var newEntry = new Entry(values[0], values[1], values[2], values[3]);
                    _entries.Add(newEntry);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading file: {ex.Message}");
    }
}

}

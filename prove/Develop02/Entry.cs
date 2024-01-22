public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string Mood; // New property to store the user's mood

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine();
    }
}

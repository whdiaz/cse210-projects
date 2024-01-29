// Program.cs exed requirements =Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
{
    new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
    new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
    new Scripture(new Reference("Psalm", 23, 1), "The LORD is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul.")
};


        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        foreach (var scripture in scriptureLibrary)
        {
            RunScriptureProgram(scripture);
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }

    static void RunScriptureProgram(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Scripture Reference: " + scripture.GetReferenceDisplayText());
        Console.WriteLine("Original Text: " + scripture.GetOriginalText());
        Console.WriteLine("\nPress Enter to hide more words, type 'reveal' to show the next hidden word, or type 'quit' to exit.");

        string input;
        do
        {
            input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "":
                    scripture.HideRandomWord();
                    break;
                case "reveal":
                    scripture.RevealNextHiddenWord();
                    break;
            }

            Console.Clear();
            Console.WriteLine("Scripture Reference: " + scripture.GetReferenceDisplayText());
            Console.WriteLine("Current Text: " + scripture.GetCurrentText());
            Console.WriteLine("\nPress Enter to hide more words, type 'reveal' to show the next hidden word, or type 'quit' to exit.");

        } while (input != "quit" && !scripture.IsCompletelyHidden());
    }
}

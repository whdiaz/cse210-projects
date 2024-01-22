using System;
/*
    Exceeding Requirements:
    - Added a new feature to capture and display the user's mood along with journal entries.
    - Enhanced the SaveToFile method to use a CSV format, making it compatible with Excel.
    - Improved the LoadFromFile method to handle the new CSV format for seamless data loading.
    - Ensured proper quoting of entries to handle commas and special characters during saving.
    - Updated the Entry class to include the Mood property and display it when showing journal entries.
    - Expanded the user input during journal entry creation to include a mood input.
    - These enhancements provide a more comprehensive and user-friendly journaling experience.
*/

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Journal App");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
    string date = DateTime.Now.ToString("yyyy-MM-dd");
    string prompt = promptGenerator.GetRandomPrompt();
    Console.WriteLine($"Prompt: {prompt}");
    Console.Write("Your response: ");
    string entryText = Console.ReadLine();
    Console.Write("Your mood: ");
    string mood = Console.ReadLine();
    Entry newEntry = new Entry(date, prompt, entryText, mood);
    myJournal.AddEntry(newEntry);
    break;
                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file path to save the journal: ");
                    string saveFilePath = Console.ReadLine();
                    myJournal.SaveToFile(saveFilePath);
                    Console.WriteLine("Journal saved successfully.");
                    break;
                case "4":
                    Console.Write("Enter the file path to load the journal: ");
                    string loadFilePath = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilePath);
                    Console.WriteLine("Journal loaded successfully.");
                    break;
                case "5":
                    Console.WriteLine("Exiting the Journal App. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "Helps you reflect on the good things in your life by listing items.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Think about the prompt:");
        ShowSpinner(3);
        Console.WriteLine("\nNow, start listing items...");
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Type each item and press Enter. Type 'done' when finished:");
        string input;
        do
        {
            input = Console.ReadLine();
            if (input.ToLower() != "done")
                items.Add(input);
        } while (input.ToLower() != "done");

        return items;
    }
}

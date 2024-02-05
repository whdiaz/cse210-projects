using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    public ReflectingActivity() : base("Reflecting", "Helps you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Think about the prompt:");
        ShowSpinner(3);
        Console.WriteLine("\nNow, let's reflect...");
        GetRandomPrompt();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string randomPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(randomPrompt);
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }
    }
}

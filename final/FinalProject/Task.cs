using System;

// Base class for Task
class Task
{
    // Encapsulation: Member variables are private
    private string title;
    private DateTime deadline;
    private bool isCompleted;

    // Abstraction: Constructor to initialize task properties
    public Task(string title, DateTime deadline)
    {
        this.title = title;
        this.deadline = deadline;
        isCompleted = false;
    }

    // Encapsulation: Public method for displaying task details
    public virtual void DisplayTaskDetails()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Deadline: {deadline}");
        Console.WriteLine($"Status: {(isCompleted ? "Completed" : "Incomplete")}");
    }
}

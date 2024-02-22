using System;

// Derived class for a specific type of task
class ImportantTask : Task
{
    // Inheritance: Inherits from the base Task class
    private int priority;

    // Abstraction: Constructor to initialize important task properties
    public ImportantTask(string title, DateTime deadline, int priority)
        : base(title, deadline)
    {
        this.priority = priority;
    }

    // Polymorphism: Method overriding
    public override void DisplayTaskDetails()
    {
        base.DisplayTaskDetails();
        Console.WriteLine($"Priority: {priority}");
    }
}

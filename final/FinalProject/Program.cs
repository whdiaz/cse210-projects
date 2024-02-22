using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        // Create a new task based on user input
        Console.Write("Enter the title of the task: ");
        string taskTitle = Console.ReadLine();

        Console.Write("Enter the deadline for the task (YYYY-MM-DD): ");
        DateTime taskDeadline = DateTime.Parse(Console.ReadLine());

        Console.Write("Is this task important? (yes/no): ");
        string isImportantInput = Console.ReadLine();

        Task newTask;

        // Create an important task if the user specified it, else create a regular task
        if (isImportantInput.ToLower() == "yes")
        {
            int taskPriority;

            // Prompt the user until a valid integer is entered
            while (true)
            {
                Console.Write("Enter the priority for the important task: ");

                if (int.TryParse(Console.ReadLine(), out taskPriority))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for priority.");
                }
            }

            newTask = new ImportantTask(taskTitle, taskDeadline, taskPriority);
        }
        else
        {
            newTask = new Task(taskTitle, taskDeadline);
        }

        // Add the newly created task to the manager
        taskManager.AddTask(newTask);

        // Display all tasks
        taskManager.DisplayAllTasks();
    }
}

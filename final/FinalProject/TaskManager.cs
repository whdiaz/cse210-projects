using System;
using System.Collections.Generic;

// Task Manager class to manage a collection of tasks
class TaskManager
{
    // Encapsulation: Private member variable
    private List<Task> tasks;

    // Abstraction: Constructor to initialize the task list
    public TaskManager()
    {
        tasks = new List<Task>();
    }

    // Encapsulation: Public method for adding a task to the manager
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    // Encapsulation: Public method for displaying all tasks
    public void DisplayAllTasks()
    {
        Console.WriteLine("----- All Tasks -----");
        foreach (var task in tasks)
        {
            task.DisplayTaskDetails();
            Console.WriteLine("----------------------");
        }
    }
}

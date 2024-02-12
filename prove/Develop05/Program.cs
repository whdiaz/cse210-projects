// Program.cs

using System;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Display Player Information");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create a New Goal");
            Console.WriteLine("5. Record Event for a Goal");
            Console.WriteLine("6. Save Goals to File");
            Console.WriteLine("7. Load Goals from File");
            Console.WriteLine("8. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.ListGoalDetails();
                    break;
                case "4":
                    goalManager.CreateGoal();
                    break;
                case "5":
                    Console.WriteLine("Enter the short name of the goal to record an event:");
                    string goalShortName = Console.ReadLine();
                    Goal selectedGoal = goalManager.GetGoalByShortName(goalShortName);
                    if (selectedGoal != null)
                    {
                        goalManager.RecordEvent(selectedGoal);
                        Console.WriteLine("Event recorded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Goal not found.");
                    }
                    break;
                case "6":
                    goalManager.SaveGoals();
                    break;
                case "7":
                    goalManager.LoadGoals();
                    break;
                case "8":
                    Console.WriteLine("Exiting program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

            Console.WriteLine("\n------------------------\n");
        }
    }
}

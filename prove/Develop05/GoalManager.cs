// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        _score += goal.IsComplete() ? goal.GetPoints() : 0;
    }

    public void Start()
    {
        Console.WriteLine("Eternal Quest Program");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple/Checklist/Eternal):");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter goal short name:");
        string shortName = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;

        switch (goalType.ToLower())
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case "checklist":
                Console.WriteLine("Enter goal target:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter goal bonus:");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        AddGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');

                string goalType = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal loadedGoal;

                switch (goalType.ToLower())
                {
                    case "simple":
                        loadedGoal = new SimpleGoal(shortName, description, points);
                        break;
                    case "checklist":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        loadedGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                        ((ChecklistGoal)loadedGoal).SetAmountCompleted(amountCompleted);
                        break;
                    case "eternal":
                        loadedGoal = new EternalGoal(shortName, description, points);
                        break;
                    default:
                        // Skip invalid lines
                        continue;
                }

                _goals.Add(loadedGoal);
            }

            Console.WriteLine("Goals loaded from file.");
        }
        else
        {
            Console.WriteLine("No goals file found.");
        }
    }

    public Goal GetGoalByShortName(string shortName)
    {
        return _goals.Find(goal => goal.GetShortName() == shortName);
    }
}

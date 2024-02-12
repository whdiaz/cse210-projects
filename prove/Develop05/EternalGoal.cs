// EternalGoal.cs
using System;

class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        // Eternal goals are never complete
    }

    public override bool IsComplete()
    {
        return false;
    }
}

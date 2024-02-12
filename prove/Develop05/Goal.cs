// Goal.cs
using System;

class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        // Implementation in derived classes
    }

    public virtual bool IsComplete()
    {
        // Implementation in derived classes
        return false;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}";
    }
}

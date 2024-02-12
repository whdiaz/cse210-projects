// ChecklistGoal.cs
using System;

class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            // Bonus points when the target is reached
            _points += _bonus;
        }
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{_amountCompleted}:{_target}:{_bonus}";
    }
}

using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int Bonus => _bonus;

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You have recorded {_name} {_amountCompleted}/{_target} times and earned {_points} points.");
        if (IsComplete())
            Console.WriteLine($"Congratulations! You have completed the goal {_name} and earned a bonus of {_bonus} points!");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_name} - {_description} (Completed {_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_name}, {_description}, {_points} points each time, {_bonus} bonus points on completion";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded the goal: {_name} and earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_name}, {_description}, {_points} points each time";
    }
}

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You have completed the goal: {_name} and warned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_name}, {_description}, {_points} points";
    }
}

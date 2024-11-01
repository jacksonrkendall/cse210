public class Running : Activity
{
    double _distance;
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / Length) * 60;

    public override double GetPace() => Length / _distance;
    

}
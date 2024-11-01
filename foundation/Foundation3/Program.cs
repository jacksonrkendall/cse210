using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2020, 1, 2), 30, 3.0),
            new Cycling(new DateTime(2020, 1, 2), 30, 18.0),
            new Swimming(new DateTime(2020, 1, 2), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
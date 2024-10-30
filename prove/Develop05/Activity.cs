public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("Enter Duration in seconds: ");
    
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"Prepare to start...");
        ShowSpinner(3);
        Console.WriteLine("");

        Run();

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine("");
    }

    public abstract void Run();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine (i);
            Thread.Sleep(1000);
        }
    }
}
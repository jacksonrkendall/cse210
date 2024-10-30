using System.Runtime.CompilerServices;

public class BreathingActtivity : Activity
{
    public BreathingActtivity() : base("Breathing", "This activity helps you relax with timed breathing.")
    {}
    public override void Run()
    {
        int halfDuration = _duration / 2;

        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }
    }
}
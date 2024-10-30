public class ListingActivity : Activity{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you habe helped this week?",
        "When have you felt the Holy ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        Console.WriteLine("");
    }
}
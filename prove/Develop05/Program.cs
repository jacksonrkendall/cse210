using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
        new BreathingActtivity(),
        new ReflectionActivity(),
        new ListingActivity()
        };

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].GetType().Name}");
            }
            Console.WriteLine("4. Exit");
            Console.Write(">> ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 4) break;

            Console.WriteLine("");
            activities[choice - 1].Start();
        }
    }
}
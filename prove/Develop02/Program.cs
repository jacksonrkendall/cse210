using System;
using System.Data.Common;
using System.Diagnostics;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program.");
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Make a choice below: \n1: Write\n2: Display\n3: Save\n4: Load3\n5: Quit");
            string response = Console.ReadLine();
            choice = int.Parse(response);
            

            if (choice == 1)
            {
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine("Prompt:" + prompt);
                Console.WriteLine("> ");
                string userResponse = Console.ReadLine();

                string date = DateTime.Now.ToString("MM-dd-yyyy");
                Entry newEntry = new Entry(date, prompt, userResponse);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load journal: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else 
            {
                Console.WriteLine("Incorrect entry, please enter {1-5}");
            }
        }
    }
}

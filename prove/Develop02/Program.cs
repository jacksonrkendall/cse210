using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 5)
        {
                // offers options, asks user for choice
                Console.WriteLine("Welcome to the Journal Prrogram.");
            Console.WriteLine("Make a choice below: \n1: Write\n2: Display\n3: Load\n4: Save\n5: Quit");
            string response = Console.ReadLine();
            choice = int.Parse(response);
            
            // compares response to different choice levels

            if (choice == 1)
            {
                Console.WriteLine("Choice 1");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Choice 2");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Choice 3");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Choice 4");
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

using System;

class Program
{
    static void Main(string[] args)
    {
        // making a list for the numbers to be entered into
         List<int> numbers = new List<int>();
        int number;
        // introducing the user to the progrma
        Console.Write("Enter a series of numbers (enter 0 to stop):");
        // in a loop, asking for input to the list, until break condition met
        do
        {
            // asking for input, parsing integers, assigning to variable
            Console.Write("Enter number: ");
            string input2 = Console.ReadLine();
            number = int.Parse(input2);
            // determining if input is break condition, else, adding to list
            if (number != 0)
            {
                numbers.Add(number);
            }
        // break condition
        } while (number != 0);

        // after break condition for list creation is met, performing arithmetic calculations
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        // write arithmetic results to console
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

    }
}
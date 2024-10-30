using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssignment = new Assignment("Jackson Kendall", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
    }
}
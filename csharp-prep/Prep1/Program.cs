// Bond, James Bond
// Input: user is asked for their first and last names
// Output: terminal outputs user's name in "Bond, James Bond" style

using System;

class Program
{
    static void Main(string[] args)
    {
        // asks the user for their first name, assigns it to a variable
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        // asks the user for their last name, assigns it to a variable
        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();
        // prints blank line inbetween arguments for good separation
        Console.WriteLine();
        // prints user's name in the Bond, James Bond format
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}
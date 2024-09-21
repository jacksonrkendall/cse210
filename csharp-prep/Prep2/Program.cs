// grade number to letter conversion
// Input: a user's grade (int)
// output: the letter associated with the numerical grade

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // asks user for their grade, assigns response to a variable
        Console.Write("What is your grade (%)? ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);
        string letter ="";
        // compares response to different grade levels

        if (grade >= 90)
            {
                letter = "A";
            }
        else if (grade >= 80)
            {
                letter = "B";
            }
        else if (grade >= 70)
            {
                letter = "C";
            }
        else if (grade >= 60)
            {
                letter = "D";
            }
        else if (grade < 60)
            {
                letter = "F";
            }
        
        // prints letter to terminal
        Console.WriteLine($"Your grade is {letter}");

        // if statement determining if the user passed the class with the given grade
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class! Congrats!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass this time. You'll do better next time.");
        }
    }
}
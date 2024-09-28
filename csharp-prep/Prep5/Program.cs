using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);


        // display program, inputs: none, outputs: none
        // function displays a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }

        // username program, inputs: user name(string), outputs: user name(string)
        // Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }

        //  Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            Console.Write("Enter number: ");
            return int.Parse(Console.ReadLine());
        }

        // Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squareNumber}");
        }
    }
}
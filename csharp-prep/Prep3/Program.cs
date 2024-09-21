using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        // generates random number
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        while (guess != magic)
        {

            // asks the customer for their guess
            Console.Write("What is your guess? ");
            string input2 = Console.ReadLine();
            guess = int.Parse(input2);

            // checks if the number matches, or if the user needs to guess higher or lower,
            // then writes out response to user
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
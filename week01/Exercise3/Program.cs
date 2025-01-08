using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);
        int guessNumberInt;

        Console.WriteLine("I'm thinking of a number between 1 and 100:");

        do
        {
        Console.Write("What is your guess? ");
        guessNumberInt = int.Parse(Console.ReadLine());

        if (guessNumberInt > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNumberInt < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        } while (guessNumberInt != magicNumber);
    }
}
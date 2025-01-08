using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);
        string gradeLetter;

        if (gradePercentage >= 90) 
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}.");

        if (gradePercentage > 60)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else 
        {
            Console.WriteLine("We are sorry. You failed the class.");
        }
    }
}
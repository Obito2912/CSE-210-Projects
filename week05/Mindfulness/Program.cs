// I added a validation feature to the program. If the user makes the mistake 
// of typing something that is not a number, the program won't crash and will
// advise the user to type a number, if the number is not within the range,
// it will do the same.

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // ================================== Reflecting Prompts/Questions ==================================

        List<string> reflectingPrompts =
        [
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        ];
        List<string> reflectingQuestions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

        // ================================== Listing Prompts ==================================

        List<string> listingPrompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];

        // ================================== Breathing Activity Instance ==================================
        string breathingName = "Breathing Activity";
        string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int breathingDuration = 0;
        BreathingActivity breathingActivity = new BreathingActivity(breathingName, breathingDescription, breathingDuration);

        // ================================== Reflecting Activity Instance ==================================
        string reflectingName = "Reflecting Activity";
        string reflectingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int reflectingDuration = 0;
        ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingName, reflectingDescription, reflectingDuration, reflectingPrompts, reflectingQuestions);

        // ================================== Listing Activity Instance ==================================
        string listingName = "Listing Activity";
        string listingDescription = "This activity will help you reflect in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int listingDuration = 0;
        int listingCount = 0;
        ListingActivity listingActivity = new ListingActivity(listingName, listingDescription, listingDuration, listingCount, listingPrompts);



        // ================================== Switch Statement ==================================


        int userChoice;

        do
        {
            userChoice = GetUserChoice();
            switch (userChoice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again");
                    break;
            }
        }

        while (userChoice != 4);



        // ================================== Menu Options and Input Validation ==================================

        static int GetUserChoice()
        {
            int userChoice;
            bool isValidInput = false;
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit\n");

            do
            {
                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out userChoice))
                {
                    if (userChoice >= 1 && userChoice <= 4)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 4.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                }
            } while (!isValidInput);

            return userChoice;
        }

    }
}
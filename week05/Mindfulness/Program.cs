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

        // ================================== MENU OPTIONS ==================================

        int userChoice;
        void displayOptions()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit\n");

            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
        }

        do
        {
            // Calling display options in a while loop until user chooses to quit
            displayOptions();

            // ================================== IF STATEMENTS ==================================

            if (userChoice == 1)
            {
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                reflectingActivity.Run();
            }
            else if (userChoice == 3)
            {
                listingActivity.Run();
            }

        } while (userChoice != 4);
    }
}
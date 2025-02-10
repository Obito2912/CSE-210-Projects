using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // ================================== Breathing Activity Instance ==================================
        string breathingName = "Breathing Activity";
        string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int breathingDuration = 0;
        BreathingActivity breathingActivity = new BreathingActivity(breathingName, breathingDescription, breathingDuration);



        // ================================== Listing Activity Instance ==================================
        string listingName = "Listing Activity";
        string listingDescription = "This activity will help you reflect in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int listingDuration = 5000;
        int listingCount = 5;
        List<string> listingPrompts = new List<string>();
        ListingActivity listingActivity = new ListingActivity(listingName, listingDescription, listingDuration, listingCount, listingPrompts);




        // ================================== Reflecting Activity Instance ==================================
        string reflectingName = "Reflecting Activity";
        string reflectingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int reflectingDuration = 5000;
        List<string> reflectingPrompts = new List<string>();
        List<string> reflectingQuestions = new List<string>();
        ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingName, reflectingDescription, reflectingDuration, reflectingPrompts, reflectingQuestions);




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
            listingActivity.Run();
        }
        else if (userChoice == 3)
        {
            reflectingActivity.Run();
        }

        } while (userChoice != 4);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts = new List<string>
        {
            "What was the hardest thing you had to do today?",
            "What things were I grateful for today?",
            "If you could change something about your day, what would it be?",
            "What was the best part of your day?",
            "What part of the day would you like to share with your loved ones?"
        };

        Entry entry = new Entry();
        entry._date = dateText;
        entry._promptText = promptGenerator.GetRandomPrompt();

        Console.WriteLine("Welcome to the Journal Program!");
        string userChoice;

        do
        {
            Console.WriteLine("Please select one of the following choices:\n");
            string options = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n";
            Console.WriteLine(options);
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Write($"{entry._promptText}\n>");
                entry._entryText = Console.ReadLine();
            }

            else if (userChoice == "2")
            {
                entry.Display();
            }

            else if (userChoice == "3")
            {

            }
            
            else if (userChoice == "4")
            {

            }
            
            else if (userChoice == "5")
            {

            }

        } while (userChoice != "5");


    }
}
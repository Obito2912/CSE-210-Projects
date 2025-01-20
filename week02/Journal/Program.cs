using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts = new List<string>
        {
            "What was the hardest thing you had to do today?",
            "What things were you grateful for today?",
            "If you could change something about your day, what would it be?",
            "What was the best part of your day?",
            "What part of the day would you like to share with your loved ones?"
        };

        Console.WriteLine("Welcome to the Journal Program!");
        string userChoice;

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:\n");
            string options = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n";
            Console.WriteLine(options);
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry entry = new Entry
                {
                    _date = dateText,
                    _promptText = promptGenerator.GetRandomPrompt()
                };

                Console.Write($"{entry._promptText}\n>");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("\nEnter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            
            else if (userChoice == "4")
            {
                Console.Write("\nEnter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            
        } while (userChoice != "5");

    }
}
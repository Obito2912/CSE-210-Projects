using System;
using System.Threading.Tasks.Dataflow;

// I added another else if statement at the end of my do while loop to advice the user to type
// a number between 1 and 5 in case the user types a letter by mistake or a number that is 
// not in the options.

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
            
            else if (!new[] {"1", "2", "3", "4", "5"}.Contains(userChoice))
            {
                Console.WriteLine($"\nPlease type a number between 1 and " +
                "4 in order for\nthe program to do something. Otherwise type 5 to quit.");
            }

        } while (userChoice != "5");

    }
}
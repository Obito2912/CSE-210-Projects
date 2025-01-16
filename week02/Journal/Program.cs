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
            "What was the best part of the day?",
            "What part of the day would you like to share with your loved ones?"
        };

        Entry entry = new Entry();
        entry._date = dateText;
        entry._promptText = promptGenerator.GetRandomPrompt();
        entry._entryText = "como estas";

    }
}
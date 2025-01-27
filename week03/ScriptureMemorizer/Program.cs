using System;
// When IsCompletelyHidden is true, a text will be displayed on the console letting the user know
// that he/she can press enter again to quit. Once the user presses enter, the break keyword will act.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 17);
        Scripture scripture = new Scripture(reference, "And behold, I tell you theses things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God");
    
    while (true)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            break;
        }

        scripture.HideRandomWords(2);

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden. Press Enter to exit.");
            Console.ReadLine();
            Console.Clear();
            break;
        }
    }

    }

}
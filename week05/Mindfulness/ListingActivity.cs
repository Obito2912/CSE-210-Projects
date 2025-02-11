public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine($"{GetDescription()}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.WriteLine("Get ready...");
        ShowSpinner(500);

        Console.WriteLine("\nList as many responses you can to the following prompt:\n");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(1000);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser();

        Console.WriteLine($"You listed {userResponses.Count} items!");
        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_prompts.Count);

        string randomPrompt = _prompts[index];
        Console.WriteLine($"--- {randomPrompt}. ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        int durationInSeconds = GetDuration();

        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write(">");
            string inputFromUser = Console.ReadLine();
            list.Add(inputFromUser);
        }
        return list;
    }

}
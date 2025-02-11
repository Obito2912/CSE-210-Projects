public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

        DisplayStartingMessage();
        Console.WriteLine($"{GetDescription()}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.WriteLine("Get ready...");
        ShowSpinner(500);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience...");
        Console.Write("You may begin in: ");
        ShowCountDown(1000);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
        Console.Write($"{GetRandomQuestion()} ");
        ShowSpinner(500);
        Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_prompts.Count);

        string randomPrompt = _prompts[index];
        return $"--- {randomPrompt}. ---";
    }

    public string GetRandomQuestion()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_questions.Count);

        string randomQuestion = _questions[index];
        return $"> {randomQuestion}";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}
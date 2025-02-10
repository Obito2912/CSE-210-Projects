public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        string name = GetName();
        string description = GetDescription();
        // int duration = GetDuration();

        Console.WriteLine($"Welcome ot the {name}.\n");
        Console.WriteLine($"{description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(500);
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Breathe in...");
        ShowCountDown(5);
        Console.WriteLine();

        Console.Write("Breathe out...");
        ShowCountDown(5);
        Console.WriteLine();
    }
}
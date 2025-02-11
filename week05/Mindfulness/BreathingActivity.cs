public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

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
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < duration / 10; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(1000);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(500);
        Console.Clear();
    }
}
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        string name = GetName();
        string description = GetDescription();
        int duration = GetDuration();

        Console.WriteLine($"");
    }
}
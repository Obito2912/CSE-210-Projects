using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {GetName()}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime;
        
        do
        {
            Console.Write("\\");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

    }

    public void ShowCountDown(int seconds)
    {

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }
}
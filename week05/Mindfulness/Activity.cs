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

    // Or I could use Expression-bodied getters and setters for cleaner code
    // public string GetName() => _name;
    // public void SetName(string name) => _name = name;

    // public string GetDescription() => _description;
    // public void SetDescription(string description) => _description = description;

    // public int GetDuration() => _duration;
    // public void SetDuration(int duration) => _duration = duration;

    public void DisplayStartingMessage()
    {
        
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}
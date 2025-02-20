public abstract class Activity
{
    private string _name;
    private DateOnly _date;
    private int _length;

    public Activity(string name, DateOnly date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public string GetName() => _name;

    public DateOnly GetDate() => _date;

    public int GetLength() => _length;

    public abstract double GetDistance();
    
    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"-- {GetDate():dd MMM yyyy} {GetName()} ({GetLength()} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
public class Running : Activity
{
    private double _distance;

    public Running(string name, DateOnly date, int length, double distance) : base(name, date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    
    public override double GetSpeed() => _distance / GetLength() * 60;

    public override double GetPace() => GetLength() / _distance;
}
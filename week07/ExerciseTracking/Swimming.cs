public class Swimming : Activity
{
    private int _laps;

    public Swimming(string name, DateOnly date, int length, int laps) : base(name, date, length)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000;
    
    public override double GetSpeed() => GetDistance() / GetLength() * 60;

    public override double GetPace() => GetLength() / GetDistance();
}
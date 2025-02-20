public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, DateOnly date, int length, double speed) : base(name, date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * GetLength() / 60;
    
    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
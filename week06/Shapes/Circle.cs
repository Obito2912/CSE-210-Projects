public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(GetRadius(), 2);
    }
}
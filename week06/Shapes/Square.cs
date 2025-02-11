public class Square : Shape
{
    private double _side;
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        return GetSide() * GetSide();
    }
}
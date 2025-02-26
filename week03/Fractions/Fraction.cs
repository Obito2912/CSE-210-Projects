public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }

    public double GetDecimalValue()
    {
        return (double)GetTop() / GetBottom();
    }
}
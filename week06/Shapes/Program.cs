using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "Yellow");

        Rectangle rectangle = new Rectangle(10, 5, "Blue");

        Circle circle = new Circle(10, "Red");

        List<Shape> shapes = [square, rectangle, circle];

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}\n{shape.GetArea():F2}\n");
        }
    }
}
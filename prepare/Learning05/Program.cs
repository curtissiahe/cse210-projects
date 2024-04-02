using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! I hope this message finds you well?");

        // Create instances of shapes
        Square square = new Square();
        square.SetArea(4);

        Rectangle rectangle = new Rectangle();
        rectangle.SetArea(4, 4);

        Circle circle = new Circle();
        circle.SetArea(3);

        // Display areas
        DisplayArea(square);
        DisplayArea(rectangle);
        DisplayArea(circle);
    }

    public static void DisplayArea(Shape shape)
    {
        Console.WriteLine($"Area of {shape.GetColor()} {shape.GetType().Name}: {shape.GetArea()}");
    }
}

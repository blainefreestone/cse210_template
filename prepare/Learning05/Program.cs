using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("orange", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 2, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 3.4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}; Area: {shape.GetArea()}");
        }
    }
}
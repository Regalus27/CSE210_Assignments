using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];
        shapes.Add(new Square("red", 5));
        shapes.Add(new Circle("blue", 3));
        shapes.Add(new Rectangle("grey", 3, 5));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}
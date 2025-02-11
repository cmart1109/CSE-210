using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(40));
        shapes.Add(new Rectangle(30,20));
        shapes.Add(new Circle(10));

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }   
    }
}
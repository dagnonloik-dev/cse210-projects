using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();

        Square s1 = new Square(6,"Blue");
        shapes.Add(s1);

        Circle s2 = new Circle(6,"Red");
        shapes.Add(s2);

        Rectangle s3 = new Rectangle(6,4,"Green");
        shapes.Add(s3);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");   
        }
    }
}
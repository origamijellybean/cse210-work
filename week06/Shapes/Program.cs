using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];
        Square square1 = new Square("Black", 5);
        shapes.Add(square1);
        Rectangle rectangle1 = new Rectangle("Red", .5, 50);
        shapes.Add(rectangle1);
        Circle circle1 = new Circle("White", 2.85);
        shapes.Add(circle1);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetClassType());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();

        }
    }
}
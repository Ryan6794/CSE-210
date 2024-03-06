using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square Sq1 = new Square("Green", 4);
        Rectangle Rt1 = new Rectangle("Yellow", 2, 3);
        Circle Cr1 = new Circle("Blue", 4);

        // Console.WriteLine(Sq1.GetArea());
        // Console.WriteLine(Sq1.GetColor());

        // Console.WriteLine(Rt1.GetArea());
        // Console.WriteLine(Rt1.GetColor());

        // Console.WriteLine(Cr1.GetArea());
        // Console.WriteLine(Cr1.GetColor());

        List<Shape> ShapeList = new List<Shape>();

        ShapeList.Add(Sq1);
        ShapeList.Add(Rt1);
        ShapeList.Add(Cr1);

        foreach(Shape shape in ShapeList)
        {
            Console.WriteLine($"The shape's area is: {shape.GetArea()}\nIt's Color is {shape.GetColor()}");
        }



    }
}
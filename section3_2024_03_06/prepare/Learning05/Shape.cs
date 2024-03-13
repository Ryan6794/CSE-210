public class ShapeRunner
{
    public static void Run()
    {
        Shapes and Area
        var shapes = new List<Shape> {
            new Circle("red", 34),
            new Square("blue", 22)
        };

        foreach (var shape in shapes)
        {
            System.Console.WriteLine($"Area of Shape is: {shape.Area()}");
        }
    }
}

// Abstract class example
public abstract class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public abstract float Area();
}

public class Rectangle : Shape
{
    private float side1;
    private float side2;

    public Rectangle(string color, float side1, float side2) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override float Area()
    {
        return side1 * side2;
    }
}

public class Circle : Shape
{
    private float radius;

    public Circle(string color, float radius) : base(color)
    {
        this.radius = radius;
    }

    public override float Area()
    {
        float pi = (float)3.14;
        return pi * radius * radius;
    }
}

public class Square : Shape
{
    private float sideLength;

    public Square(string color, float sideLength) : base(color)
    {
        this.sideLength = sideLength;
    }

    public override float Area()
    {
        return sideLength * sideLength;
    }
}
using static System.Math;

public class Circle : Shape
{

    double _radius;
    public Circle(string color, int radius) : base(color)
    {
        this._radius = radius;
    }


    public override double GetArea()
    {
        return PI * Pow(_radius,2);
    }
}
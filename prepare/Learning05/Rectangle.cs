public class Rectangle : Shape
{
    double _width;
    double _length;


    public Rectangle(string color, int width, int length) :base(color)
    {
        this._width = width;
        this._length = length;
    }


    public override double GetArea()
    {

        return _width * _length;
    }
}
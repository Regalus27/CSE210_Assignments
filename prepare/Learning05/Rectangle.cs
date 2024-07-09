class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        SetDimensions(length, width);
    }

    public override double GetArea()
    {
        return GetLength() * GetWidth();
    }

    private double GetLength()
    {
        return _length;
    }

    private double GetWidth()
    {
        return _width;
    }

    private void SetDimensions(double length, double width)
    {
        _length = length;
        _width = width;
    }
}
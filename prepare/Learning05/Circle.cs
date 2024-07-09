class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        SetRadius(radius);
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(GetRadius(), 2);
    }

    private double GetRadius()
    {
        return _radius;
    }

    private void SetRadius(double radius)
    {
        _radius = radius;
    }
}
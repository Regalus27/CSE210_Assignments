class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        SetSide(side);
    }

    public override double GetArea()
    {
        return Math.Pow(GetSide(), 2);
    }

    private double GetSide()
    {
        return _side;
    }

    private void SetSide(double side)
    {
        _side = side;
    }
}
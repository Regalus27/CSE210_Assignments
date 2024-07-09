abstract class Shape
{
    string _color;

    protected Shape(string color)
    {
        SetColor(color);
    }

    public abstract double GetArea();

    public string GetColor()
    {
        return _color;
    }

    protected void SetColor(string color)
    {
        _color = color;
    }
}
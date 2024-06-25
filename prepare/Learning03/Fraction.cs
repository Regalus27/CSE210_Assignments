class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        ArgumentOutOfRangeException.ThrowIfZero(denominator); // Modern code editors are so cool
        _top = numerator;
        _bottom = denominator;
        // For convenience, always store negatives in the numerator
        // Additionally, cancel out double negatives
        if (_bottom < 0)
        {
            _top *= -1;
            _bottom *= -1;
        }
    }

    // I agree with the reading that getter and setter functions work against OOP, but was also required to include them.

    public int GetBottom()
    {
        return _bottom;
    }

    public double getDecimalValue()
    {
        double numerator = GetTop();
        double denominator = GetBottom();
        return numerator / denominator;
        // instructor solution used casting, good to know (double) is syntax in c#
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }
}
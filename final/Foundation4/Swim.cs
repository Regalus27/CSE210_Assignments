class Swim : Activity
{
    private double _laps {get;}
    protected override double _distance {get;}

    public Swim(string date, int duration, int laps): base(date, duration)
    {
        _laps = laps;
        _distance = _laps * 50 / 1000;
    }

    protected override string GetActivityType()
    {
        return "Swimming";
    }
}
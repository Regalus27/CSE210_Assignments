class Bike : Activity
{
    private double _speed {get;}
    protected override double _distance {get;}

    public Bike(string date, int duration, double speed): base(date, duration)
    {
        _speed = speed;
        _distance = _speed / 60 * _activityDuration;
    }

    protected override string GetActivityType()
    {
        return "Biking";
    }
}
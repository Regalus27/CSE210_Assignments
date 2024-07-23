using System.Runtime.CompilerServices;

class Run : Activity
{
    protected override double _distance {get;}

    public Run(string date, int duration, double distance): base(date, duration)
    {
        _distance = distance;
    }

    protected override string GetActivityType()
    {
        return "Running";
    }
}
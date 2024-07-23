abstract  class Activity
{
    private string _date {get;}
    protected int _activityDuration {get;}
    protected abstract double _distance {get;}

    protected Activity(string date, int duration)
    {
        _date = date;
        _activityDuration = duration;
    }

    public string GetSummary()
    {
        string date = _date;
        string activityType = GetActivityType();
        string duration = GetActivityDuration();
        string distance = GetActivityDistance();
        string speed = GetActivitySpeed();
        string pace = GetActivityPace();

        return $"{date} {activityType} ({duration}): {distance}, {speed}, {pace}.";
    }
    private string GetActivityDuration()
    {
        int hours = _activityDuration / 60;
        int minutes = _activityDuration % 60;
        return $"{hours}:{minutes}";
    }
    private string GetActivityDistance()
    {
        return $"Distance: {Math.Round(_distance, 1)} km";
    }

    private string GetActivityPace()
    {
        double pace = _activityDuration / _distance;
        return $"Pace: {Math.Round(pace, 1)} min per km";
    }

    private string GetActivitySpeed()
    {
        double speed = _distance / _activityDuration * 60;
        return $"Speed: {Math.Round(speed, 1)} kph";
    }
    protected abstract string GetActivityType();
}
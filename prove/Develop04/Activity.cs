abstract class Activity
{
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;
    protected string _name;
    

    protected void End()
    {
        _endTime = DateTime.Now.AddSeconds(5);
        Pause(5, $"Well done. You focused on this {_name} for {_duration} seconds.");
    }

    protected bool HasActivityEnded()
    {
        return DateTime.Now > _endTime;
    }
    protected void Pause(int secondsPaused, string contextMessage)
    {
        while(secondsPaused > 0 && !HasActivityEnded()) // Make sure pause doesn't extend activity.
        {
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine(contextMessage);
            Console.WriteLine();
            Console.Write(secondsPaused);
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            secondsPaused--;
        }
        Console.Clear();
    }

    protected static DateTime CalculateEndTime(int activityDurationInSeconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(activityDurationInSeconds);
        return endTime;
    }
    public abstract void Start();
}
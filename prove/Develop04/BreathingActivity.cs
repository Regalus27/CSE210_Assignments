sealed class BreathingActivity : Activity
{
    public BreathingActivity(int activityDurationInSeconds)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = activityDurationInSeconds;
        _endTime = DateTime.Now;
    }

    public override void Start()
    {
        _endTime = CalculateEndTime(_duration);

        Pause(5, _description);
        
        while(!HasActivityEnded())
        {
            Pause(8, "Breathe in...");
            Pause(8, "Breathe out...");
        }

        End();
    }
}
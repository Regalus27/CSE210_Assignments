sealed class ListingActivity : Activity
{
    private readonly string[] _prompts;

    public ListingActivity(int activityDurationInSeconds)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = activityDurationInSeconds;
        _endTime = DateTime.Now;

        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];
    }

    private string GetRandomPrompt() // Ask how they would handle this duplicate function, utility file?
    {
        Random r = new();
        return _prompts[r.Next(_prompts.Length)];
    }

    private void InputPause(DateTime endTime)
    {
        int counter = 0;
        while(DateTime.Now < _endTime)
        {
            Console.Clear();
            Console.WriteLine($"You've listed {counter++} examples.");
            Console.Write("Enter here: ");
            Console.ReadLine();
        }
    }

    public override void Start()
    {
        _endTime = CalculateEndTime(_duration);

        Pause(5, _description);
        Pause(5, GetRandomPrompt());
        InputPause(_endTime);
        End();
    }

    // TODO finish this, rewrite pause or make new function to display 

}
sealed class ReflectionActivity : Activity
{
    private readonly string[] _prompts;
    private readonly string[] _questions;
    public ReflectionActivity(int activityDurationInSeconds)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = activityDurationInSeconds;
        _endTime = DateTime.Now;

        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];

        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];
    }

    private string GetRandomPrompt()
    {
        Random r = new();
        return _prompts[r.Next(_prompts.Length)];
    }

    private string GetQuestion(int index=0)
    {
        if(index % _questions.Length == 0)
        {
            ShuffleQuestions();
        }
        return _questions[index % _questions.Length];
    }

    private void ShuffleQuestions()
    {
        Random r = new();
        int n = 0;
        while (n < _questions.Length)
        {
            int randomIndex = r.Next(_questions.Length);
            (_questions[n], _questions[randomIndex]) = (_questions[randomIndex], _questions[n]);
            n++;
        }
    }

    public override void Start()
    {
        _endTime = CalculateEndTime(_duration);
        int questionCount = 0;

        Pause(5, _description); 
        Pause(10, GetRandomPrompt());

        while(!HasActivityEnded()) // These three lines are repeated.
        {
            Pause(20, GetQuestion(questionCount++));
        }

        End();
    }
}
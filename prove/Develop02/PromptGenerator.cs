class PromptGenerator
{
    List<String> _promptList = [
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "Have I done any good in the world today? If not, what could I have done?",
        "How did I utilize the enabling power of the atonement today?"
    ];

    public String GetPrompt()
    {
        Random random = new();
        int r = random.Next(_promptList.Count);
        return _promptList[r];
    }
}
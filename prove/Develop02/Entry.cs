class Entry
{
    string _entryText;
    string _entryDate;

    public void CreateEntry(string date, string text)
    {
        // Manually create entry from data, such as when loading an entry
        _entryDate = date;
        _entryText = text;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date Written: {_entryDate}");
        Console.WriteLine(_entryText);
    }

    public string GetDateTime()
    {
        return _entryDate;
    }

    public string GetText()
    {
        return _entryText;
    }

    private void SetDateTime()
    {
        _entryDate = DateTime.Now.ToShortDateString();
    }

    private void SetText(String text)
    {
        _entryText = text;
    }

    public void WriteEntry()
    {
        SetDateTime();

        // Inform User of current state
        Console.WriteLine($"Creating a new entry for {GetDateTime().ToString()}");

        // Offer Prompt to user
        PromptGenerator promptGenerator = new();
        Console.WriteLine($"Prompt: {promptGenerator.GetPrompt()}");

        SetText(Console.ReadLine());
    }
}
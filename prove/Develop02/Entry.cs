class Entry
{
    String _entryText;
    String _entryDate;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date Written: {this._entryDate}");
        Console.WriteLine(this._entryText);
    }

    public String GetDateTime()
    {
        return this._entryDate;
    }

    public String GetText()
    {
        return this._entryText;
    }

    private void SetDateTime()
    {
        this._entryDate = DateTime.Now.ToShortDateString();
    }

    private void SetText(String text)
    {
        this._entryText = text;
    }

    public Entry WriteEntry()
    {
        SetDateTime();

        // Inform User of current state
        Console.WriteLine($"Creating a new entry for {GetDateTime().ToString()}");

        // Offer Prompt to user
        PromptGenerator promptGenerator = new();
        Console.WriteLine($"Prompt: {promptGenerator.GetPrompt()}");

        SetText(Console.ReadLine());

        return this;
    }
}
class Journal
{
    List<Entry> _entryList = [];

    private void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in this._entryList)
        {
            entry.DisplayEntry(); 
        }
    }

    public void NewEntry()
    {
        Entry entry = new();
        entry.WriteEntry();
        _entryList.Add(entry);
    }
}
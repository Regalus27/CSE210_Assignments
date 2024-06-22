using System.IO;

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

    private List<Entry> GetEntries()
    {
        return _entryList;
    }

    public void LoadJournal()
    {
        // filename and separator should be stored at file level, not function level, but need to move on.
        string filename = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +"\\journalSave.txt";
        string separator = "%@@%";
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entryList = [];

        foreach (string line in lines)
        {
            string[] parts = line.Split(separator);
            Entry entry = new();
            entry.CreateEntry(parts[0], parts[1]);
            AddEntry(entry);
        }
    }

    public void NewEntry()
    {
        Entry entry = new();
        entry.WriteEntry();
        _entryList.Add(entry);
    }

    public void SaveJournal()
    {
        string filename = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +"\\journalSave.txt";
        Console.WriteLine($"Saved at: {filename}");
        string separator = "%@@%";
        using (StreamWriter outputFile = new(filename))
        {
            foreach (Entry entry in GetEntries())
            {
                outputFile.WriteLine($"{entry.GetDateTime()}{separator}{entry.GetText()}");
            }
        }
    }
}
class Reference
{
    private string _book;
    private int _chapter;
    private int _endVerse;
    private int _verse;

    public Reference(string book, int chapter, int verse) : this(book, chapter, verse, verse)
    {
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (IsSingleVerse())
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

    private bool IsSingleVerse()
    {
        return _verse == _endVerse;
    }
}
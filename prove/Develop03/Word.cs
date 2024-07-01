class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new String('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }

    public bool GetHidden()
    {
        return _isHidden;
    }

    public bool Hide()
    {
        if (_isHidden)
        {
            return false;
        }
        else{
            _isHidden = true;
            return true;
        }
    }

    public void Show()
    {
        _isHidden = false;
    }
}
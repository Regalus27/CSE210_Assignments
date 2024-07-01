class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string words, Reference reference)
    {
        _words = CreateWordList(words);
        _reference = reference;
    }

    private static List<Word> CreateWordList(string words)
    {
        List<Word> wordsToReturn = [];
        string[] wordList = words.Split(" ");
        foreach (string word in wordList)
        {
            wordsToReturn.Add(new Word(word));
        }
        return wordsToReturn;
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public void HideRandomWords(int numberWordsToHide)
    {
        // Shuffle list
        // Hide words from start
        // End once hidden enough words or end of list
        List<Word> list = ShuffleList();
        for (int i = 0; i < numberWordsToHide; i++)
        {
            if(i > list.Count - 1)
            {
                break; // reached end of list
            }
            if(!list[i].Hide()){
                numberWordsToHide++; // If failed to hide a word, add another cycle
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool valueToReturn = true;
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                valueToReturn = false;
            }
        }
        return valueToReturn;
    }

    private List<Word> ShuffleList()
    {
        // break reference link
        List<Word> tempList = [];
        foreach (Word word in _words)
        {
            tempList.Add(word);
        }
        // Fisher Yates shuffle
        Random random = new();
        int n = 0;
        int listLength = tempList.Count;
        while (n < listLength)
        {
            int randomIndex = random.Next(listLength);
            (tempList[n], tempList[randomIndex]) = (tempList[randomIndex], tempList[n]);
            // wow modern code editors are so cool
            // literally told me a more efficient way to swap values
            n++;
        }
        return tempList;
    }
}
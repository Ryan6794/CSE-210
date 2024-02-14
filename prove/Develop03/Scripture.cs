
public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();

    public Scripture(Reference reference, string text)
    {

        this._reference = reference;

        foreach (string wordString in text.Split(' '))
        {
            Word word = new Word(wordString);
            _wordList.Add(word);
        }
    }


    public void Display()
    {
        _reference.Display();
        foreach (var word in _wordList)
        {
            Console.Write($"{word.GetString()} ");
        }

    }

    public void HideRandomWords()
    {
        var random = new Random();
        int TryHide = 0;
        while (TryHide <= 2)
        {
            int IndexOfWordToHide = random.Next(_wordList.Count);
            var WordToHide = _wordList[IndexOfWordToHide];
            bool AlreadyHidden = WordToHide.GetIsHidden();
            if (AlreadyHidden == false)
            {
                WordToHide.Hide();
                TryHide++;
            }
            else if(AreAllWordsHidden() == true)
            {
                TryHide++;
            }
        }

    }

    public bool AreAllWordsHidden()
    {
        bool AllHidden = true;
        foreach (var word in _wordList)
        {
            bool Hidden = word.GetIsHidden();
            if (Hidden == false)
                AllHidden = false;
        }
        return AllHidden;

    }
}

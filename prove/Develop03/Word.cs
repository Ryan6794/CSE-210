

public class Word
{
    private string _word;
    private Boolean _IsHidden;

    public Word(string word)
    {
        this._word = word;
    }

    public bool GetIsHidden()
    {
        return _IsHidden;
    }

    public void Hide()
    {
        _IsHidden = true;
    }

    public string GetString()
    {
        if (_IsHidden is true)
            return "___";
        else
            return _word;
    }

}

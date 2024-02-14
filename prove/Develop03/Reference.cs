

public class Reference
{

    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string book, int chapter, string verses)
    {
        this._book = book;
        this._chapter = chapter;
        this._verses = verses;

    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verses}");
    }
}

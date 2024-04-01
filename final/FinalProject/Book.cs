

abstract class Book : Material
{

    protected long _ISBN;
    protected string _Author;

    public Book(long ISBN, string Author, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._ISBN = ISBN;
        this._Author = Author;
    }


    public override abstract void Display();

}
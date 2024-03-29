
class NonFicBook : Book
{

    private double _DeweyDec;


    public NonFicBook(double DeweyDec, long ISBN, string Author, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(ISBN, Author, Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._DeweyDec = DeweyDec;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_Title} Author: {_Author} Publisher: {_Publisher} Location: {_DeweyDec} Genre: {_Genre} ISBN: {_ISBN} Release Date: {_ReleaseDate} CatalogNumber: {_CatalogNumber}");
    }
}